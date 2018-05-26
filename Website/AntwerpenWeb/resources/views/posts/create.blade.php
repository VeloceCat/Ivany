@extends('layouts.app')

@section('content')

    <h2>Post toevoegen</h2>

    @include('posts._form', ['post' => $post])

@stop