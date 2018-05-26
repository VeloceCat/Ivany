@extends('layouts.app')

@section('content')

    <h2>Reactie toevoegen</h2>

    @include('comments._form', ['comment' => $comment])

@stop