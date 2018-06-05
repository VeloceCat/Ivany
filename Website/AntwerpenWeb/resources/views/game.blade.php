@extends('layouts.app')

@section('content')
    <p class="hintForMobileGame">Tip: draai je telefoon of tablet eerst in landscape en klik dan op "Fullscreen"</p>
    <div class="webgl-content">
        <div id="gameContainer"></div>
        <div class="footer">
            <div class="webgl-logo"></div>
            <div class="fullscreen" onclick="gameInstance.SetFullscreen(1)"></div>
            <div class="title">Een dag in de schoenen van...</div>
        </div>
    </div>

@endsection
