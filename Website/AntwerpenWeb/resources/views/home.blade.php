@extends('layouts.app')

@section('content')
<div id="home">
    <section>
        <div id="homeText">
            <div class="textFullWidth">
                <h1>Seksuele intimidatie bij jongeren</h1>
                <p>Bezoek onze info pagina voor allerlei verhalen. Speel het spel om je te verplaatsen in de schoenen van een slachtoffer.  We willen hierbij slachtoffers helpen, omstaanders leren begrijpen en mensen waarschuwen. Voor hulp kan je op ons forum of op onze contactpagina terecht.</p>
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
