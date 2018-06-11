@extends('layouts.app')

@section('content')
<div class="container">
    <div class="registerTable">
        <div class="registerTable-left">
            <div class="register-info">
                <h2>Registreren</h2>
                <p>De gegevens in uw A-profiel, zoals naam en e-mailadres, worden nooit gedeeld met derden. De stad Antwerpen vindt privacy en de bescherming van uw gegevens erg belangrijk.</p>
            </div>
        </div> 
        <div class="registerTable-right">
            <div class="register-fields">
                <form method="POST" action="{{ route('register') }}">
                    @csrf

                    <div class="form-group">
                        <label for="name" class="col-form-label text-md-right">Voornaam <b> *</b></label>

                        <div>
                            <input id="name" type="text" class="form-control{{ $errors->has('name') ? ' is-invalid' : '' }}" name="name" value="{{ old('name') }}" required autofocus>

                            @if ($errors->has('name'))
                                <span class="invalid-feedback">
                                    <strong>{{ $errors->first('name') }}</strong>
                                </span>
                            @endif
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="lastName" class="col-form-label text-md-right">Achternaam <b> *</b></label>

                        <div>
                            <input id="lastName" type="text" class="form-control{{ $errors->has('lastName') ? ' is-invalid' : '' }}" name="lastName" value="{{ old('lastName') }}" required autofocus>

                            @if ($errors->has('lastName'))
                                <span class="invalid-feedback">
                                    <strong>{{ $errors->first('lastName') }}</strong>
                                </span>
                            @endif
                        </div>
                    </div>

                    
                    <div class="form-group">
                        <label for="email" class="col-form-label text-md-right">E-Mailadres <b> *</b></label>

                        <div>
                            <input id="email" type="email" class="form-control{{ $errors->has('email') ? ' is-invalid' : '' }}" name="email" value="{{ old('email') }}" required>

                            @if ($errors->has('email'))
                                <span class="invalid-feedback">
                                    <strong>{{ $errors->first('email') }}</strong>
                                </span>
                            @endif
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="username" class="col-form-label text-md-right">Anonieme schuilnaam <b> *</b></label>

                        <div>
                            <input id="username" type="text" class="form-control{{ $errors->has('username') ? ' is-invalid' : '' }}" name="username" value="{{ old('username') }}" maxlength="30" required autofocus>

                            @if ($errors->has('username'))
                                <span class="invalid-feedback">
                                    <strong>{{ $errors->first('username') }}</strong>
                                </span>
                            @endif
                        </div>

                        <p class="uitlegSchuilnaam"><span>Uw gebruikersnaam moet tussen 5 en 30 karakters bevatten en kan bestaan uit letters, cijfers en volgende speciale tekens + . _ - @.</span></p>
                    </div>


                    <div class="form-group">
                        <label for="password" class="col-form-label text-md-right">Wachtwoord <b> *</b></label>

                        <div>
                            <input id="password" type="password" class="form-control{{ $errors->has('password') ? ' is-invalid' : '' }}" name="password" required>

                            @if ($errors->has('password'))
                                <span class="invalid-feedback">
                                    <strong>{{ $errors->first('password') }}</strong>
                                </span>
                            @endif
                        </div>
                        <p class="uitlegWachtwoord"><span>Het wachtwoord moet minstens 8 tekens lang zijn, 1 hoofdletter en 1 cijfer bevatten. Symbolen ook toegelaten.</span></p>
                    </div>

                    <div class="form-group">
                        <label for="password-confirm" class="col-form-label text-md-right">Bevestig wachtwoord <b> *</b></label>

                        <div>
                            <input id="password-confirm" type="password" class="form-control" name="password_confirmation" required>
                        </div>
                    </div>

                    <div class="form-group-full">
                        <div>
                            
                            <label for="terms">
                                <input type="checkbox" class="field" name="terms" required>
                                <span class="checkmark"></span>
                                <span class="termsText">Ik ga akkoord met de <a href="https://aprofiel.antwerpen.be/nl/terms" target="_blank"><span>algemene voorwaarden</span></a><b>*</b></span>
                            </label>
                        </div>
                    </div>

                    <div class="form-group-full">
                        <div>
                        <div class="loginButton">
                            <button type="submit" class="btn btn-primary">
                                <span class="fa fa-user"></span>
                                Registreren
                            </button>
                    </div>
                </form>
                <p class="registerLink">Al een A-profiel? <a href="{{ route('login') }}"><span>Login met uw A-profiel</span></a></p>
                <div class="registerFooter">
                    <p class="ng-scope">
                        Met uw A-profiel kunt u aanmelden op deze websites:
                    </p>
                    <p>
                        <a href="http://www.visitantwerpen.be" title="Visit Antwerpen">visitantwerpen.be</a>
                        <a href="https://www.gate15.be/nl/home" title="Gate15">gate15.be</a>
                        <a href="https://www.slimnaarantwerpen.be/nl" title="Slim naar Antwerpen">slimnaarantwerpen.be</a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>
@endsection
