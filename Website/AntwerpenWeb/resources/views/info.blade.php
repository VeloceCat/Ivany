@extends('layouts.app')

@section('content')

<div id="achtergrond">
    <section>
        <div id="headerLine">
            <h2>HeaderLine</h2>
        </div>
        <div id="info">
            <?php 
                $counter = 0;
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

                        echo("<div class='artikel'><h2>$title</h2><p>$text...<br><a href='#'>lees meer ></a></p></div>");
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
                                echo("<div class='artikel'><h2>$title</h2><p>$text...<br><a href='#'>lees meer ></a></p></div>");
                            }
                            echo("</div>");
                        }
                    }
                }
            ?>
        </div>
    </section>

@endsection
