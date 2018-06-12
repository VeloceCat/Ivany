@extends('layouts.app')

@section('content')
<div id="home">
    <section>
        <div id="homeText">
            <div class="textFullWidth">
                <h1>Seksuele intimidatie bij jongeren</h1>
                <p>Bezoek de info pagina voor allerlei verhalen. Speel het spel om in de schoenen van een slachtoffer te staan.  <tekstwegopmobile> We willen hierbij slachtoffers helpen, omstaanders leren begrijpen en mensen waarschuwen. </tekstwegopmobile> Voor hulp kan je op het forum of op de contactpagina terecht.</p>
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
