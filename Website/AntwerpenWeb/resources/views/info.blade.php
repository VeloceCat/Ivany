@extends('layouts.app')

@section('content')

<div id="achtergrond">
    <section>
        <div id="info">
            <?php 
                $counter = 0;
                $maxCharacters = 100; /* text letters */
                $articlesCount = DB::select('SELECT COUNT(id) AS counter FROM `articles` WHERE `deleted_at` IS NULL');
                $firstarticlesnumber = DB::select('SELECT blokID FROM `articles` WHERE `deleted_at` IS NULL LIMIT 1');
                $quotes = DB::select('SELECT * FROM `quotes` WHERE `deleted_at` IS NULL');
                foreach($articlesCount as $count) {
                    $counter = $count->counter;
                }
                foreach($firstarticlesnumber as $firstarticlenumber) {
                    $blokID = $firstarticlenumber->blokID;
                    $firstarticles = DB::select("SELECT * FROM `articles` WHERE `deleted_at` IS NULL AND blokID = '$blokID'");

                    echo("<div class='infoBlok'>");
                    foreach($firstarticles as $firstarticle) {
                        $title = $firstarticle->title;
                        $text = $firstarticle->text;
                        $id = $firstarticle->id;
                        $shortendText = substr($text, 0, $maxCharacters);

                        echo("<div class='artikel'><h2>$title</h2><p>$shortendText...<br><button onclick='Modal($id)' class='anchorBtn' type='submit'>lees meer ></button></p></div>");
                        
                    }
                    echo("</div>");
                }
                foreach($quotes as $quote) {
                    $quoteText = $quote->quote;
                    $quoteBlokID = $quote->blokID;
                    $quoteBlokID += 1;

                    echo("<div class='tussenBlok'><h2>$quoteText</h2></div>");

                    $articlesLeft = DB::select("SELECT COUNT(id) AS counter FROM `articles` WHERE `deleted_at` IS NULL AND blokID = '$quoteBlokID'  LIMIT 1");
                    foreach($articlesLeft as $articleLeft) {
                        if($articleLeft->counter > 0) {
                            $articles = DB::select("SELECT * FROM `articles` WHERE `deleted_at` IS NULL AND blokID = '$quoteBlokID'");
                            echo("<div class='infoBlok'>");
                            foreach($articles as $article) {
                                $title = $article->title;
                                $text = $article->text;
                                $id = $article->id;
                                $shortendText = substr($text, 0, $maxCharacters);

                                echo("<div class='artikel'><h2>$title</h2><p>$shortendText...<br><button onclick='Modal($id)' class='anchorBtn' type='submit'>lees meer ></button></p></div>");
                            }
                            echo("</div>");
                        }
                    }
                }
                    
                    $articlesModal = DB::select("SELECT * FROM `articles` WHERE `deleted_at` IS NULL");
                    foreach($articlesModal as $articleModal) {
                        $text = $articleModal->text;
                        $title = $articleModal->title;
                        $id = $articleModal->id;

                        echo("<div id='$id' class='modal'>
                        <div class='modal-content'>
                            <div class='modal-header'>
                            <span class='close'>&times;</span><h2>$title</h2></div>
                        <div class='modal-body'><p>$text</p></div>
                        <div class='modal-footer'><h3>Modal Footer</h3></div></div></div>");
                    }

                    echo("<button onclick='Modal(4)' class='anchorBtn' type='submit'>lees meer ></button>");
            ?>
        </div>
    </section>

@endsection 
