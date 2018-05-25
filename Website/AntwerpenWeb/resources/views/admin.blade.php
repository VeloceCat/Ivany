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
                            <input type='hidden' name='nummer' value="<?php echo $infoNummer; ?>"> 
                            <button type='submit' name="button" class="btn btn-danger" value="delete">
                                <i class="fa fa-btn fa-trash" title="delete"></i> Verwijderen
                            </button>
                        </form>
                        <form method='POST' action="{{ route('adminPost') }}"  class="pull-right"> 
                                <input type='hidden' name='_token' value='{{ csrf_token() }}'>
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
                /*$MSG = "Comment failed deleting. " . $e->getMessage() . "";
                echo $MSG;*/
            }
        }
    }

    if (isset($_POST['edited']) && $_POST['edited'] == true) {
        $table = $_POST['table'];
        $id = $_POST['id'];
        $dateToPost =  date('Y-m-d H:i:s');
        $undelete = (isset($_POST['undelete']) && $_POST['undelete'] == 'true') ? ", deleted_at = NULL" : '';
        try {
            if ($table == 'articles') {
                $title = '"'.str_replace('"', '\"', $_POST['titel']).'"';
                $text = '"'.str_replace('"', '\"', $_POST['text']).'"';
                $blokID = $_POST['blokID'];

                DB::update("UPDATE `articles` SET title = $title, text = $text, blokID = '$blokID', updated_at = '$dateToPost' $undelete WHERE id='$id' ");
            }
            elseif ($table == 'quotes') {
                $blokID =  $_POST['blokID'];
                $quote = '"'.str_replace('"', '\"', $_POST['text']).'"';
                DB::update("UPDATE `quotes` SET quote = $quote, blokID = '$blokID', updated_at = '$dateToPost' $undelete WHERE id='$id'");
            }
            elseif ($table == 'posts') {
                $title = $_POST['title'];
                $description = '"'.str_replace('"', '\"', $_POST['description']).'"';
                $userID = $_POST['userID'];

                DB::update("UPDATE `posts` SET title = '$title', description = $description, user_id = '$userID', updated_at = '$dateToPost' $undelete WHERE id='$id'");
            }
            elseif ($table == 'comments') {
                $comment = '"'.str_replace('"', '\"', $_POST['comment']).'"';
                $userID = $_POST['userID'];
                $postID = $_POST['postID'];

                DB::update("UPDATE `comments` SET comment = $comment, user_id = '$userID', post_id = '$postID', updated_at = '$dateToPost' $undelete WHERE id='$id'");
            }
            DB::commit();
        } catch (\Exception $e) {
            DB::rollback();
            $MSG = $table . " failed editing. " . $e->getMessage() . "";
            echo $MSG;
        }
    }

    if (isset($_POST['added']) && $_POST['added'] == true) {
        $table = $_POST['table'];
        $dateToPost = '"' . date('Y-m-d H:i:s') . '"';
        try {
            if ($table == 'articles') {
                $title = '"' . $_POST['titel'] . '"';
                $text = '"' . $_POST['text'] . '"';
                $blokID = '"' . $_POST['blokID'] . '"';
                DB::insert("INSERT INTO `articles`(`title`, `text`, `blokID`, `created_at`) VALUES ($title, $text, $blokID, $dateToPost)");
            }
            elseif ($table == 'quotes') {
                $quote = '"' . $_POST['text'] . '"';
                $blokID = '"' . $_POST['blokID'] . '"';
                DB::insert("INSERT INTO `quotes`(`quote`, `blokID`, `created_at`) VALUES ($quote, $blokID, $dateToPost)");
            }
            DB::commit();
        } catch (\Exception $e) {
            DB::rollback();
            /*$MSG = "Comment failed inserting. " . $e->getMessage() . "";
            echo $MSG;*/
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
            case 3:
                $buttonNaam = "Forum posts";
                break;
            case 4:
                $buttonNaam = "Forum reacties";
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
            echo "<div class='keuzeknoppen'>";
            ?> 
            @if($infoNummer != 3 && $infoNummer != 4)
                <form method='POST' action="{{ route('adminAdd') }}"> 
                    <input type='hidden' name='_token' value='{{ csrf_token() }}'> 
                    <input type='hidden' name='nummer' value='{{$infoNummer}}'>
                    <button type='submit' class='keuzeknop plusknop'><i class="fas fa-plus"></i></button>
                </form>
            @endif
            <?php
            buttonActive(1,$infoNummer);
            buttonActive(2,$infoNummer);
            buttonActive(3,$infoNummer);
            buttonActive(4,$infoNummer);
            echo "</div>";
            
            function overzichtInfo($nummer)
            { 
                $variabele = $nummer;

                switch($variabele)
                {
                    case 1:
                            echo "  <table id='myTable'><tr><th></th><th>Titel</th><th>Text</th><th>Bloknummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='6'></td></tr>";
                                    $articles = DB::select("SELECT * FROM `articles` ORDER BY deleted_at ASC, id DESC");
                                    foreach($articles as $article) {
                                        $shortendText = substr($article->text, 0, 100);
                                        $deleted = ($article->deleted_at == null) ? 'Nee' : $article->deleted_at;
                                        $updated = ($article->updated_at == null) ? 'Nooit' : $article->updated_at;

                                        echo "  <tr href='#'>
                                                    <td class='editbuttons'>"        
                                                    ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='nummer' value='1'>
                                                            <input type='hidden' name='id' value='<?php echo $article->id ?>'>
                                                            <input type='hidden' name='table' value="articles">
                                                            <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                        </form>
                                                        
                                                        <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='nummer' value='1'>
                                                            <input type='hidden' name='delete' value='pushed'>
                                                            <input type='hidden' name='id' value='<?php echo $article->id ?>'>
                                                            <input type='hidden' name='table' value="articles">
                                                            @if ($deleted == 'Nee')
                                                                <button type='submit'><i class='fa fa-trash'></i></button>
                                                            @endif
                                                        </form> <?php
                                                    
                                                    echo"</td><td>$article->title</td><td>$shortendText...</td><td>$article->blokID</td><td>$updated</td><td>$deleted</td></tr>";
                                    }
                                    echo '</table>';
                           
                        break;


                    case 2:
                            echo "  <table id='myTable'><tr id='eersteLijn'><th></th><th>Quote</th><th>Bloknummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='5'></td></tr>";
                                    $articles = DB::select("SELECT * FROM `quotes` ORDER BY deleted_at ASC, id DESC");
                                    foreach($articles as $article) {
                                        $shortendText = substr($article->quote, 0, 100);
                                        $deleted = ($article->deleted_at == null) ? 'Nee' : $article->deleted_at;
                                        $updated = ($article->updated_at == null) ? 'Nooit' : $article->updated_at;

                                        echo "  <tr href='#'>
                                                    <td class='editbuttons'>"        
                                                    ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='nummer' value='2'>
                                                            <input type='hidden' name='id' value='<?php echo $article->id ?>'>
                                                            <input type='hidden' name='table' value="quotes">
                                                            <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                        </form>
                                                        
                                                        <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='nummer' value='2'>
                                                            <input type='hidden' name='delete' value='pushed'>
                                                            <input type='hidden' name='id' value='<?php echo $article->id ?>'>
                                                            <input type='hidden' name='table' value="quotes">
                                                            @if ($deleted == 'Nee')
                                                                <button type='submit'><i class='fa fa-trash'></i></button>
                                                            @endif
                                                        </form> <?php
                                                    
                                                    echo"</td><td>$shortendText...</td><td>$article->blokID</td><td>$updated</td><td>$deleted</td></tr>";

                                    }
                                    echo '</table>';
                                    
                            
                        break;

                        case 3:
                            echo "  <table id='myTable'><tr><th></th><th>Titel</th><th>Text</th><th>Gebruikersnummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='6'></td></tr>";
                                    $posts = DB::select("SELECT * FROM `posts` ORDER BY deleted_at ASC, id DESC");
                                    foreach($posts as $post) {
                                        $shortendText = substr($post->description, 0, 100);
                                        $deleted = ($post->deleted_at == null) ? 'Nee' : $post->deleted_at;
                                        $updated = ($post->updated_at == null) ? 'Nooit' : $post->updated_at;

                                        echo "  <tr href='#'>
                                                    <td class='editbuttons'>"
                                                    ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}"> 
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='3'>
                                                    <input type='hidden' name='id' value='<?php echo $post->id ?>'>
                                                    <input type='hidden' name='table' value="posts">
                                                    <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                    </form>

                                                    <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}"> 
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='3'>
                                                    <input type='hidden' name='delete' value='pushed'>
                                                    <input type='hidden' name='id' value='<?php echo $post->id ?>'>
                                                    <input type='hidden' name='table' value="posts">
                                                    @if ($deleted == 'Nee')
                                                        <button type='submit'><i class='fa fa-trash'></i></button>
                                                    @endif
                                                    </form> <?php
                                                    
                                                    echo"</td><td>$post->title</td><td>$shortendText...</td><td>$post->user_id</td><td>$updated</td><td>$deleted</td></tr>";
                                    }
                                    echo '</table>';
                           
                        break;

                        case 4:
                            echo "  <table id='myTable'><tr><th></th><th>Reacties</th><th>Gebruikersnummer</th><th>Post nummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='6'></td></tr>";
                                    $comments = DB::select("SELECT * FROM `comments` ORDER BY deleted_at ASC, id DESC");
                                    foreach($comments as $comment) {
                                        $shortendText = substr($comment->comment, 0, 100);
                                        $deleted = ($comment->deleted_at == null) ? 'Nee' : $comment->deleted_at;
                                        $updated = ($comment->updated_at == null) ? 'Nooit' : $comment->updated_at;

                                        echo "  <tr href='#'>
                                                    <td class='editbuttons'>"        
                                                    ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='nummer' value='4'>
                                                            <input type='hidden' name='id' value='<?php echo $comment->id ?>'>
                                                            <input type='hidden' name='table' value="comments">
                                                            <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                        </form>
                                                        
                                                        <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}"> 
                                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                            <input type='hidden' name='nummer' value='4'>
                                                            <input type='hidden' name='delete' value='pushed'>
                                                            <input type='hidden' name='id' value='<?php echo $comment->id ?>'>
                                                            <input type='hidden' name='table' value="comments">
                                                            @if ($deleted == 'Nee')
                                                                <button type='submit'><i class='fa fa-trash'></i></button>
                                                            @endif
                                                        </form> <?php
                                                    
                                                    echo"</td><td>$shortendText...</td><td>$comment->user_id</td><td>$comment->post_id</td><td>$updated</td><td>$deleted</td></tr>";
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