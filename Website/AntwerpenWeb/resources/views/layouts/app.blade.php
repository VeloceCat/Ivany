<!DOCTYPE html>
<html lang="{{ app()->getLocale() }}">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <!-- CSRF Token -->
        <meta name="csrf-token" content="{{ csrf_token() }}">

        <title>Seksuele Intimidatie</title>

        <!-- Styles -->
        <link href="{{ asset('css/app.css') }}" rel="stylesheet">
        <link href="{{ asset('css/style.css') }}" rel="stylesheet">
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.10/css/all.css" integrity="sha384-+d0P83n9kaQMCwj8F4RJB66tzIwOKmrdb46+porD/OvrJ+37WqIM7UoBtwHO6Nlg" crossorigin="anonymous">
        <link rel="shortcut icon" href="{{ asset('TemplateData/favicon.ico') }}">
        <link rel="shortcut icon" href="{{ asset('img/favicon.ico') }}">
        <link rel="stylesheet" href="{{ asset('TemplateData/style.css') }}">
        <link href="{{ asset('css/responsive.css') }}" rel="stylesheet">
    </head>
    <body>
        <div id="app">
            <nav class="navbar navbar-expand-md navbar-light navbar-laravel">
                <div class="container">
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse" id="navbarSupportedContent">
                        <!-- Left Side Of Navbar -->
                        <ul class="navbar-nav mr-auto">
                            <li id="logo"><a href="{{ route('home') }}" title="Klik hier om terug naar de startpagina te gaan."><img src="{{ asset('/img/ALogo.png') }}" alt="logo"></a></li>
                        </ul>

                        <!-- Right Side Of Navbar -->
                        <ul id="navigatie" class="navbar-nav ml-auto">
                            <li {{ Request::is('home') ? ' class=active' : (Request::is('/') ? ' class=active' : null) }}><a class="nav-link" href="{{ route('home') }}">Home</a></li>
                            <li {{ Request::is('info') ? ' class=active' : null }}><a class="nav-link" href="{{ route('info') }}">Info</a></li>
                            <li {{ Request::is('game') ? ' class=active' : null }}><a class="nav-link" href="{{ route('game') }}">Game</a></li>
                            <li {{ Request::is('forum') ? ' class=active' : null }}><a class="nav-link" href="{{ route('posts_path') }}">Forum</a></li>
                            <li {{ Request::is('contact') ? ' class=active' : null }}><a class="nav-link" href="{{ route('contact') }}">Contact</a></li>
                            <!-- Authentication Links -->
                            @guest
                                <li><a class="nav-link" href="{{ route('login') }}">Login</a></li>
                            @else
                            <?php
                                $postCount = DB::table('posts')->where('is_allowed', '=', 0)->where('deleted_at', '=', NULL)->count();
                                $commentCount = DB::table('comments')->where('is_allowed', '=', 0)->where('deleted_at', '=', NULL)->count();
                            ?>
                                <li class="nav-item dropdown  {{ Request::is('admin') ? ' active' : null }}">
                                    <a id="navbarDropdown" class="nav-link" href="{{ route('admin') }}" role="button">
                                        {{ Auth::user()->name }}
                                        @if(Auth::user()->is_admin == 1 && ($commentCount+$postCount) != 0)
                                            <i class="fas fa-exclamation"></i>
                                        @endif
                                    </a>
                                    <a id="navbarDropdown" class="nav-link dropdown-toggle" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                        <span class="caret"></span>
                                    </a>

                                    <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                                        <a class="dropdown-item" href="{{ route('logout') }}"
                                        onclick="event.preventDefault();
                                                        document.getElementById('logout-form').submit();">
                                            Afmelden
                                        </a>

                                        <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                                            @csrf
                                        </form>
                                    </div>
                                </li>
                            @endguest
                        </ul>
                    </div>
                </div>
            </nav>

            <main class="py-4">
                    @include('layouts._errors')
                    @include('layouts._messages')
                    @include('layouts._dangers')
                    
                    @yield('content')
                    <a href="javascript:void(0)" id="scroll" title="Naar de top van de pagina"><i class="fas fa-arrow-alt-circle-up"></i></a>
                </div>
            </main>
        </div>
        <footer>
            <span>© 2018 Antwerpen.be | </span>
            <a href="https://www.antwerpen.be/nl/info/5310f241aaa8a74f6c8b458d/a-stad-uw-privacy-en-hoe-gebruiken" target="_blank"><span>Privacy &amp; gebruiksvoorwaarden</span></a>
            <span> | </span>
            <a href="mailto:forum@antwerpen.be?Subject=Forum%20probleem" target="_top"><span>Contacteer de beheerder.</span></a>
        </footer>

        <!-- Scripts -->
        <script src="{{ asset('js/app.js') }}"></script>
        <script src="{{ asset('js/scroll.js') }}"></script>
        <script src="{{ asset('js/modal.js') }}"></script>
        <script src="{{ asset('TemplateData/UnityProgress.js') }}"></script>  
        <script src="{{ asset('Build/UnityLoader.js') }}"></script>
        <script>
            var gameInstance = UnityLoader.instantiate("gameContainer", "Build/Build 11-06-2018.json", {onProgress: UnityProgress});
        </script>
    </body>
</html>
