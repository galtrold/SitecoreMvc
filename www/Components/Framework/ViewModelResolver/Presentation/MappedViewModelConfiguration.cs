using System;
using System.Linq.Expressions;
using Sitecore.Data;
using ViewModelResolver.Infrastructure;

namespace ViewModelResolver.Presentation
{
    public class MappedViewModelConfiguration<T>
    {
        public void SetClassPropertyFieldId(Expression<Func<T, object>> expression, ID fieldId)
        {
            var fullyQualifiedClassName = typeof(T).FullName;
            var propertyName = GetPropertyNameFromExpressionService.Get(expression);
            var fullPropertyName = string.Format("{0}.{1}", fullyQualifiedClassName, propertyName);
            if(!MappingTable.Instance.Map.ContainsKey(fullPropertyName))
                MappingTable.Instance.Map.Add(fullPropertyName, fieldId);
        }
    }
}