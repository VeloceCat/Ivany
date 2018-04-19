@extends('layouts.app')

@section('content')
<div id="home">
    <section>
        <div id="homeText">
            <div class="textFullWidth">
                <h1>Seksuele intimidatie bij jongeren</h1>
                <p>Dit is de site van Antwerpen over Seksuele intimidatie. Om meer te leren kan je hieronder onze verhalen en feiten terugvinden of het spel spelen. We willen hierbij slachtoffers helpen, omstaanders leren begrijpen en mensen waarschuwen. </p>
            </div>
        </div>
        <div id="buttons">
            <div class="buttonFullWidth">
                <button id="btnInfo" type="button" onclick="window.location.href='{{ route('info') }}'">Lees de verhalen</button>
            </div>
            <div class="buttonFullWidth">
                <button id="btnGame" type="button" onclick="window.location.href='{{ route('game') }}'">Speel het spel</button>
            </div>
        </div>
    </section>
</div>
@endsection
