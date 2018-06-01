@extends('layouts.app')

@section('content')
<div class="container">
    <div class="loginTable">
        <div class="loginTable-left">
            <div class="login-info">
                <h2>Aanmelden met uw A-profiel</h2>
                <p>Met een A-profiel krijgt u nieuws op maat, hoeft u niet steeds dezelfde gegevens in te vullen bij een aanvraag en kan u reageren op artikels en meepraten in de babbelbox.</p>
            </div>
        </div>

        <div class="loginTable-right">
            <div class="login-fields">   
                <form method="POST" action="{{ route('login') }}">
                    @csrf

                    <div class="form-group">
                        <div>
                            <input id="email" type="email" class="form-control{{ $errors->has('email') ? ' is-invalid' : '' }}" name="email" value="{{ old('email') }}" placeholder="E-mail" required autofocus>

                            @if ($errors->has('email'))
                                <span class="invalid-feedback">
                                    <strong>{{ $errors->first('email') }}</strong>
                                </span>
                            @endif
                        </div>
                    </div>

                    <div class="form-group">
                        <div>
                            <input id="password" type="password" class="form-control{{ $errors->has('password') ? ' is-invalid' : '' }}" name="password" placeholder="Wachtwoord" required>

                            @if ($errors->has('password'))
                                <span class="invalid-feedback">
                                    <strong>{{ $errors->first('password') }}</strong>
                                </span>
                            @endif
                            <a class="forgotPassword" href="{{ route('password.request') }}">
                                <span>Wachtwoord vergeten?</span>
                            </a>
                        </div>
                    </div>

                    <div class="form-group mb-0">
                        <div class="loginButton">
                            <button type="submit" class="btn btn-primary">
                                <span class="fa fa-user"></span>
                                Aanmelden
                            </button>
                        </div>
                    </div>
                </form>
                <p class="registerLink">Nog geen A-profiel? <a href="{{ route('register') }}"><span>Registreer uw A-profiel</span></a></p>
                <div class="loginFooter">
                    <p class="ng-scope">
                        Met uw A-profiel kunt u aanmelden op deze websites:
                    </p>
                    <p>
                        <a href="http://www.visitantwerpen.be" title="Visit Antwerpen">visitantwerpen.be span</a>
                        <a href="https://www.gate15.be/nl/home" title="Gate15">gate15.be</a>
                        <a href="https://www.slimnaarantwerpen.be/nl" title="Slim naar Antwerpen">slimnaarantwerpen.be</a>
                    </p>
                </div>
            </div> 
        </div>
    </div>
</div>
@endsection
