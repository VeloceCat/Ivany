using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvent : ChoiceScript {

    public override void RandomDialogue()
    {
        choiceMade = 0;
        chain = 0;
        int rnd = Random.Range(1, 6);
        Consequences(rnd);
    }

    public override void StartTalking(int num)
    {
        switch (num)
        {
            // bij alle cases narrativeText meegeven en numberOfChoices, voor exit bool endOfEvent op true zetten
            case 1:
                narrativeText = "Terwijl je rustig aan het wandelen bent fluit er iemand naar je. Je kijkt om je heen maar hebt geen idee wie het was. Maar het geeft je een raar gevoel en je denkt er de hele dag over na, “heb ik iets verkeerd gedaan?”";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 2:
                narrativeText = "Het is druk onderweg en plots voel je iets raars. Iemand die je duidelijk bewust aanraakt. Je kijkt haastig rond, maar je kan onmogelijk weten wie het gedaan heeft.";
                moodValue = -10;
                endOfEvent = true;
                break;

            case 3:
                narrativeText = "Een man roept naar je \"Hela! Met u wil ik wel eens een nachtje plezier maken!\" Gevolgd door luid gelach. Je besluit om snel verder te gaan en het gewoon te negeren. Je hoort verder niets meer, maar de beledigende woorden verpesten wel de rest van de dag. Dit gaat je nog wel lang bijblijven, jammer genoeg.";
                moodValue = -15;
                endOfEvent = true;
                break;

            case 4:
                chain = 8;
                narrativeText = "Op de tram merk je dat er een vrouw al de hele tijd in jou richting zit te kijken. \"Zit ze naar mij te staren?\" vraag je jezelf af.";
                numberOfOptions = 3;
                option01Text = "Je besluit een halte vroeger af te stappen.";//Je krijg een ongemakkelijk gevoel en besluit een halte vroeger af te stappen. Het is goed weer een wandeling zal je goed doen.
                option02Text = "Je zoekt een andere plaats op de tram.";// uit het zicht van de vrouw en stapt af aan je normale halte.
                option03Text = "Je blijft zitten waar je zit."; // en probeert de vrouw te negeren en je stapt aan je normale halte af.
                if (StaticInfo.HasPhone)
                {
                    numberOfOptions = 4;
                    option04Text = "Je belt je vrienden om te laten weten wat er aan de hand is en ze komen je opwachten aan je halte. De vrouw draait meteen naar de andere kant wanneer ze ziet dat je bij je iemand staat te praten.";
                }
                
                break;

            case 5:
                chain = 16;
                narrativeText = "Een man spreekt je aan, hij ziet er normaal uit maar hij kijkt je raar aan. De man zat je al een tijd aan te staren.";
                numberOfOptions = 3;
                option01Text = "Je antwoord kort op zijn vragen."; //Je bent beleefd en antwoord kort op zijn vragen en probeert duidelijk te maken dat je geen zin hebt om te praten.
                option02Text = "Je negeert hem."; // hopelijk snapt hij dat je geen zin hebt in een gesprek.
                option03Text = "Je praat met hem."; //je hebt toch nog heel wat tijd voor je bent waar je moet zijn.
                if (StaticInfo.HasPhone)
                {
                    numberOfOptions = 4;
                    option04Text = "Je stuurt een vriend een bericht met wat er aan de hand is en dat je gebeld moet worden.";
                }
                
                break;
                //              making a choice is not as easy as it looks, or is easier?
                //hier kan zeker een schim verschijnen en misschien kan de achtergrond ook een beetje donkerder?
            case 6:
                chain = 49;
                narrativeText = "Bijna op je bestemming wordt je plots een steegje ingetrokken, je probeert te roepen maar al snel voel je een hand over je mond. Een vrouw heeft je de steeg in getrokken en is je aan het betasten.";
                numberOfOptions = 3;
                option01Text = "Je probeert met al je macht om jezelf vrij te krijgen.";
                option02Text = "Je bijt in de hand over je mond om zo te kunnen roepen.";
                option03Text = "\"Als ik ze niet tegen werk is het misschien sneller voorbij\" denk je en laat de vrouw begaan.";
                break;


            //light**************************************************//


            case 9:
                narrativeText = "Door de wandeling ben je een beetje later. “Waar bleef je?” vraagt iemand?";
                numberOfOptions = 2;
                option01Text = "Je verteld wat er gebeurd is.";
                option02Text = "Je zegt dat de tram wat te laat was.";
                break;

            case 10:
                narrativeText = "Je stapt buiten en voelt de warmte van de zon op je gezicht.";
                chain = 14;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 11:
                narrativeText = "Je stapt buiten en voelt de warmte van de zon op je gezicht.";
                chain = 14;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 12:
                narrativeText = "Je vrienden komen je opwachten aan je halte. De vrouw draait meteen naar de andere kant wanneer ze ziet dat je bij je iemand staat te praten.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 13:
                narrativeText = "Je vrienden vertellen je dat ze wellicht aan het dromen was.";
                moodValue = -5;
                //Energy = -10;
                endOfEvent = true;
                break;

            case 14:
                narrativeText = "Je dag gaat verder zoals gepland. Maar je blijft wel moet de vrouw in he hoofd zitten.";
                moodValue = -5;
                //Energy = -10;
                endOfEvent = true;
                break;

            case 15:
                int rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "De vrouw zie je niet meer terug en je vergeet het voorval al snel.";
                    //geen effect

                }
                else
                {
                    narrativeText = "De vrouw stapt ook uit. En achtervolgt je. Wanneer je op je bestemming aankomt en je achterom kijkt is ze verdwenen. Je bent de hele dag bang dat je de vrouw weer zal tegenkomen.";
                    moodValue = -5;

                }
                endOfEvent = true;
                break;


            //medium**************************************************//


            case 17:
                narrativeText = "Hij stelt rare vragen, hij is duidelijk niet gewoon op zoek naar iemand om zomaar een praatje mee te doen.";
                chain = 20;
                numberOfOptions = 1;
                option01Text = "...";
                break;
                

            case 18:
                chain = 22;
                narrativeText = "Hij blijft nog even doorvragen.";
                numberOfOptions = 2;
                option01Text = "Je blijft hem negeren.";
                option02Text = "Je zegt hem dat je niet wilt praten.";
                break;

            case 19:
                narrativeText = "Na een tijdje begint hij hele specifieke en rare vragen te stellen. Hij vraagt of je een ‘liefje’ hebt en waar je naartoe gaat.";
                chain = 25;
                numberOfOptions = 2;
                option01Text = "Je antwoord op al zijn vragen"; //ook al hij heeft daar eigenlijk niets mee te maken.
                option02Text = "\"sorry maar dat zijn jouw zaken niet\"";// en negeert hem";
                break;
                
            case 20:
                narrativeText = "Je vriend belt je op en de man gaat weg.";
                moodValue = -10;
                endOfEvent = true;
                break;

            case 21:
                int rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "Hij merkt door je korte antwoorden dat je niet van plan bent om te veel te zeggen en hij gaat weg. “Wat een rare man” denk je in jezelf.";
                    //geen effect
                }
                else
                {
                    narrativeText = "Hij blijft alsnog doorvragen maar wanneer hij vraagt of je een ‘liefje’ hebt besluit je dat het genoeg is en je stapt snel weg van hem.";
                    chain = 21;
                    numberOfOptions = 1;
                    option01Text = "...";
                    
                }
                
                break;

            case 22:
                rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "Hij achtervolgt je. Tot je besluit bij een groepje betrouwbaar uitziende mensen te gaan staan en doet alsof het je vrienden zijn. Als de man weg is leg je uit wat er gebeurd is en de mensen vragen of alles ok is met je en ze gaan nog eindje met je mee.";
                    moodValue = -10;
                }
                else
                {
                    narrativeText = "De man blijft staan en even later ben je uit het zicht en je haalt opgelucht adem.";
                    moodValue = -10;
                }
                endOfEvent = true;
                break;

            case 23:
                rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "De man lijkt het te begrijpen laat je met rust.";
                    //geen effect
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De man komt heel dicht om nog een vraag te stellen en je duwt hem weg. Iemand anders ziet dit en vraagt wat er aan de hand is. \"Niets\" zegt de man snel en hij gaat weg.";
                    chain = 40;
                    numberOfOptions = 2;
                    option01Text = "Je verteld de persoon wat er gebeurd is en samengaan jullie naar de politie om je verhaal te vertellen.";
                    option01Text = "Je bedankt de persoon en wandelt weg.";
                }
                break;

            case 24:
                rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "De man probeert nog 1 vraag te stellen, maar daarna geeft hij op.";
                    //geen effect
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De man blijft toch proberen maar je negeert hem tot je aankomt waar je moet zijn.";
                    chain = 22;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                break;

            case 25:
                narrativeText = "Je gaat toch in op zijn vragen.";
                chain = 18;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 26:              
                int rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "De man stopt plots met vragen stellen en gaat weg. \"Waarom wou hij dat allemaal weten?\" vraag je jezelf af.";
                    moodValue = -10;
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De man raakt je been aan. Je duwt zijn hand weg en de man gaat snel weg";
                    chain = 27;
                    numberOfOptions = 1;
                    option01Text = "...";
                    
                }
                break;

            case 27:
                int rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "De man gaat weg.";
                    moodValue = -10;
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De man raakt je been aan. Je duwt zijn hand weg en de man gaat snel weg";
                    chain = 27;
                    numberOfOptions = 1;
                    option01Text = "...";

                }
                break;

            case 28:
                chain = 30;
                numberOfOptions = 2;
                option01Text = "Je laat het incident voor wat het is.";
                option02Text = "Je gaat met je verhaal naar de politie.";
                break;


            case 31:
                narrativeText = "Je kan het incident maar niet uit je hoofd zetten. Je twijfeld aan jezelf \"is dit nu mijn fout?\"";
                //geen effect
                endOfEvent = true;
                break;
            case 41:
                narrativeText = "\nJe geeft een beschrijving van de man en volgens de politie heeft deze man het zelfde ook al gedaan bij andere mensen. Ze gaan hem opzoeken en houden je gegevens bij.";
                moodValue = -10;
                endOfEvent = true;
                break;

            case 42:
                narrativeText = "Je blijft de hele dag denken aan wat de man deed, ook al doe je zo je best het te vergeten.";
                moodValue = -15;
                endOfEvent = true;
                break;


//heavy**************************************************//


            case 50:
                narrativeText = "De vrouw is verrassend sterk, maar je blijft proberen.";
                chain = 53;
                numberOfOptions = 1;
                option01Text = "...";
                
                break;

            case 51:
                narrativeText = "De vrouw schreeuwt wanneer je in haar hand bijt en ze laat haar hand zakken.";
                chain = 54;
                numberOfOptions = 2;
                option01Text = "Je schreeuwt om hulp!";
                option02Text = "Je maakt van haar pijn gebruikt om jezelf los te wrikken."; //gaat naar case 50.
                break;

            case 52:
                narrativeText = "Je doet je ogen toe en probeert aan leuke dingen te denken. Na een tijd voel je jezelf in elkaar zakken en doet je ogen open. De vrouw verdwijnt in de donkere steeg.";
                numberOfOptions = 3;
                chain = 56;
                option01Text = "Je gaat terug naar huis.";
                option02Text = "Je gaat naar de politie om je verhaal te doen.";
                option03Text = "Je gaat gewoon doen wat je ging doen. Je hebt geen idee hoelaat het ondertussen is maar als je aan komt vraagt iedereen waar je was.";
                break;

            case 53:
                narrativeText = "Je slaagt erin los te komen en loopt snel weg. Je kan alleen maar hopen dat je de vrouw nooit meer tegenkomt.";
                moodValue = -20;
                endOfEvent = true;
                break;

            case 54:
                int rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "Je slaagt erin los te komen en loopt snel weg.";
                    moodValue = -5;
                    endOfEvent = true;
                }
                else
                {   //hier kan een zwart scherm komen als je op de knop duwt voor een seconde of 2. Daarna ben je in theorie in je kamer.
                    narrativeText = "Je slaagt er maar niet in jezelf los te krijgen uit de armen van de vrouw. \"Wauw jij kan hard spartelen!\" lacht ze, waarna ze je op je mond kust en haar hand in je broek verdwijnt.";
                    moodValue = -15;
                    endOfEvent = true;
                }      
                break;

            case 55:
                narrativeText = "Je schreeuwt om hulp. Enkele toevallige voorbijgangers komen kijken wat er aan de hand is en de vrouw laat je los voor ze haar kunnen zien. ";
                chain = 63;
                numberOfOptions = 2;
                option01Text = "Je verteld de voorbijgangers wat er gebeurt is.";
                option02Text = "Je zegt tegen de voorbijgangers dat er een rat voorbij liep en dat je gewoon schrok.";
                break;

            case 56:
                narrativeText = "Je maakt van haar pijn gebruikt om jezelf los te wrikken. En loopt snel weg. De vrouw zie je gelukkig niet meer terug.";
                moodValue = -20;
                endOfEvent = true;
                break;

            case 57:
                narrativeText = "\"Naar huis gaan heeft nog nooit zo lang geduurd\" denk je in jezelf.";
                moodValue = -20;
                endOfEvent = true;
                break;

            case 58:
                narrativeText = "Na een onderzoek vinden ze de vrouw en wordt ze veroordeeld voor aanranding van een minderjarige.\nAls je zelf zo iets meemaakt kan je altijd terecht op deze website www.awel.be of bellen naar het nummer 102";
                moodValue = -20;
                endOfEvent = true;
                break;

            case 59:
                narrativeText = "Je gaat gewoon doen wat je ging doen. Je hebt geen idee hoelaat het ondertussen is maar als je aan komt vraagt iedereen waar je was.";
                chain = 59;
                numberOfOptions = 2;
                option01Text = "Je vertelt wat er gebeurd is en iemand gaat met je naar de politie.";
                option02Text = "Je vertelt hen dat er een ongeluk gebeurd was en dat je er niets met je is.";
                break;

            case 60:
                narrativeText = "Na een onderzoek vinden ze de vrouw en wordt ze veroordeeld voor aanranding van een minderjarige.\nAls je zelf zo iets meemaakt kan je altijd terecht op deze website www.awel.be of bellen naar het nummer 102";
                moodValue = -20;
                endOfEvent = true;
                break;

            case 61:
                narrativeText = "Je durft niemand te vertellen wat er gebeurd is. Maar misschien zou je dat best wel doen.";
                moodValue = -20;
                endOfEvent = true;
                break;
            case 64:
                narrativeText = "De voorbijgangers bellen de politie die meteen komt.\nNa een onderzoek vinden ze de vrouw en wordt ze veroordeeld voor aanranding van een minderjarige.\nAls je zelf zo iets meemaakt kan je altijd terecht op deze website www.awel.be of bellen naar het nummer 102";
                moodValue = -15;
                endOfEvent = true;
                break;

            case 65:
                narrativeText = "Je durft niemand te vertellen wat er gebeurd is. Maar misschien zou je dat best wel doen.";
                moodValue = -20;
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                endOfEvent = true;
                break;
        }
    }

}
