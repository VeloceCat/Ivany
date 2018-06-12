using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomEvent : ChoiceScript {

    [SerializeField]
    protected Image woman;
    [SerializeField]
    protected Image femShad;
    [SerializeField]
    protected Image maleShad;


    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;

        woman.enabled = false;
        femShad.enabled = false;
        maleShad.enabled = false;

        // In geval event begint met random
        int rnd = Random.Range(1, 3);
        Consequences(rnd);
    }

    public override void AfterDialogue()
    {
        //SceneManager.LoadScene(StaticInfo.NextScene);
        SceneManager.LoadScene("School");
    }

    public override void StartTalking(int num)
    {
        int rnd;  // niet opnieuw aanmaken
        switch (num)
        {
            // bij alle cases narrativeText meegeven en numberOfChoices, voor exit bool endOfEvent op true zetten

            //Event begint nu met random getal van 1 tem 6, voor ander getal aanpassen in StartDialogue bovenaan dit script (vanuit 1 basistekst vertrekken, verander Consequences(rnd) naar Consequences(1)

            case 1:
                chain = 8;
                narrativeText = "Op de tram merk je dat een vrouw de hele tijd in jou richting zit te kijken. \"Zit ze naar mij te staren?\" vraag je jezelf af.";
                numberOfOptions = 4;
                option01Text = "Je krijg een ongemakkelijk gevoel en besluit een halte vroeger af te stappen.";
                option02Text = "Je verplaatst je uit het zicht van de vrouw en stapt af aan je normale halte.";
                option03Text = "Je probeert de vrouw te negeren en je stapt aan je normale halte af.";
                option04Text = "Je vraagt vriendelijk aan de vrouw waarom ze naar je zit te kijken.";
                break;

            case 2:
                chain = 16;
                narrativeText = "Onderweg spreekt een man je aan, hij ziet er normaal uit maar kijkt je wat raar aan.";
                FadesIn(maleShad);
                numberOfOptions = 3;
                option01Text = "Je probeert beleefd duidelijk te maken dat je geen zin hebt om te praten.";
                option02Text = "Je negeert hem, hopelijk snapt hij dat je geen zin hebt in een gesprek.";
                option03Text = "Je praat met hem ook al ken je hem helemaal niet.";
                break;


            //light**************************************************//


            case 9:
                narrativeText = "Door de wandeling ben je een beetje later. “Waar bleef je?” vraagt iemand?";
                chain = 12;
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
                narrativeText = "Ze kijkt je geschrokken aan en zegt dat ze helemaal niet naar jou aan het kijken was. \nMisschien had je niet zo moeten reageren?";
                FadesIn(woman);
                ScoreCounter(2);
                endOfEvent = true;
                break;

            case 13:
                narrativeText = "Je vrienden vertellen je dat je wellicht aan het dromen was.";
                chain = 15;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 14:
                narrativeText = "Je dag gaat verder zoals gepland. Maar je blijft wel moet de vrouw in je hoofd zitten. Misschien had je het toch moeten zeggen?";
                redBox = true;
                ScoreCounter(1);
                endOfEvent = true;
                break;

            case 15:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "De vrouw zie je niet meer terug en je vergeet het voorval al snel.";
                }
                else
                {
                    narrativeText = "De vrouw stapt ook uit en achtervolgt je. Wanneer je op je bestemming aankomt en achterom kijkt is ze verdwenen. Je bent de hele dag bang dat je de vrouw weer zal tegenkomen.";
                    FadesIn(femShad);
                }
                endOfEvent = true;
                break;

            case 16:
                narrativeText = "Door het te zeggen heb je de juiste keuze gemaakt. Iemand die zijn verhaal doet afwimpelen, zoals je vrienden deden, is geen goede zaak. Er zijn altijd andere mensen, noodnummers en forums waar je terecht kan met je problemen.";
                //greenBox = true;
                ScoreCounter(3);
                endOfEvent = true;
                break;

            //medium**************************************************//


            case 17:
                narrativeText = "Hij stelt rare vragen, hij is duidelijk niet gewoon op zoek naar iemand om zomaar een praatje mee te doen.";
                ScoreCounter(3);
                chain = 20;
                numberOfOptions = 1;
                option01Text = "...";
                break;


            case 18:
                chain = 22;
                
                ScoreCounter(2);
                narrativeText = "Hij blijft nog even doorvragen.";
                numberOfOptions = 2;
                option01Text = "Je blijft hem negeren.";
                option02Text = "Je zegt hem dat je niet wilt praten.";
                break;

            case 19:
                narrativeText = "Na een tijdje begint hij hele specifieke en rare vragen te stellen. Hij vraagt of je een ‘liefje’ hebt en waar je naartoe gaat.\nMisschien zou je toch wat moeten oppassen met zomaar praten?";
                
                ScoreCounter(1);
                chain = 25;
                numberOfOptions = 2;
                option01Text = "Je antwoordt op al zijn vragen ook al hij heeft daar eigenlijk niets mee te maken.";
                option02Text = "Je zegt “sorry maar dat zijn jouw zaken niet” en negeert hem";
                break;

            case 21:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "Hij merkt door je korte antwoorden dat je niet van plan bent om te veel te zeggen en hij gaat weg. “Wat een rare man” denk je in jezelf.";
                    endOfEvent = true;
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
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "Hij achtervolgt je. Tot je besluit bij een groepje betrouwbaar uitziende mensen te gaan staan en doet alsof het je vrienden zijn. Als de man weg is leg je uit wat er gebeurd is en de mensen vragen of alles ok is met je en ze gaan nog eindje met je mee.";
                }
                else
                {
                    narrativeText = "De man blijft staan en even later is hij uit je zicht verdwenen. Je haalt opgelucht adem.";
                }
                endOfEvent = true;
                break;

            case 23:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "De man lijkt het te begrijpen laat je met rust.";
                    greenBox = true;
                    ScoreCounter(3);
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De man komt heel dicht om nog een vraag te stellen en je duwt hem weg. Iemand anders ziet dit en vraagt wat er aan de hand is. “Niets” zegt de man snel en hij gaat weg.";
                    chain = 40;
                    numberOfOptions = 2;
                    option01Text = "Je vertelt de persoon wat er gebeurd is en jullie gaan samen naar de politie om je verhaal te vertellen.";
                    option01Text = "Je bedankt de persoon en wandelt weg.";
                }
                break;

            case 24:
                greenBox = true;
                ScoreCounter(3);
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "De man probeert nog 1 vraag te stellen, maar daarna geeft hij op.";
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
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "De man stopt plots met vragen stellen en gaat weg. “Waarom wou hij dat allemaal weten?” vraag je jezelf af.";
                    
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De man raakt je been aan. Je duwt zijn hand weg en de man gaat snel weg";
                    chain = 27;
                    numberOfOptions = 1;
                    option01Text = "...";

                }
                ScoreCounter(1);
                break;

            case 27:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "De man gaat weg.";
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De man raakt je been aan. Je duwt zijn hand weg en de man gaat snel weg";
                    chain = 27;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                FadesOut(maleShad);
                break;

            case 28:
                chain = 30;
                numberOfOptions = 2;
                option01Text = "Je laat het incident voor wat het is.";
                option02Text = "Je gaat met je verhaal naar de politie.";
                break;


            case 31:
                narrativeText = "Je kan het incident maar niet uit je hoofd zetten. Je twijfelt aan jezelf \"is dit nu mijn fout?\"";
                redBox = true;
                ScoreCounter(1);
                endOfEvent = true;
                break;

            case 41:
                narrativeText = "\n Je geeft een beschrijving van de man en volgens de politie heeft deze man het zelfde ook al gedaan bij andere mensen. Ze gaan hem opzoeken en houden je gegevens bij.";
                greenBox = true;
                ScoreCounter(3);
                endOfEvent = true;
                break;

            case 42:
                narrativeText = "Je blijft de hele dag denken aan wat de man deed, ook al doe je zo je best het te vergeten.";
                redBox = true;
                ScoreCounter(1);
                chain = 42;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 43:
                narrativeText = "Als iemand gezien heeft wat er gebeurt is is het een goed idee om met die mensen naar de politie te gaan.\nDeze mensen zijn getuige en je staat er dus zeker niet meer alleen voor.";
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                break;
        }
    }

}
