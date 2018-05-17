using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeEvent : ChoiceScript {

    public override void RandomDialogue()
    {
        choiceMade = 0;
        chain = 0;
        int rnd = Random.Range(1, 6);
        Consequences(rnd);
    }

    public override void AfterDialogue()
    {
        textBox.SetActive(false);
        choice01.SetActive(false);
        choice02.SetActive(false);
        choice03.SetActive(false);
        choice04.SetActive(false);
        StaticInfo.MenuInteractable = true;
    }

    public override void StartTalking(int num)
    {
        int rnd;
        bool CameraIsPointedAtYou = true;
        switch (num)
        {
            //Deze zin zou elke keer in het begin moeten komen, ik heb geprobeerd om het hier met een random te maken. Mss had gij daar al iets voor?
            case 1:
                narrativeText = "Wanneer je langs de lingerie afdeling wandelt zie je daar een man die wat staat rond te kijken. Tot een van de winkel medewerksters van de paskamers wat ondergoed terughangt en de man er meteen naartoe wandelt. \"Ruikt hij nu aan net gepast ondergoed?\" denk je in jezelf.";
                rnd = Random.Range(1, 2);
                if (rnd == 1)
                {
                    narrativeText = "\"Wat zijn er toch rare mensen.\" Lach je in jezelf. Je wandelt maar snel verder om het niet langer te hoeven zien.";
                    //geen effect

                }
                else
                {
                    narrativeText = "Je ziet de medewerkster snel terugkomen met iemand van de beveiliging.  Ze zetten de man uit de winkel. \"Zijn verdiende loon, zoiets doe je niet.\" Zeg je in jezelf.";
                    //geen effect
                }
                endOfEvent = true;
                break;

            case 2:
                narrativeText = "Je komt uit je pashokje om in een grotere spiegel te kijken om je kleren passen.";
                chain = 3;
                numberOfOptions = 1;
                option01Text = "...";

            case 3:
                narrativeText = "Terwijl je aan het passen bent zie je plots een smartphone uitsteken boven je hoofd. Met de camera naar jou vanuit het pashokje naast je.";
                chain = 9;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 4:
                rnd = Random.Range(1, 2);
                if (rnd == 1)
                {
                    narrativeText = "\"Past perfect\" zegt de medewerker die wat kleren opplooit.";
                    chain = 4;
                }
                else
                {
                    narrativeText = "In de spiegel zie je een vrouw naar je kijken.";
                    chain = 6;
                }
                break;

            case 5:
                narrativeText = "Als je even later met een andere T-shirt je pashokje buiten komt ziet hij dat je niet echt tevreden bent en helpt je met iets anders zoeken.";
                chain = 5;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 6:
                narrativeText = "\"Dank je,\" zeg je als je met je gekozen kleren naar de kassa vertrekt. \"Geen probleem.\" Antwoord hij blij terug. ";
                moodValue = 5;
                endOfEvent = true;
                break;

            case 7:
                rnd = Random.Range(1, 2);
                if (rnd == 1)
                {
                    narrativeText = "Wanneer je even later met een andere outfit buitenkomt zit de vrouw er nog en staart ze je ook weer aan. Ze is duidelijk naar jou aan het kijken.";
                    chain = 7;
                    numberOfOptions = 2;
                    option01Text = "\"Ik vind het maar niks dat ze me zo aanstaart.\"";
                    option02Text = "\"Pfft, ik ga me niet laten afleiden door die vrouw.\"";
                }
                else
                {
                    narrativeText = "Wanneer je even later met een andere outfit buitenkomt is de vrouw weg. Ze zal toevallig naar jou gekeken hebben.";
                    //geen effect
                    endOfEvent = true;
                }
                break;

            case 8:
                narrativeText = "Je zult het moeten doen met de spiegel in het pashokje. Die is niet zo groot maar het gaat ook.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 9:
                narrativeText = "Je blijft de grote spiegel gebruiken en je let niet op de vrouw.";
                //geen effect
                endOfEvent = true;
                break;

            case 10:
                int rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "De camera blijft op je gericht.";
                    chain = 10;
                    numberOfOptions = 3;
                    option01Text = "Je probeert met je hand de camera weg te duwen.";
                    option02Text = "Je schreeuwt dat er iemand je aan het filmen is.";
                    option03Text = "Je stapt snel uit je pashokje.";
                }
                else
                {
                    narrativeText = "Je schrikt en kijk recht naar de camera.";
                    chain = 10;
                    CameraIsPointedAtYou = false;
                    numberOfOptions = 3;
                    option01Text = "...";
                    option02Text = "Je schreeuwt dat er iemand je aan het filmen is.";
                    option03Text = "Je stapt snel uit je pashokje.";
                }
                break;

            

            case 11:
                rnd = Random.Range(1, 2);
                if (rnd == 1 && CameraIsPointedAtYou == false)
                {
                    narrativeText = "De smartphone wordt snel weggetrokken en je hoort mensen snel de winkel uitlopen.";
                    chain = 14;
                    numberOfOptions = 1;
                    option01Text = "...";
                    
                }
                else
                {
                    narrativeText = "Je hoort iemand vallen in het andere hokje.";
                    chain = 11;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                break;


            case 12:
                narrativeText = "De medewerksters komt kijken wat er aan de hand is. Je zegt dat iemand je aan het filmen was. Ze haalt de security erbij, het zijn 2 jongens. Ze worden naar de politie gebracht en ze worden gestraft.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 13:
                narrativeText = "Je staat voor het andere pashokje als de deur opengaat. De 2 jongens die je aan het filmen waren duwen je opzij en proberen snel weg te lopen.";
                chain = 13;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 14:
                narrativeText = "1 wordt meteen tegengehouden door medewerksters, ze halen de security erbij en de jongen wordt naar de politie gebracht. Even later krijg je te horen dat ze ook de andere jongen te pakken hebben en dat ze gestraft zullen worden.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 15:
                int rnd = Random.Range(1, 2);
                if (rnd = 1)
                {
                    narrativeText = "De camera blijft op je gericht.";
                    chain = 10;
                    numberOfOptions = 3;
                    option01Text = "Je probeert met je hand de camera weg te duwen.";
                    option02Text = "Je schreeuwt dat er iemand je aan het filmen is.";
                    option03Text = "Je stapt snel uit je pashokje.";
                }
                else
                {
                    narrativeText = "Je schrikt en kijk recht naar de camera.";
                    chain = 15;
                    numberOfOptions = 2;
                    option01Text = "\"Ja\" zeg je droog terug.";
                    option02Text = "\"Ja hoor, gewoon niets speciaals gebeurd vandaag.\"";   
                }
                break;

            default:
                narrativeText = "Error";
                endOfEvent = true;
                break;
        }
    }
    }
