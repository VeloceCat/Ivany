using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShoppingEvent : ChoiceScript {

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;

        int rnd = Random.Range(1, 4);
        Consequences(rnd);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();

        StaticInfo.NextScene = "Home";

        if (StaticInfo.RandomEventNbr == 3)
        {
            SceneManager.LoadScene("RandomEventScene");
        }
        else
        {
            SceneManager.LoadScene(StaticInfo.NextScene);
        }

    }


    public override void StartTalking(int num)
    {
        int rnd;
        switch (num)
        {
            case 1:
                narrativeText = "\"Ik denk dat we elke winkel binnenstebuiten hebben gekeerd!\" lacht een van je vrienden als jullie de laatste winkel buitengaan.";
                chain = 29;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 2:
                narrativeText = "Je komt uit je pashokje om in een grotere spiegel te kijken om je kleren passen.";
                chain = 3;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 3:
                narrativeText = "Terwijl je aan het passen bent zie je plots een smartphone uitsteken boven je hoofd. Met de camera naar jou vanuit het pashokje naast je.";
                chain = 19;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 4:
                rnd = Random.Range(1, 3);
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
                chain = 0;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 7:
                rnd = Random.Range(1, 3);
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
                    endOfEvent = true;
                }
                break;

            case 8:
                narrativeText = "Je zult het moeten doen met de spiegel in het pashokje. Die is niet zo groot maar het gaat ook.";
                greenBox = true;
                chain = 0;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 9:
                narrativeText = "Je blijft de grote spiegel gebruiken en je let niet op de vrouw.";
                greenBox = true;
                chain = 0;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 10:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "De camera blijft op je gericht.";
                    chain = 10;
                    numberOfOptions = 3;
                    option01Text = "Je schreeuwt dat er iemand je aan het filmen is.";
                    option02Text = "Je stapt snel uit je pashokje. Om de dader zelf te pakken.";
                    option03Text = "Je probeert met je hand de camera weg te duwen.";
                }
                else
                {
                    narrativeText = "De smartphone wordt snel weggetrokken.";
                    chain = 10;
                    numberOfOptions = 2;
                    option01Text = "Je schreeuwt dat er iemand je aan het filmen is.";
                    option02Text = "Je stapt snel uit je pashokje. Om de dader zelf te pakken.";
                }
                break;

            case 11:
                narrativeText = "Een van je vrienden haalt er een winkelmedewerker bij. Zij haalt de politie erbij. De jongens worden gestraft.";
                greenBox = true;
                endOfEvent = true;
                break;

            case 13:
                narrativeText = "De smartphone wordt snel weggetrokken en je hoort mensen snel de winkel uitlopen.";
                chain = 15;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 12:
                narrativeText = "Je staat voor het andere pashokje als de deur opengaat. De 2 jongens die je aan het filmen waren duwen je opzij en proberen snel weg te lopen.";
                chain = 13;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 14:
                narrativeText = "Je loopt er zelf snel achteraan en even later heb je er een te pakken en iemand van de security heeft de andere te pakken.";
                redBox = true;
                chain = 14;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 15:
                narrativeText = "Hij bedankt je, maar zegt ook dat wat je deed geen goed idee is. Als de jongen gevallen was had hij jou ook kunnen aanklagen.";
                redBox = true;
                endOfEvent = true;
                break;

            case 16:
                narrativeText = "Dit is verdacht voor de security die de jongens tegenhouden. De security brengt de jongens terug naar de paskamers.";
                chain = 16;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 17:
                narrativeText = "Je zegt dat ze je aan het filmen waren. De 2 jongens worden naar de politie gebracht en worden gestraft.";
                greenBox = true;
                endOfEvent = true;
                break;

            case 20:
                narrativeText = "De camera blijft op je gericht.";
                chain = 9; //extra stap daarom van 20 naar 10
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 30:
                narrativeText = "\"Ja, sommige zelfs 2 keer\" antwoord je, \"Dat was weeral een leuke dag.\" Jullie nemen afscheid  en iedereen gaat zijn eigen weg naar huis.";
                greenBox = true;
                endOfEvent = true;
                break;

            case 31:
                narrativeText = "\"Wat een dag,\" denk je bij jezelf, \"tijd om naar huis te gaan zeg je tegen je vrienden.\" Ze vragen of er iemand met je moet meegaan naar huis.";
                chain = 31;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 32:
                narrativeText = "\"Dankje, maar zover woon ik nu niet dus ik kan het wel alleen,\" zeg je met een lachje. Je bent heel blij dat je vrienden zo om je geven.";
                greenBox = true;
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                endOfEvent = true;
                break;
        }
    }
}
