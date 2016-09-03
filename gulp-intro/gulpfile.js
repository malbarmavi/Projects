'use strict'

var gulp = require('gulp');
var sass = require('gulp-sass');
var config = require('./gulp.config');
var autoprefixer = require('gulp-autoprefixer');

gulp.task('log', function () {
    console.log(config);
});

gulp.task('hello', function hello() {
    console.log('hello from gulp.');
});

gulp.task('css', function () {
    return gulp.src(config.sass.src)
        .pipe(sass().on('error', sass.logError))
        .pipe(autoprefixer())
        .pipe(gulp.dest(config.sass.dest));
});

gulp.task('css:watch', function () {
    gulp.watch(config.sass.src, ['css']);
});