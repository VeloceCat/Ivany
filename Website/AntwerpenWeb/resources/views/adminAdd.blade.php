@extends('layouts.app')

@section('content')
<?php  

        $infoNummer = $_POST['nummer'];

    ?>
           
        <div class="add-page-container">
            <div>
                <div class="col-md-10 col-md-offset-1">

                    <div class="breadcrumb">
                        <form method='POST' action="{{ route('admin') }}">
                            <input type="hidden" name="_token" value="{{ csrf_token() }}">
                            <input type='hidden' name='nummer' value='<?php echo $infoNummer; ?>'>
                            <button type="submit">← Terug naar overzicht</button>
                        </form>
                    </div>

                        <div class="panel-content">
                            
                            

                            <!-- New Task Form -->
                            <form action="{{ route('admin') }}" method="POST" class="form-horizontal">
                                <input type="hidden" name="_token" value="{{ csrf_token() }}">
                                <input type="hidden" name="added" value="true">

                                <!-- Article data -->
                                @if ($infoNummer == 1)
                                    <input type='hidden' name='table' value="articles">
                                    <input type='hidden' name='nummer' value="1">
                                    <div class="form-group">
                                        <div class="col-sm-6">
                                            <label for="titel" class="col-sm-3 control-label">Titel</label>
                                            <input type="text" name="titel" class="form-control" required>
                                            <label for="text" class="col-sm-3 control-label">Text</label>
                                            <textarea type="text" name="text" class="form-control" required></textarea>
                                            <label for="blokID" class="col-sm-3 control-label">Bloknummer</label>
                                            <input type="text" name="blokID" class="form-control">
                                            <p>Voor elk artikelblok moet er een quote worden opgegeven.</p>
                                        </div>
                                    </div>
                                    <!-- Add Article Button -->
                                    <div class="form-group">
                                        <div class="col-sm-offset-3 col-sm-6">
                                            <button type="submit" class="btn btn-default">
                                                <i class="fa fa-pencil-square-o"></i>Toevoegen
                                            </button>
                                        </div>
                                    </div>
                                @elseif ($infoNummer == 2)
                                    <input type='hidden' name='table' value="quotes">
                                    <input type='hidden' name='nummer' value="2">
                                    <div class="form-group">
                                        <div class="col-sm-6">
                                            <label for="text" class="col-sm-3 control-label">Quote</label>
                                            <textarea type="text" name="text" class="form-control" required></textarea>
                                            <label for="blokID" class="col-sm-3 control-label">Bloknummer</label>
                                            <input type="text" name="blokID" class="form-control">
                                        </div>
                                    </div>
                                    <!-- Add Article Button -->
                                    <div class="form-group">
                                        <div class="col-sm-offset-3 col-sm-6">
                                            <button type="submit" class="btn btn-default">
                                                <i class="fa fa-pencil-square-o"></i>Toevoegen
                                            </button>
                                        </div>
                                    </div>
                                @endif
                            </form>

                        </div>
                    </div>
                </div>
            </div>
@endsection