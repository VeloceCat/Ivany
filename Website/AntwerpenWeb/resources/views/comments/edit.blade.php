@extends('layouts.app')

@section('content')

	<h2>Edit Comment</h2>

	@include('comments._form', ['comment' => $comment])
@endsection