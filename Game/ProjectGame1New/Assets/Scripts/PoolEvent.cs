using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoolEvent : ChoiceScript {

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;

        int rnd = Random.Range(1, 3);
        Consequences(rnd);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();

        StaticInfo.NextScene = "Home_After";

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
                narrativeText = "Terwijl je je aan het omkleden bent zie je plots iets vreemd. Er is precies een gaatje in de muur van je kleedcabine. Snel sla je je handdoek om je heen.";
                chain = 10;
                numberOfOptions = 2;
                option01Text = "Je probeert zelf door het gaatje te kijken.";
                option02Text = "Je zet je rugzak voor het gaatje zodat er niemand meer kan doorkijken.";
                break;

            case 2:
                narrativeText = "Uitgeput maar tevreden komen jullie het zwembad buiten. Je kijkt op je gsm, \"tijd om naar huis te gaan,\" denk je in jezelf.";
                chain = 2;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 3:
                narrativeText = "\"Ik moet nu wel vertrekken, wij hebben bezoek,\" zegt iemand. Ook de andere gaan naar huis. Jullie nemen afscheid en iedereen gaat naar huis.";
                endOfEvent = true;
                break;

            case 11:
                rnd = Random.Range(1, 4);
                redBox = true;
                ScoreCounter(1);
                if (rnd == 1)
                {
                    narrativeText = "Je ziet niets aan de andere kant. Je zet je rugzak dan maar voor het gaatje zodat er zeker niemand kan doorkijken.";
                    chain = 11;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                if (rnd == 2)
                {
                    narrativeText = "Aan de andere kant zie je zelf een oog. De andere persoon schrikt en gaat snel weg.";
                    chain = 14;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                else
                {
                    narrativeText = "Er zit iemand in het hokje naast je!";
                    chain = 15;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                break;

            case 12:
                narrativeText = "Als je klaar bent pak je je rugzak op en zie je het gaatje weer.";
                chain = 12;
                numberOfOptions = 2;
                option01Text = "Je gaat naar de kassa om te vertellen dat er een gaatje is tussen 2 kleedhokjes.";
                option02Text = "Na het omkleden ga je meteen verder zonder te zeggen dat je dat gaatje vond.";
                break;

            case 13:
                narrativeText = "De man achter de kassa bedankt je. Hij licht meteen de politie in en ze maken het gaatje toe en controleren of er meer zijn.";
                greenBox = true;
                ScoreCounter(3);
                chain = 24;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 14:
                narrativeText = "Als je nu zou vertellen dat het gaatje er is kan je misschien voorkomen dat er nog iemand mensen bespied?";
                redBox = true;
                chain = 20;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 15:
                narrativeText = "Omdat je zelf nog niet half aan gekleed bent kan je niet kijken wie het is.";
                chain = 20;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 16:
                narrativeText = "Het is een oudere man die zich aankleedt. Zich totaal niet bewust van het gaatje.";
                chain = 29;
                numberOfOptions = 2;
                option01Text = "Je stopt meteen met kijken.";
                option02Text = "Je blijft even kijken.";
                break;

            case 21:
                narrativeText = "Je verteld je vrienden over het gaatje en ze vragen meteen of je de medewerkers heb laten weten dat het er is zodat er niemand anders nog last van zal hebben.";
                chain = 21;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 22:
                narrativeText = "Je ziet in dat je dat had moeten doen en draait snel terug om het te gaan zeggen. Als je terug komt zijn al een paar van je vrienden vertrokken, je neemt afscheid van de andere en vertrekt naar huis";
                redBox = true;
                endOfEvent = true;
                break;

            case 25:
                narrativeText = "Je verteld je vrienden over het gaatje en ze vragen meteen of je de medewerkers heb laten weten dat het er is zodat er niemand anders nog last van zal hebben.";
                chain = 25;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 26:
                narrativeText = "\"Natuurlijk,\" zeg je. Ik zou het zelf niet graag hebben. Dus ben ik het snel gaan zeggen. Je neemt afscheid van je vrienden en gaat naar huis.";
                greenBox = true;
                ScoreCounter(3);
                endOfEvent = true;
                break;

            case 30:
                narrativeText = "Wanneer je je omgekleed hebt ga je naar de kassa om te vertellen dat er een gaatje is tussen 2 kleedhokjes. De man achter de kassa bedankt je.";
                greenBox = true;
                ScoreCounter(3);
                chain = 24;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 31:
                narrativeText = "Plots ziet de man je kijken, hij haalt er de man achter de kassa erbij.";
                redBox = true;
                ScoreCounter(1);
                chain = 31;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 32:
                narrativeText = "Je vertelt hen dat je het gaatje net had opgemerkt en je gewoon even wou kijken wat er aan de andere kant was.";
                chain = 32;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 33:
                narrativeText = "Gelukkig geloven ze je omdat je regelmatig komt zwemmen en dat niet eerder gebeurt is. \"Maar als het nog eens gebeurt bel ik de politie,\" zegt de man van de kassa.";
                chain = 33;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 34:
                narrativeText = "Wanneer je even later buitenkomt vragen je vrienden wat er was. Je  verteld wat er gebeurt is. Na je verhaal is het tijd om naar huis te gaan. Jullie nemen afscheid en ieder gaat zijn eigen weg.";
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
