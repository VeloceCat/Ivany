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
    <link href="{{ asset('css/responsive.css') }}" rel="stylesheet">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.10/css/all.css" integrity="sha384-+d0P83n9kaQMCwj8F4RJB66tzIwOKmrdb46+porD/OvrJ+37WqIM7UoBtwHO6Nlg" crossorigin="anonymous">
    <link rel="shortcut icon" href="{{ asset('/img/A_Logo.svg') }}" >
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
                        <li id="logo"><a href="{{ route('home') }}" title="Klik hier om terug naar de startpagina te gaan."><img src="{{ asset('/img/A_Logo_RGB.svg') }}" alt="logo"></a></li>
                    </ul>

                    <!-- Right Side Of Navbar -->
                    <ul id="navigatie" class="navbar-nav ml-auto">
                        
                        @if (Request::is('/'))
                            <li  class='active'><a href="{{ route('home')  }}">Home</a></li>
                            <li><a href="{{ route('info') }}">Info</a></li>
                            <li><a href="{{ route('game') }}">Game</a></li>
                            <li><a href="{{ route('forum') }}">Forum</a></li>
                            <li><a href="{{ route('contact') }}">Contact</a></li>
                            <!-- Authentication Links -->
                            @guest
                                <li><a class="nav-link" href="{{ route('login') }}">Login</a></li>
                            @else
                                <li class="nav-item dropdown">
                                    <a id="navbarDropdown" class="nav-link" href="{{ route('admin') }}" role="button">
                                        {{ Auth::user()->name }} 
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
                            <!--@if(null !== Auth::user())
                                @if(Auth::user()->is_admin == 1)
                                    <li {{ Request::is('admin') ? ' class=active' : null }}><a href="{{ route('admin') }}">Admin</a></li>
                                @endif
                                <li id="btnLogout">
                                    <a href="{{ route('logout') }}"onclick="event.preventDefault();document.getElementById('logout-form').submit();">Logout</a>

                                    <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                                        @csrf
                                    </form>
                                </li>
                            @endif-->
                        @else
                            <li {{ Request::is('home') ? ' class=active' : null }}><a href="{{ route('home') }}">Home</a></li>
                            <li {{ Request::is('info') ? ' class=active' : null }}><a href="{{ route('info') }}">Info</a></li>
                            <li {{ Request::is('game') ? ' class=active' : null }}><a href="{{ route('game') }}">Game</a></li>
                            <li {{ Request::is('forum') ? ' class=active' : null }}><a href="{{ route('forum') }}">Forum</a></li>
                            <li {{ Request::is('contact') ? ' class=active' : null }}><a href="{{ route('contact') }}">Contact</a></li>
                            <!-- Authentication Links -->
                            @guest
                                <li><a class="nav-link" href="{{ route('login') }}">Login</a></li>
                            @else
                                <li class="nav-item dropdown  {{ Request::is('admin') ? ' active' : null }}">
                                    <a id="navbarDropdown" class="nav-link" href="{{ route('admin') }}" role="button">
                                        {{ Auth::user()->name }} 
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
                            <!--@if(null !== Auth::user())
                                @if(Auth::user()->is_admin == 1)
                                    <li {{ Request::is('admin') ? ' class=active' : null }}><a href="{{ route('admin') }}">Admin</a></li>
                                @endif
                                <li id="btnLogout">
                                    <a href="{{ route('logout') }}"onclick="event.preventDefault();document.getElementById('logout-form').submit();">Logout</a>

                                    <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                                        @csrf
                                    </form>
                                </li>
                            @endif-->
                        @endif

                    </ul>
                </div>
            </div>
        </nav>

        <main class="py-4">

                @yield('content')
                <a href="javascript:void(0)" id="scroll" title="Naar de top van de pagina"><i class="fas fa-arrow-alt-circle-up"></i></a>
                <footer>
                    <span>© 2018 Antwerpen.be | </span>
                    <a href="https://www.antwerpen.be/nl/info/5310f241aaa8a74f6c8b458d/a-stad-uw-privacy-en-hoe-gebruiken" target="_blank"  >Privacy &amp; gebruiksvoorwaarden</a>
                </footer>
            </div>

        </main>
    </div>

    <!-- Scripts -->
    <script src="{{ asset('js/app.js') }}"></script>
    <script src="{{ asset('js/scroll.js') }}"></script>
    <script src="{{ asset('js/modal.js') }}"></script>
</body>

</html>
