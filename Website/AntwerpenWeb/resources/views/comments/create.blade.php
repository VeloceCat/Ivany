@extends('layouts.app')

@section('content')

    <h2>Add Comment</h2>

    @include('comments._form', ['comment' => $comment])

@stop