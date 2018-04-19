@extends('layouts.app')

@section('content')

<?php 

$postResults = DB::select('SELECT * FROM posts WHERE deleted_at IS NULL ORDER BY points DESC');
                    foreach($postResults as $postResult) {
                        $voteCounter = $postResult->points;
                        $postedID = $postResult->post_id;
                        $userPosted = $postResult->user_id;
                        $voted = "";


?>
<div id="achtergrond">
    <section>
        <div id="headerLine">
            <h2>HeaderLine</h2>
        </div>
        <div id="info">
            <div class="infoBlok">
                <div class="artikel">
                    <h2>Artikel titel</h2>
                    <p>text text text text text text text text text text text text text text text text text text text text text... <a href="#">lees meer ></a></p>
                </div>
                <div class="artikel">
                    <h2>Artikel titel</h2>
                    <p>text text text text text text text text text text text text text text text text text text text text text... <a href="#">lees meer ></a></p>
                </div>
                <div class="artikel">
                    <h2>Artikel titel</h2>
                    <p>text text text text text text text text text text text text text text text text text text text text text... <a href="#">lees meer ></a></p>
                </div>
            </div>
            <div class="tussenBlok">
                <h2>"Tussenblok met text" - indy bosschem 2018</h2>
            </div>
            <div class="infoBlok">
                <div class="artikel">
                    <h2>Artikel titel</h2>
                    <p>text text text text text text text text text text text text text text text text text text text text text... <a href="#">lees meer ></a></p>
                </div>
                <div class="artikel">
                    <h2>Artikel titel</h2>
                    <p>text text text text text text text text text text text text text text text text text text text text text... <a href="#">lees meer ></a></p>
                </div>
                <div class="artikel">
                    <h2>Artikel titel</h2>
                    <p>text text text text text text text text text text text text text text text text text text text text text... <a href="#">lees meer ></a></p>
                </div>
            </div>
        </div>
    </section>
    <footer>
        <span>© 2018 Antwerpen.be | </span>
            <a href="https://www.antwerpen.be/nl/info/5310f241aaa8a74f6c8b458d/a-stad-uw-privacy-en-hoe-gebruiken" target="_blank"  >Privacy &amp; gebruiksvoorwaarden</a>
            </div>
        </div>
    </footer>
</div>

@endsection
