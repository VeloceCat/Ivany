@extends('layouts.app')

@section('content')

    <?php

    if (isset($_POST['nummer'])) {
        $infoNummer = $_POST['nummer'];
    }
    else {
        if(Auth::user()->is_admin == 1)
        {
            $infoNummer = 1;
        }
        else {
            $infoNummer = 7;
        }
    }

    if ((isset($_POST['delete']) && $_POST['delete'] == 'pushed') || (isset($_POST['allowed']) && $_POST['allowed'] == 'pushed') || (isset($_POST['allowed']) && $_POST['allowed'] == 'repushed')) {
            if (isset($_POST['delete']) && $_POST['delete'] == 'pushed') {
                $headerText = "Bent u zeker dat u dit wilt verwijderen?";
                $name = "delete";
                $button = "Verwijderen";
                $value = "confirmed";
                $class = "fa fa-btn fa-trash";
            }
            elseif (isset($_POST['allowed']) && $_POST['allowed'] == 'repushed') {
                $headerText = "Bent u zeker dat u dit niet meer toelaat op de pagina?";
                $name = "allowed";
                $button = "Niet meer toestaan";
                $value = "unconfirmed";
                $class = "fas fa-times";
            }
            elseif (isset($_POST['allowed']) && $_POST['allowed'] == 'pushed') {
                $headerText = "Bent u zeker dat u dit toelaat op de pagina?";
                $name = "allowed";
                $button = "Toestaan";
                $value = "confirmed";
                $class = "fas fa-check";
            }
            ?>  <div class="bg-danger clearfix">
                    <h3>{{$headerText}}</h3>
                    <div class="confirmButtons">
                        <form action="{{ route('adminPost') }}" method="POST" class="pull-right">
                            <input type="hidden" name="_token" value="{{ csrf_token() }}">
                            <input type="hidden" name="{{$name}}" value="{{$value}}">
                            <input type="hidden" name="id" value="<?php echo $_POST['id']; ?>">
                            <input type="hidden" name="table" value="<?php echo $_POST['table'] ?>">
                            <input type='hidden' name='nummer' value="<?php echo $infoNummer; ?>">
                            <button type='submit' name="button" class="btn btn-danger">
                                <i class="{{$class}}" title="{{$name}}"></i> {{$button}}
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

    if (isset($_POST['delete']) && $_POST['delete'] == 'confirmed') {
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

    if (isset($_POST['allowed']) && $_POST['allowed'] != 'pushed' && $_POST['allowed'] != 'repushed') {
        $table = $_POST['table'];
        $id = $_POST['id'];
        $allowed = $_POST['allowed'];
        $bool = 0;
        $bool = $allowed == 'confirmed'? 1 : 0;

        try {
            DB::update("UPDATE `$table` SET is_allowed = $bool WHERE id='$id'");
            DB::commit();
        } catch (\Exception $e) {
            DB::rollback();
        }
    }

    if (isset($_POST['edited']) && $_POST['edited'] == true) {
        $table = $_POST['table'];
        $id = $_POST['id'];
        $dateToPost =  date('Y-m-d H:i:s');
        $undelete = (isset($_POST['undelete']) && $_POST['undelete'] == 'true') ? ", deleted_at = NULL" : '';
        $allow = (isset($_POST['allow']) && $_POST['allow'] == 'true') ? ", is_allowed = 1" : '';
        $unallow = (isset($_POST['unallow']) && $_POST['unallow'] == 'true') ? ", is_allowed = 0" : '';
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

                DB::update("UPDATE `posts` SET title = '$title', description = $description, user_id = '$userID', updated_at = '$dateToPost' $undelete $allow $unallow WHERE id='$id'");
            }
            elseif ($table == 'comments') {
                $comment = '"'.str_replace('"', '\"', $_POST['comment']).'"';
                $userID = $_POST['userID'];
                $postID = $_POST['postID'];

                DB::update("UPDATE `comments` SET comment = $comment, user_id = '$userID', post_id = '$postID', updated_at = '$dateToPost' $undelete $allow $unallow WHERE id='$id'");
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
        }
    }

    if (isset($_POST['settings_changed']) && $_POST['settings_changed'] == 1) {
        session()->now('message', 'Je gegevens zijn opgeslagen.');
        $id = $_POST['id'];
        $name = $_POST['name'];
        $lastName = $_POST['lastName'];
        $email = $_POST['email'];
        $userName = '"'.$_POST['username'].'"';
        /*$password = '';
        if ($_POST['password'] != ''){
            $password = 'password="'.Hash::make($_POST['password']).'"';
        }*/
        try {
            DB::update("UPDATE `users` SET name='$name', lastName='$lastName', email='$email', userName=$userName/*, $password*/  WHERE id='$id'");
        } catch (\Exception $e) {
            DB::rollback();
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
            case 5:
                $buttonNaam = "Bevestig post <p class='counter'>" . DB::table('posts')->where('is_allowed', '=', 0)->where('deleted_at', '=', NULL)->count() . "</p>";
                break;
            case 6:
                $buttonNaam = "Bevestig reactie <p class='counter'>" . DB::table('comments')->where('is_allowed', '=', 0)->where('deleted_at', '=', NULL)->count() . "</p>";
                break;
            case 7:
                $buttonNaam = "Mijn posts";
                break;
            case 8:
                $buttonNaam = "Mijn reacties";
                break;
            case 9:
                $buttonNaam = "Gebruiker instel.";
                break;
			default:
				$buttonNaam = "Artikels";
        }

        ?> <form method='POST' action="{{ route('adminPost') }}">
            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
            <input type='hidden' name='nummer' value='<?php echo $nummer ?>'>
            <button type='submit' class='keuzeknop' <?php echo $id ?>><?php echo $buttonNaam ?></button>
        </form> <?php
	}


    if(null !== Auth::user()) {
        if(Auth::user()->is_admin == 1) {
            $user = Auth::user()->id;
            echo "<div class='keuzeknoppen'>";
            ?>
            @if($infoNummer == 1 || $infoNummer == 2)
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
            buttonActive(5,$infoNummer);
            buttonActive(6,$infoNummer);
            buttonActive(9,$infoNummer);
            echo "</div>";
            overzichtInfo($infoNummer, $user);
        }
        else {
            $user = Auth::user()->id;
            echo "<div class='keuzeknoppen'>";
            ?>
            @if($infoNummer == 1 || $infoNummer == 2)
                <form method='POST' action="{{ route('adminAdd') }}">
                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                    <input type='hidden' name='nummer' value='7'>
                    <button type='submit' class='keuzeknop plusknop'><i class="fas fa-plus"></i></button>
                </form>
            @endif
            <?php
            buttonActive(7,$infoNummer);
            buttonActive(8,$infoNummer);
            buttonActive(9,$infoNummer);
            echo "</div>";
            overzichtInfo($infoNummer, $user);
        }
    }
    else {
        ?> <p>U bent niet ingelogd. Om terug te keren klik <a href='{{ route('home') }}'>hier</a><p> <?php
    }



    function overzichtInfo($nummer, $u)
    {
        $user = $u;
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
                                                    <input type='hidden' name='id' value='{{$article->id}}'>
                                                    <input type='hidden' name='table' value="articles">
                                                    <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                </form>

                                                <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}">
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='1'>
                                                    <input type='hidden' name='delete' value='pushed'>
                                                    <input type='hidden' name='id' value='{{$article->id}}'>
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
                                                    <input type='hidden' name='id' value='{{$article->id}}'>
                                                    <input type='hidden' name='table' value="quotes">
                                                    <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                </form>

                                                <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}">
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='2'>
                                                    <input type='hidden' name='delete' value='pushed'>
                                                    <input type='hidden' name='id' value='{{$article->id}}'>
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
                            $posts = DB::select("SELECT * FROM `posts` WHERE is_allowed='1' ORDER BY deleted_at ASC, id DESC");
                            foreach($posts as $post) {
                                $shortendText = substr($post->description, 0, 100);
                                $deleted = ($post->deleted_at == null) ? 'Nee' : $post->deleted_at;
                                $updated = ($post->updated_at == null) ? 'Nooit' : $post->updated_at;

                                echo "  <tr href='#'>
                                            <td class='editbuttons'>"
                                            ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='nummer' value='3'>
                                            <input type='hidden' name='id' value='{{$post->id}}'>
                                            <input type='hidden' name='table' value="posts">
                                            <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                            </form>

                                            <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='nummer' value='3'>
                                            <input type='hidden' name='delete' value='pushed'>
                                            <input type='hidden' name='id' value='{{$post->id}}'>
                                            <input type='hidden' name='table' value="posts">
                                            @if ($deleted == 'Nee')
                                                <button type='submit'><i class='fa fa-trash'></i></button>
                                            @endif
                                            </form>

                                            <form class='buttonUncheck' method='POST' action="{{ route('adminPost') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='nummer' value='3'>
                                            <input type='hidden' name='allowed' value='repushed'>
                                            <input type='hidden' name='id' value='{{$post->id}}'>
                                            <input type='hidden' name='table' value="posts">
                                            <button type='submit'><i class="fas fa-times"></i></button>
                                            </form><?php

                                            echo"</td><td>$post->title</td><td>$shortendText...</td><td>$post->user_id</td><td>$updated</td><td>$deleted</td></tr>";
                            }
                            echo '</table>';

                break;

                case 4:
                    echo "  <table id='myTable'><tr><th></th><th>Reacties</th><th>Gebruikersnummer</th><th>Post nummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='6'></td></tr>";
                            $comments = DB::select("SELECT * FROM `comments` WHERE is_allowed='1' ORDER BY deleted_at ASC, id DESC");
                            foreach($comments as $comment) {
                                $shortendText = substr($comment->comment, 0, 100);
                                $deleted = ($comment->deleted_at == null) ? 'Nee' : $comment->deleted_at;
                                $updated = ($comment->updated_at == null) ? 'Nooit' : $comment->updated_at;

                                echo "  <tr href='#'>
                                            <td class='editbuttons'>"
                                            ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}">
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='4'>
                                                    <input type='hidden' name='id' value='{{$comment->id}}'>
                                                    <input type='hidden' name='table' value="comments">
                                                    <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                </form>

                                                <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}">
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='4'>
                                                    <input type='hidden' name='delete' value='pushed'>
                                                    <input type='hidden' name='id' value='{{$comment->id}}'>
                                                    <input type='hidden' name='table' value="comments">
                                                    @if ($deleted == 'Nee')
                                                        <button type='submit'><i class='fa fa-trash'></i></button>
                                                    @endif
                                                </form>

                                                <form class='buttonUncheck' method='POST' action="{{ route('adminPost') }}">
                                                <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                <input type='hidden' name='nummer' value='4'>
                                                <input type='hidden' name='allowed' value='repushed'>
                                                <input type='hidden' name='id' value='{{$comment->id}}'>
                                                <input type='hidden' name='table' value="comments">
                                                <button type='submit'><i class="fas fa-times"></i></button>
                                                </form><?php

                                            echo"</td><td>$shortendText...</td><td>$comment->user_id</td><td>$comment->post_id</td><td>$updated</td><td>$deleted</td></tr>";
                            }
                            echo '</table>';

                break;

                case 5:
                    echo "  <table id='myTable'><tr><th></th><th>Titel</th><th>Text</th><th>Gebruikersnummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='6'></td></tr>";
                            $posts = DB::select("SELECT * FROM `posts` WHERE is_allowed ='0' ORDER BY deleted_at ASC, id DESC");
                            foreach($posts as $post) {
                                $shortendText = substr($post->description, 0, 100);
                                $deleted = ($post->deleted_at == null) ? 'Nee' : $post->deleted_at;
                                $updated = ($post->updated_at == null) ? 'Nooit' : $post->updated_at;

                                echo "  <tr href='#'>
                                            <td class='editbuttons'>"
                                            ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='nummer' value='5'>
                                            <input type='hidden' name='id' value='{{$post->id}}'>
                                            <input type='hidden' name='table' value="posts">
                                            <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                            </form>

                                            <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='nummer' value='5'>
                                            <input type='hidden' name='delete' value='pushed'>
                                            <input type='hidden' name='id' value='{{$post->id}}'>
                                            <input type='hidden' name='table' value="posts">
                                            @if ($deleted == 'Nee')
                                                <button type='submit'><i class='fa fa-trash'></i></button>
                                            @endif
                                            </form>

                                            <form class='buttonCheck' method='POST' action="{{ route('adminPost') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='nummer' value='5'>
                                            <input type='hidden' name='allowed' value='pushed'>
                                            <input type='hidden' name='id' value='{{$post->id}}'>
                                            <input type='hidden' name='table' value="posts">
                                            <button type='submit'><i class="fas fa-check"></i></button>
                                            </form><?php

                                            echo"</td><td>$post->title</td><td>$shortendText...</td><td>$post->user_id</td><td>$updated</td><td>$deleted</td></tr>";
                            }
                            echo '</table>';

                break;

                case 6:
                    echo "  <table id='myTable'><tr><th></th><th>Reacties</th><th>Gebruikersnummer</th><th>Post nummer</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='6'></td></tr>";
                            $comments = DB::select("SELECT * FROM `comments` WHERE is_allowed ='0' ORDER BY deleted_at ASC, id DESC");
                            foreach($comments as $comment) {
                                $shortendText = substr($comment->comment, 0, 100);
                                $deleted = ($comment->deleted_at == null) ? 'Nee' : $comment->deleted_at;
                                $updated = ($comment->updated_at == null) ? 'Nooit' : $comment->updated_at;

                                echo "  <tr href='#'>
                                            <td class='editbuttons'>"
                                            ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}">
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='6'>
                                                    <input type='hidden' name='id' value='{{$comment->id}}'>
                                                    <input type='hidden' name='table' value="comments">
                                                    <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                </form>

                                                <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}">
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='6'>
                                                    <input type='hidden' name='delete' value='pushed'>
                                                    <input type='hidden' name='id' value='{{$comment->id}}'>
                                                    <input type='hidden' name='table' value="comments">
                                                    @if ($deleted == 'Nee')
                                                        <button type='submit'><i class='fa fa-trash'></i></button>
                                                    @endif
                                                </form>

                                                <form class='buttonCheck' method='POST' action="{{ route('adminPost') }}">
                                                <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                <input type='hidden' name='nummer' value='6'>
                                                <input type='hidden' name='allowed' value='pushed'>
                                                <input type='hidden' name='id' value='{{$comment->id}}'>
                                                <input type='hidden' name='table' value="comments">
                                                <button type='submit'><i class="fas fa-check"></i></button>
                                                </form><?php

                                            echo"</td><td>$shortendText...</td><td>$comment->user_id</td><td>$comment->post_id</td><td>$updated</td><td>$deleted</td></tr>";
                            }
                            echo '</table>';

                break;

                case 7:
                    echo "  <table id='myTable'><tr><th>Titel</th><th>Text</th><th>Gebruikersnummer</th><th>Goedgekeurd</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='7'></td></tr>";
                            $posts = DB::select("SELECT * FROM `posts` WHERE user_id = '$user' ORDER BY deleted_at ASC, id DESC");
                            foreach($posts as $post) {
                                $shortendText = substr($post->description, 0, 100);
                                $deleted = ($post->deleted_at == null) ? 'Nee' : $post->deleted_at;
                                $updated = ($post->updated_at == null) ? 'Nooit' : $post->updated_at;
                                $checked = ($post->is_allowed == '1') ? 'Ja' : 'Nee';

                                echo "  <tr href='#'>
                                            <td class='editbuttons'>"
                                            ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='nummer' value='7'>
                                            <input type='hidden' name='id' value='{{$post->id}}'>
                                            <input type='hidden' name='table' value="posts">
                                            <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                            </form>

                                            <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='nummer' value='7'>
                                            <input type='hidden' name='delete' value='pushed'>
                                            <input type='hidden' name='id' value='{{$post->id}}'>
                                            <input type='hidden' name='table' value="posts">
                                            @if ($deleted == 'Nee')
                                                <button type='submit'><i class='fa fa-trash'></i></button>
                                            @endif
                                            </form><?php

                                            echo"</td><td>$post->title</td><td>$shortendText...</td><td>$post->user_id</td><td>$checked</td><td>$updated</td><td>$deleted</td></tr>";
                            }
                            echo '</table>';

                break;

                case 8:
                    echo "  <table id='myTable'><tr><th></th><th>Reacties</th><th>Gebruikersnummer</th><th>Post nummer</th><th>Goedgekeurd</th><th>Laatste update</th><th>Verwijderd</th></tr><tr><td colspan='7'></td></tr>";
                            $comments = DB::select("SELECT * FROM `comments` WHERE user_id = '$user' ORDER BY deleted_at ASC, id DESC");
                            foreach($comments as $comment) {
                                $shortendText = substr($comment->comment, 0, 100);
                                $deleted = ($comment->deleted_at == null) ? 'Nee' : $comment->deleted_at;
                                $updated = ($comment->updated_at == null) ? 'Nooit' : $comment->updated_at;
                                $checked = ($comment->is_allowed == '1') ? 'Ja' : 'Nee';

                                echo "  <tr href='#'>
                                            <td class='editbuttons'>"
                                            ?> <form class='buttonEdit' method='POST' action="{{ route('adminEdit') }}">
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='4'>
                                                    <input type='hidden' name='id' value='{{$comment->id}}'>
                                                    <input type='hidden' name='table' value="comments">
                                                    <button type='submit'><i class='fas fa-pencil-alt'></i></button>
                                                </form>

                                                <form class='buttonDelete' method='POST' action="{{ route('adminPost') }}">
                                                    <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                                    <input type='hidden' name='nummer' value='4'>
                                                    <input type='hidden' name='delete' value='pushed'>
                                                    <input type='hidden' name='id' value='{{$comment->id}}'>
                                                    <input type='hidden' name='table' value="comments">
                                                    @if ($deleted == 'Nee')
                                                        <button type='submit'><i class='fa fa-trash'></i></button>
                                                    @endif
                                                </form><?php

                                            echo"</td><td>$shortendText...</td><td>$comment->user_id</td><td>$comment->post_id</td><td>$checked</td><td>$updated</td><td>$deleted</td></tr>";
                            }
                            echo '</table>';

                break;

                case 9:
                    $datas = DB::select("SELECT * FROM `users` WHERE id = '$user'");
                    $name = '';
                    $lastName = '';
                    $email = '';
                    $userName = '';

                    foreach($datas as $data) {
                        $name = $data->name;
                        $lastName = $data->lastName;
                        $email = $data->email;
                        $userName = $data->username;
                    }
                ?>
                        <div class="registerTable">
                            <div class="registerTable-left">
                                <div class="register-info">
                                    <h2>Gebruikers instellingen</h2>
                                    <p>De gegevens in uw A-profiel, zoals naam en e-mailadres, worden nooit gedeeld met derden. De stad Antwerpen vindt privacy en de bescherming van uw gegevens erg belangrijk.</p>
                                </div>
                            </div>
                            <div class="registerTable-right">
                                <div class="register-fields">
                                    <form method="POST" action="{{ route('adminPost') }}">
                                        <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                        <input type='hidden' name='settings_changed' value='1'>
                                        <input type='hidden' name='nummer' value='9'>
                                        <input type='hidden' name='id' value='{{$user}}'>
                                        {{ csrf_field() }}

                                        <div class="form-group">
                                            <label for="name" class="col-form-label text-md-right">Voornaam <b> *</b></label>

                                            <div>
                                                <input id="name" type="text" class="form-control" name="name" value="{{$name}}" required autofocus>
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <label for="lastName" class="col-form-label text-md-right">Achternaam <b> *</b></label>

                                            <div>
                                                <input id="lastName" type="text" class="form-control" name="lastName" value="{{$lastName}}" required autofocus>
                                            </div>
                                        </div>


                                        <div class="form-group">
                                            <label for="email" class="col-form-label text-md-right">E-Mailadres <b> *</b></label>

                                            <div>
                                                <input id="email" type="email" class="form-control" name="email" value="{{$email}}" required>
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <label for="username" class="col-form-label text-md-right">Anonieme schuilnaam <b> *</b></label>

                                            <div>
                                                <input id="username" type="text" class="form-control" name="username" value="{{$userName}}" maxlength="30" required autofocus>
                                            </div>

                                            <p class="uitlegSchuilnaam"><span>Uw gebruikersnaam moet tussen 5 en 30 karakters bevatten en kan bestaan uit letters, cijfers en volgende speciale tekens + . _ - @ (spaties zijn niet toegestaan).</span></p>
                                        </div>

                                        <div class="form-group-full">
                                            <div class="loginButton">
                                                <button type="submit" class="btn btn-primary">
                                                    <span class="fa fa-user"></span>
                                                    Wijzigen
                                                </button>
                                            </div>
                                        </div>
                                    </form>
                                    <form id="passReset" method="POST" action="{{ route('passReset') }}">
                                            <input type='hidden' name='_token' value='{{ csrf_token() }}'>
                                            <input type='hidden' name='id' value='{{$user}}'>
                                            <div class="form-group-full">
                                                <div>
                                                    <a href="#" onclick="document.getElementById('passReset').submit();">Wachtwoord wijzigen</a>
                                                </div>
                                            </div>
                                        </form>
                                </div>
                            </div>
                        </div><?php

                break;
        }

    }?>


@endsection
