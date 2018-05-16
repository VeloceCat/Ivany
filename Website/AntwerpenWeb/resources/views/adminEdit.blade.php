@extends('layouts.app')

@section('content')

    <?php  

        if (isset($_POST['nummer'])) {
            $infoNummer = $_POST['nummer'];
        }
        else {
            $infoNummer = 1;
        }

        if (isset($_POST['delete'])) {
            if ($_POST['delete'] == 'pushed') {
                ?>  <div class="bg-danger clearfix">             
                        <h3>Bent u zeker dat u dit wilt verwijderen?</h3>
                        <div class="confirmButtons">
                            <form action="{{ route('adminEdit') }}" method="POST" class="pull-right">
                                <input type="hidden" name="_token" value="{{ csrf_token() }}">
                                <input type="hidden" name="delete" value="confirmed">
                                <input type="hidden" name="id" value="<?php echo $_POST['id']; ?>">
                                <input type="hidden" name="table" value="<?php echo $_POST['table'] ?>">
                                <button type='submit' name="button" class="btn btn-danger" value="delete">
                                    <i class="fa fa-btn fa-trash" title="delete"></i> Verwijderen
                                </button>
                            </form>
                            <form method='POST' action="{{ route('adminEdit') }}"  class="pull-right"> 
                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                    <input type="hidden" name="id" value="<?php echo $_POST['id']; ?>">
                                    <input type="hidden" name="table" value="<?php echo $_POST['table'] ?>">
                                    <input type='hidden' name='nummer' value="<?php echo $infoNummer; ?>"> 
                                    <button type='submit' class='btn btn-danger'>
                                        <i class='fas fa-times-circle'> Annuleren</i>
                                    </button>
                            </form>
                        </div>
                    </div> <?php
            }

            if ($_POST['delete'] == 'confirmed') {
                $table = $_POST['table'];
                $id = $_POST['id'];
                $dateToPost = date('Y-m-d H:i:s');
                        try {
                            DB::update("UPDATE `$table` SET deleted_at = '$dateToPost' WHERE id='$id'");
                            DB::commit();
                        } catch (\Exception $e) {
                            DB::rollback();
                            $MSG = "Comment failed deleting. " . $e->getMessage() . "";
                            echo $MSG;
                        }
            }
        }

    ?>
           
        <div class="edit-page-container">
            <div>
                <div class="col-md-10 col-md-offset-1">

                    <div class="breadcrumb">
                        
                        <a href="{{ route('admin') }}">← Terug naar overzicht</a>

                    </div>
                @if (isset($_POST['id']))
                    <div class="panel panel-default">
                        <form method='POST' action="{{ route('adminEdit') }}"> 
                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                            <input type='hidden' name='nummer' value='<?php echo $infoNummer; ?>'>
                            <input type='hidden' name='delete' value='pushed'>
                            <input type='hidden' name='id' value='<?php echo $_POST['id']; ?>'>
                            <input type='hidden' name='table' value="<?php echo $_POST['table']; ?>">
                            <button type='submit' class="btn btn-danger"><i class='fa fa-trash'></i> Verwijderen</button>
                        </form>

                        <div class="panel-content">
                            
                            

                            <!-- New Task Form -->
                            <form action="{{ route('admin') }}" method="POST" class="form-horizontal">
                                <input type="hidden" name="_token" value="{{ csrf_token() }}">
                                <input type="hidden" name="edited" value="true">

                                <!-- Article data -->
                                @if ($_POST['table'] == 'articles')
                                    <?php 
                                        $id = $_POST['id'];

                                        $articles = DB::select("SELECT * FROM `articles` WHERE id='$id'");
                                        foreach($articles as $article) {
                                            $title = $article->title;
                                            $text = $article->text;
                                            $blokID = $article->blokID;
                                            $deleted = ($article->deleted_at == null) ? 'false' : 'true';
                                        }
                                    ?>
                                    <input type='hidden' name='id' value='{{$id}}'>
                                    <input type='hidden' name='table' value="articles">
                                    <input type='hidden' name='nummer' value="1">
                                    <div class="form-group">
                                        <div class="col-sm-6">
                                            <label for="titel" class="col-sm-3 control-label">Titel</label>
                                            <input type="text" name="titel" value="{{$title}}" class="form-control">
                                            <label for="text" class="col-sm-3 control-label">Text</label>
                                            <textarea type="text" name="text" class="form-control">{{$text}}</textarea>
                                            <label for="blokID" class="col-sm-3 control-label">Bloknummer</label>
                                            <input type="text" name="blokID" value="{{$blokID}}" class="form-control">
                                            @if ($deleted == 'true')
                                                <label for="undelete" class="col-sm-3 control-label">Herstellen</label>
                                                <input type="checkbox" name="undelete" value="true">
                                            @else
                                                <input type="hidden" name="undelete" value="false">
                                            @endif
                                        </div>
                                    </div>
                                    <!-- Add Article Button -->
                                    <div class="form-group">
                                        <div class="col-sm-offset-3 col-sm-6">
                                            <button type="submit" class="btn btn-default">
                                                <i class="fa fa-pencil-square-o"></i>Bewaren
                                            </button>
                                        </div>
                                    </div>
                                @elseif ($_POST['table'] == 'quotes')
                                    <?php 
                                        $id = $_POST['id'];

                                        $quotes = DB::select("SELECT * FROM `quotes` WHERE id='$id'");
                                        foreach($quotes as $quote) {
                                            $text = $quote->quote;
                                            $blokID = $quote->blokID;
                                            $deleted = ($quote->deleted_at == null) ? 'false' : 'true';
                                        }
                                    ?>
                                    <input type='hidden' name='id' value='{{$id}}'>
                                    <input type='hidden' name='table' value="quotes">
                                    <input type='hidden' name='nummer' value="2">
                                    <div class="form-group">
                                        <div class="col-sm-6">
                                            <label for="text" class="col-sm-3 control-label">Quote</label>
                                            <textarea type="text" name="text" class="form-control">{{$text}}</textarea>
                                            <label for="blokID" class="col-sm-3 control-label">Bloknummer</label>
                                            <input type="text" name="blokID" value="{{$blokID}}" class="form-control">
                                            @if ($deleted == 'true')
                                                <label for="undelete" class="col-sm-3 control-label">Herstellen</label>
                                                <input type="checkbox" name="undelete" value="true">
                                            @else
                                                <input type="hidden" name="undelete" value="false">
                                            @endif
                                        </div>
                                    </div>
                                    <!-- Add Article Button -->
                                    <div class="form-group">
                                        <div class="col-sm-offset-3 col-sm-6">
                                            <button type="submit" class="btn btn-default">
                                                <i class="fa fa-pencil-square-o"></i>Bewaren
                                            </button>
                                        </div>
                                    </div>
                                @endif
                            </form>

                        </div>
                    </div>
                @endif

                </div>
            </div>
        </div>
@endsection