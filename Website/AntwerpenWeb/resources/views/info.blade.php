@extends('layouts.app')

@section('content')

<div id="achtergrond">
    <section>
        <div id="info">
            <?php 
                $idCounter = 0;
                $maxCharacters = 100; /* text letters */
                $articlesCount = DB::select('SELECT COUNT(id) AS counter FROM `articles` WHERE `deleted_at` IS NULL');
                $firstarticlesnumber = DB::select('SELECT blokID FROM `articles` WHERE `deleted_at` IS NULL LIMIT 1');
                $quotes = DB::select('SELECT * FROM `quotes` WHERE `deleted_at` IS NULL ORDER BY `blokID` ASC');
                foreach($articlesCount as $count) {
                    $counter = $count->counter;
                }
                foreach($firstarticlesnumber as $firstarticlenumber) {
                    $blokID = $firstarticlenumber->blokID;
                    $firstarticles = DB::select("SELECT * FROM `articles` WHERE `deleted_at` IS NULL AND blokID = '$blokID'");

                    ?>
                        <div class="infoTitelBlok">
                            <h1>Lees verhalen die jou misschien kunnen helpen</h1>
                            <p id="infoTitle2">Heel wat mensen en organisaties staan voor je klaar.</p>
                        </div>
                    <?php
                    echo("<div class='infoBlok'>");
                    
                    foreach($firstarticles as $firstarticle) {
                        $title = $firstarticle->title;
                        $text = $firstarticle->text;
                        $shortendText = substr($text, 0, $maxCharacters);
                        $idCounter += 1;

                        echo("<div class='artikel'><h2>$title</h2><p>$shortendText...<br><button onclick='Modal($idCounter)' class='anchorBtn' type='submit'>Lees meer ></button></p></div>");
                        
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
                        if($articleLeft->counter >= 0) {
                            $articles = DB::select("SELECT * FROM `articles` WHERE `deleted_at` IS NULL AND blokID = '$quoteBlokID'");
                            echo("<div class='infoBlok'>");
                            foreach($articles as $article) {
                                $title = $article->title;
                                $text = $article->text;
                                $shortendText = substr($text, 0, $maxCharacters);
                                $idCounter += 1;

                                echo("<div class='artikel'><h2>$title</h2><p>$shortendText...<br><button onclick='Modal($idCounter)' class='anchorBtn' type='submit'>Lees meer ></button></p></div>");
                            }
                            echo("</div>");
                        }
                    }
                }
                    
                    $articlesModal = DB::select("SELECT * FROM `articles` WHERE `deleted_at` IS NULL ORDER BY `blokID` ASC");
                    $idCounter = 0;
                    foreach($articlesModal as $articleModal) {
                        $text = $articleModal->text;
                        $title = $articleModal->title;
                        $idCounter += 1;

                        echo("<div id='$idCounter' class='modal'>
                        <div class='modal-content'>
                            <div class='modal-header'>
                            <h2>$title</h2>
                            <span class='close'>&times;</span>
                        </div>
                        <div class='modal-body'><p>$text</p></div>
                        <div class='modal-footer'></div></div></div>");
                    }
            ?>
        </div>
    </section>

@endsection 
