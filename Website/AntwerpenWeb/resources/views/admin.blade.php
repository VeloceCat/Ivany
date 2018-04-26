@extends('layouts.app')

@section('content')

    <?php

    if(null !== Auth::user()) {
        if(Auth::user()->is_admin == 1) {
            
            echo('<h2>foo</h2>');
        }
        else {
            echo("u bent geen administrator. Om terug te keren klik <a href='{{ route('home') }}'>hier</a>.");
 
        }
    }
    else {
        return redirect()->back()->with('error', 'Something went wrong.');
    }

    ?>

@endsection