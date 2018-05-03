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
                        <form action="{{ route('adminPost') }}" method="POST" class="pull-right">
                            <input type="hidden" name="_token" value="{{ csrf_token() }}">
                            <input type="hidden" name="delete" value="confirmed">
                            <input type="hidden" name="id" value="<?php echo $_POST['id']; ?>">
                            <input type="hidden" name="table" value="<?php echo $_POST['table'] ?>">
                            <button type='submit' name="button" class="btn btn-danger" value="delete">
                                <i class="fa fa-btn fa-trash" title="delete"></i> Verwijderen
                            </button>
                        </form>
                        <form method='POST' action="{{ route('adminPost') }}"  class="pull-right"> 
                                <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                <input type='hidden' name='nummer' value="<?php echo $infoNummer; ?>"> 
                                <button type='submit' class='btn btn-danger'><i class='fas fa-times-circle'> Annuleren</i></button>
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


	function buttonActive($nummer, $n) {
		$id = '';
		
		if ($nummer == $n) {
			$id = "id='activeKeuzeknop'";
		} 
		
		switch($nummer) {
			case 1:
				$buttonNaam = "Artikels";
				break;
			case 2:
				$buttonNaam = "Quotes";
				break;
			default:
				$buttonNaam = "Artikels";
        }
        
        ?> <form method='POST' action="{{ route('adminPost') }}"> 
            <input type='hidden' name='_token' value='{{ csrf_token() }}'> 
            <input type='hidden' name='nummer' value='<?php echo $nummer ?>'>
            <input type='submit' class='keuzeknop' <?php echo $id ?> value='<?php echo $buttonNaam ?>'>
        </form> <?php
	}


    if(null !== Auth::user()) {
        if(Auth::user()->is_admin == 1) {
            buttonActive(1,$infoNummer);
            buttonActive(2,$infoNummer);
            
            function overzichtInfo($nummer)
            { 
                $variabele = $nummer;

                switch($variabele)
                {
                    case 1:
                            echo "  <table id='myTable'><tr><th></th><th>Titel</th><th>Text</th><th>Bloknummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='6'></td></tr>";
                                    $articles = DB::select("SELECT * FROM `articles` WHERE deleted_at IS NULL ORDER BY id DESC");
                                    foreach($articles as $article) {
                                        $shortendText = substr($article->text, 0, 100);
                                        

                                        echo "  <tr href='#'>
                                                    <td>"        
                                                    ?> <form method='POST' action="{{ route('adminEdit') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'> 
                                                            <input type='hidden' name='id' value='<?php echo $article->id ?>'>
                                                            <input type='hidden' name='table' value="articles">
                                                            <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                        </form>
                                                        
                                                        <form method='POST' action="{{ route('adminPost') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='nummer' value='1'>
                                                            <input type='hidden' name='delete' value='pushed'>
                                                            <input type='hidden' name='id' value='<?php echo $article->id ?>'>
                                                            <input type='hidden' name='table' value="articles">
                                                            <button type='submit'><i class='fa fa-trash'></i></button>
                                                        </form> <?php
                                                    
                                                    echo"</td><td>$article->title</td><td>$shortendText...</td><td>$article->blokID</td><td>$article->updated_at</td><td>$article->deleted_at</td></tr>";
                                    }
                                    echo '</table>';
                           
                        break;


                    case 2:
                            echo "  <table id='myTable'><tr id='eersteLijn'><th></th><th>Quote</th><th>Bloknummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='5'></td></tr>";
                                    $articles = DB::select("SELECT * FROM `quotes` WHERE deleted_at IS NULL ORDER BY id DESC");
                                    foreach($articles as $article) {
                                        $shortendText = substr($article->quote, 0, 100);
                                        

                                        echo "  <tr href='#'>
                                                    <td>"        
                                                    ?> <form method='POST' action="{{ route('adminEdit') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='id' value='<?php echo $article->id ?>'>
                                                            <input type='hidden' name='table' value="quotes">
                                                            <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                        </form>
                                                        
                                                        <form method='POST' action="{{ route('adminPost') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='nummer' value='2'>
                                                            <input type='hidden' name='delete' value='pushed'>
                                                            <input type='hidden' name='id' value='<?php echo $article->id ?>'>
                                                            <input type='hidden' name='table' value="quotes">
                                                            <button type='submit'><i class='fa fa-trash'></i></button>
                                                        </form> <?php
                                                    
                                                    echo"</td><td>$shortendText...</td><td>$article->blokID</td><td>$article->updated_at</td><td>$article->deleted_at</td></tr>";

                                    }
                                    echo '</table>';
                                    
                            
                        break;
                }

            }
            overzichtInfo($infoNummer);
        }
        else {
            ?> u bent geen administrator. Om terug te keren klik <a href='{{ route('home') }}'>hier</a> <?php
        }
    }
    else {
        ?> u bent geen administrator. Om terug te keren klik <a href='{{ route('home') }}'>hier</a> <?php
    }
    ?>
@endsection