<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class HomeController extends Controller
{
    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        
    }

    /**
     * Show the application dashboard.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return view('home');
    }

    public function info()
    {
        return view('info');
    }

    public function forum()
    {
        return view('forum');
    }

    public function contact()
    {
        return view('contact');
    }

    public function game()
    {
        return view('game');
    }

    public function admin()
    {
        return view('admin');
    }

    public function adminEdit()
    {
        return view('adminEdit');
    }

}
