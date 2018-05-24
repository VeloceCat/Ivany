<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', 'HomeController@index')->name('home');

Route::get('/home', 'HomeController@index')->name('home');

Route::get('/info', 'HomeController@info')->name('info');

Route::get('/contact', 'HomeController@contact')->name('contact');

Route::get('/game', 'HomeController@game')->name('game');


Auth::routes();

Route::group(['middleware' => 'auth'], function () {
    Route::get('/admin', 'HomeController@admin')->name('admin');

    Route::post('/admin', 'HomeController@admin')->name('adminPost');

    Route::post('/adminEdit', 'HomeController@adminEdit')->name('adminEdit');

    Route::post('/adminAdd', 'HomeController@adminAdd')->name('adminAdd');

    
    Route::get('/forum/create', 'PostsController@create')->name('create_post_path');

    Route::post('/forum', 'PostsController@store')->name('store_post_path');

    Route::get('/forum/{post}/edit', 'PostsController@edit')->name('edit_post_path');

    Route::put('/forum/{post}', 'PostsController@update')->name('update_post_path');

    Route::delete('/forum/{post}', 'PostsController@delete')->name('delete_post_path');


    Route::get('/comments/{post_id}/create', 'CommentsController@create')->name('create_comment_path');

    Route::post('/comments/{post_id}', 'CommentsController@store')->name('store_comment_path');

    Route::get('/comments/{id}/edit', 'CommentsController@edit')->name('edit_comment_path');

    Route::put('/comments/{id}', 'CommentsController@update')->name('update_comment_path');

    Route::delete('/comments/{comment}', 'CommentsController@delete')->name('delete_comment_path');
});


Route::get('/forum', 'PostsController@index')->name('posts_path');

Route::get('/forum/{post}', 'PostsController@show')->name('post_path');