@extends('layouts.app')

@section('content')

    @include('posts._form', ['post' => $post])

@stop