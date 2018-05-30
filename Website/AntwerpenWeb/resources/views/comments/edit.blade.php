@extends('layouts.app')

@section('content')

	@include('comments._form', ['comment' => $comment])
	
@endsection