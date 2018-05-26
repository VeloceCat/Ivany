@extends('layouts.app')

@section('content')

	<h2>Reactie bewerken</h2>
	@include('comments._form', ['comment' => $comment])
	
@endsection