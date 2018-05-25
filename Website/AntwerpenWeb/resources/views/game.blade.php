@extends('layouts.app')

@section('content')

    <div class="webgl-content">
        <div id="gameContainer" style="width: 960px; height: 600px"></div>
        <div class="footer">
            <div class="webgl-logo"></div>
            <div class="fullscreen" onclick="gameInstance.SetFullscreen(1)"></div>
            <div class="title">Antwerp game</div>
        </div>
    </div>

@endsection
