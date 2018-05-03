@extends('layouts.app')

@section('content')

    <?php


	function buttonActive($nummer) 
	{
		if (isset($_POST['nummer'])) {
            $n = $_POST['nummer'];
        }
        else {
            $n = 1;
        }
		$id = '';
		
		if ($nummer == $n)
		{
			$id = "id='activeOverKnop'";
		} 
		
		switch($nummer) 
		{
			case 1:
				$buttonNaam = "Artikels";
				break;
				
			case 2:
				$buttonNaam = "Quotes";
				break;
				
			default:
				$buttonNaam = "Artikels";
        }
        ?>

        <form method='POST' action="{{ route('adminPost') }}"> 
            <input type='hidden' name='_token' value='{{ csrf_token() }}'> 
            <input type='hidden' name='nummer' value='<?php echo $nummer ?>'>
            <input type='submit' class='OverKnop' <?php echo $id ?> value='<?php echo $buttonNaam ?>'>
        </form>
        <?php
	}


    if(null !== Auth::user()) {
        if(Auth::user()->is_admin == 1) {
            buttonActive(1);
            buttonActive(2);
            
            if (isset($_POST['nummer'])) {
                $infoNummer = $_POST['nummer'];
            }
            else {
                $infoNummer = 1;
            }
            
            function overzichtInfo($nummer)
            { 
                $variabele = $nummer;

                switch($variabele)
                {
                    case 1:

                            echo "  <table id='myTable'>
                                        <tr id='eersteLijn'>
                                            <th>Titel</th>
                                            <th>Text</th>
                                            <th>Bloknummer</th>
                                            <th>Laatste update</th>
                                            <th>Verwijderd</th>
                                        </tr>
                                        <tr>
                                            <td colspan='5'></td>
                                        </tr>";

                                    $articles = DB::select("SELECT * FROM `articles` ORDER BY id DESC");
                                    foreach($articles as $article) {
                                        $shortendText = substr($article->text, 0, 100);
                                        

                                        echo "  <tr href='#'>
                                                    <td>$article->title</td>
                                                    <td>$shortendText...</td>
                                                    <td>$article->blokID</td>
                                                    <td>$article->updated_at</td>
                                                    <td>$article->deleted_at</td>
                                                </tr>";

                                    }
                                    echo '</table>';
                           
                        break;


                    case 2:

                            echo "  <table id='myTable'>
                                        <tr id='eersteLijn'>
                                            <th>Quote</th>
                                            <th>Bloknummer</th>
                                            <th>Laatste update</th>
                                            <th>Verwijderd</th>
                                        </tr>
                                        <tr>
                                            <td colspan='4'></td>
                                        </tr>";

                                    $articles = DB::select("SELECT * FROM `quotes` ORDER BY id DESC");
                                    foreach($articles as $article) {
                                        $shortendText = substr($article->quote, 0, 100);
                                        

                                        echo "  <tr href='#'>
                                                    <td>$shortendText...</td>
                                                    <td>$article->blokID</td>
                                                    <td>$article->updated_at</td>
                                                    <td>$article->deleted_at</td>
                                                </tr>";

                                    }
                                    echo '</table>';
                                    
                            
                        break;
                }

            }
            overzichtInfo($infoNummer);
        }
        else {
            echo("u bent geen administrator. Om terug te keren klik <a href='{{ route('home') }}'>hier</a>.");
 
        }
    }
    else {
        echo("u bent geen administrator. Om terug te keren klik <a href='{{ route('home') }}'>hier</a>.");
    }

    ?>

@endsection