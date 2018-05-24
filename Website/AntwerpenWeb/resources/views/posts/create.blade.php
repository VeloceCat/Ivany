@extends('layouts.app')

@section('content')

    <h2>Add Article</h2>

    @include('posts._form', ['post' => $post])

@stop