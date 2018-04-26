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
Route::post('/info', 'HomeController@info')->name('info');
Route::get('/forum', 'HomeController@forum')->name('forum');
Route::get('/contact', 'HomeController@contact')->name('contact');
Route::get('/game', 'HomeController@game')->name('game');


Route::group(['middleware' => 'auth'], function () {
    
});

Auth::routes();