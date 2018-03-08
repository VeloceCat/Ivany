@extends('layouts.app')

@section('content')
<div id="home">
    <button type="button" onclick="window.location.href='{{ route('info') }}'">Lees de verhalen</button>
    <button type="button" onclick="window.location.href='{{ route('game') }}'">Speel het spel</button>
</div>
@endsection
