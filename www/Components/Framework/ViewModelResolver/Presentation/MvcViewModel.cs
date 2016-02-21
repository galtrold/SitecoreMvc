using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Newtonsoft.Json;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using ViewModelResolver.Infrastructure;
using Rendering = Sitecore.Mvc.Presentation.Rendering;

namespace ViewModelResolver.Presentation
{
    public class MvcViewModel<T> : RenderingModel
    {
        [JsonIgnore]
        public string ItemId => DataItem?.ID.ToString() ?? "";

        [JsonIgnore]
        public string ItemUrl => DataItem != null ? LinkManager.GetItemUrl(DataItem).Replace(" ", "%20") : "WARN-dataitem-not-set";

        [JsonIgnore]
        public string ItemName => DataItem != null ? DataItem.DisplayName : "WARN-dataitem-not-set";

        [JsonIgnore]
        public Item DataItem { get; set; }

        public MvcViewModel()
        {
            
        } 

        public MvcViewModel(Item dataItem)
        {
            DataItem = dataItem;
        }

        public MvcViewModel(Rendering rendering)
        {
            Initialize(rendering);
        }

        public virtual void Initialize(Item dataItem)
        {
            
        }

        protected ID GetPropertyId(Expression<Func<T, object>> expression)
        {
            string propName = "";
            if (expression.Body is MemberExpression)
                propName = ((MemberExpression)expression.Body).Member.Name;

            var fullyQualifiedName = typeof(T).FullName;

            var key = string.Format("{0}.{1}", fullyQualifiedName, propName);


            ID itemId;
            if (MappingTable.Instance.Map.TryGetValue(key, out itemId))
                return itemId;

            Log.Error(string.Format("Kunne ikke finde item id for '{0}'", key), this);
            return new ID("");
        }

        public HtmlString Field(Expression<Func<T, object>> expression)
        {
            var fieldId = "";
            var itemId = "";
            try
            {
                var propId = GetPropertyId(expression);
                fieldId = propId.ToString();

                Item item = null;

                if (DataItem != null)
                    item = DataItem;

                if (item == null)
                    item = Rendering.Item;


                itemId = item.ID.ToString();
                var field = FieldRenderer.Render(item, fieldId);
                if (field != null)
                {
                    return new HtmlString(field);
                }
                return new HtmlString(string.Empty);

            }
            catch (Exception ex)
            {
                
                Log.Error($"An error occured while rendering a field ({fieldId}) on dataItem ({itemId}). Rich text fields can sometimes contaion invalid html. Try formatting it in the sitecore editor", ex, this);
                return new HtmlString("Ups.. someone droped the letters during the typing of this field. We will have this mess cleaned up as soon a possible.");
                
            }
            
        }

        public TP GetItemReference<TP>(Expression<Func<T, object>> expression) where TP : MvcViewModel<TP>, new()
        {
            if (DataItem == null)
                return new TP();

            var propId = GetPropertyId(expression);
            ReferenceField dropDownSelectedItem = DataItem.Fields[propId];
            if (dropDownSelectedItem == null)
            {
                return new TP();
            }
            
            var targetItem = dropDownSelectedItem.TargetItem;
            return new TP { DataItem = targetItem};
        }

        public IEnumerable<TK> List<TK>(Expression<Func<T, object>>  expression) where TK : MvcViewModel<TK>, new()
        {
            if(DataItem == null)
                return new List<TK>();

            var propId = GetPropertyId(expression);

            var listField = DataItem.Fields[propId];

            var database = Sitecore.Context.Database;

            var listItemIds = listField.Value.Split('|');

            if(string.IsNullOrWhiteSpace(listField.Value) || listItemIds.Length < 1)
                return new List<TK>();

            var listItems  = listItemIds.Select(p => new TK{DataItem = database.GetItem(p)});

            return listItems;
        }

        
    }
}