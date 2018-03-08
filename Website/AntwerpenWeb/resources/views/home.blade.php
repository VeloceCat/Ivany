@extends('layouts.app')

@section('content')
<div id="home">
    <div id="homeText">
        <div class="textFullWidth">
            <h1>Seksuele intimidatie bij jongeren</h1>
            <p>Dit is de site van Antwerpen over Seksuele intimidatie. Om meer te leren kan je onze verhalen en feiten lezen of The Game spelen hier onder.</p>
        </div>
    </div>
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
