@extends('layouts.app')

@section('content')
<?php
    $user = $_POST['id'];

    if (isset($_POST['password'])) {
        $password = $_POST['password'];
        $passwordConfirm = $_POST['password_confirmation'];
        $uppercase = preg_match('@[A-Z]@', $password);
        $lowercase = preg_match('@[a-z]@', $password);
        $number    = preg_match('@[0-9]@', $password);

        if($passwordConfirm == $password) {
            if(!$uppercase || !$lowercase || !$number || strlen($password) < 8) {
                session()->now('danger', 'Je wachtwoord voldoed niet aan het minimum. Het wachtwoord moet minstens 8 tekens lang zijn, 1 hoofdletter en 1 cijfer bevatten. Symbolen ook toegelaten.');
            }
            else {
                session()->now('message', 'Je wachtwoord is gewijzigd.');
                $password = 'password="'.Hash::make($_POST['password']).'"';

                try {
                    DB::update("UPDATE `users` SET $password  WHERE id='$user'");
                } catch (\Exception $e) {
                    DB::rollback();
                }
            }
        }
        else {
            session()->now('danger', 'Gelieve hetzelfde wachtwoord 2 keer in te geven.');
        }
    }


?>
    <div class="edit-page-container">
        <div class="breadcrumb">
            <form method='POST' action="{{ route('admin') }}">
                <input type="hidden" name="_token" value="{{ csrf_token() }}">
                <input type='hidden' name='nummer' value='9'>
                <button type="submit">← Terug naar instellingen</button>
            </form>
        </div>
    </div>
    <div class="registerTable">
        <div class="registerTable-left">
            <div class="register-info">
                <h2>Wachtwoord wijzigen</h2>
                <p>De gegevens in uw A-profiel, zoals naam en e-mailadres, worden nooit gedeeld met derden. De stad Antwerpen vindt privacy en de bescherming van uw gegevens erg belangrijk.</p>
            </div>
        </div>
        <div class="registerTable-right">
            <div class="register-fields">
                <form method="POST" action="{{ route('passReset') }}">
                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                    <input type="hidden" name='id' value='{{$user}}'>

                    <div class="form-group">
                        <label for="password" class="col-form-label text-md-right">Nieuw wachtwoord <b> *</b></label>
                        <div>
                            <input id="password" type="password" class="form-control" name="password" required>
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
                        <div class="loginButton">
                            <button type="submit" class="btn btn-primary">
                                <span class="fa fa-user"></span>
                                Wijzigen
                            </button>
                    </div>
                </form>
            </div>
        </div>
    </div>
@endsection
