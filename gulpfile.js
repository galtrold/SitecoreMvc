
var gulp = require('gulp'),
    wiredep = require('wiredep').stream;

gulp.task('bower', function () {
  gulp.src('./www/Components/Project/PageTypes/Views/StandardLayout.cshtml')
    .pipe(wiredep({
            bowerJson: require('./bower.json'),
            directory: './www/bower_components',
            "overrides":{
                "bootstrap":{
                    "main":[
                        "dist/js/bootstrap.js",
                        "dist/css/bootstrap.min.css",
                        "less/bootstrap.less"]
                }
            }
            //ignorePath: config.bower.ignorePath
        }))
    .pipe(gulp.dest('./www/Components/Project/PageTypes/Views'));
});