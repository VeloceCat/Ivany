@extends('layouts.app')

@section('content')
<div id="home">
    <div id="buttons">
        <div class="buttonFullWidth">
            <button type="button" onclick="window.location.href='{{ route('info') }}'">Lees de verhalen</button>
        </div>
        <div class="buttonFullWidth">
            <button type="button" onclick="window.location.href='{{ route('game') }}'">Speel het spel</button>
        </div>
    </div>
</div>
@endsection
