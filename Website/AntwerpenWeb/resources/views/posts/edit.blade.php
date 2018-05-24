@extends('layouts.app')

@section('content')

    <h2>Edit Article</h2>
    @include('posts._form', ['post' => $post])


@stop