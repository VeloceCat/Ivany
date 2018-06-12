using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class School_Classroom : ChoiceScript {

    [SerializeField]
    protected Image maleShadow;
    [SerializeField]
    protected Image femaleShadow;
    [SerializeField]
    protected Image maleFriend;
    [SerializeField]
    protected Image femaleFriend;
    [SerializeField]
    protected Image principal;

    protected bool isBoy;

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;

        maleShadow.enabled = false;
        femaleShadow.enabled = false;
        maleFriend.enabled = false;
        femaleFriend.enabled = false;
        principal.enabled = false;

        if (Random.Range(1,3) == 1)
        {
            isBoy = true;
        }
        else
        {
            isBoy = false;
        }

        int rnd = Random.Range(1, 4);
        Consequences(rnd);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();
        StaticInfo.AfterClass = true;

        SceneManager.LoadScene("School_After");
    }

    public void FadeBoyOrGirl(bool isfadeIn)
    {
        if (isfadeIn)
        {
            if (isBoy)
            {
                FadesIn(maleFriend);
            }
            else
            {
                FadesIn(femaleFriend);
            }
        }
        else
        {
            if (isBoy)
            {
                FadesOut(maleFriend);
            }
            else
            {
                FadesOut(femaleFriend);
            }
        }

    }

    public void FadeBoyOrGirlShadow(bool isfadeIn)
    {
        if (isfadeIn)
        {
            if (isBoy)
            {
                FadesIn(maleShadow);
            }
            else
            {
                FadesIn(femaleShadow);
            }
        }
        else
        {
            if (isBoy)
            {
                FadesOut(maleShadow);
            }
            else
            {
                FadesOut(femaleShadow);
            }
        }

    }

    public override void StartTalking(int num)
    {
        int rnd;
        switch (num)
        {
            case 1:
                narrativeText = "Tijdens de pauze komt er iemand naar je toe en vraagt of jij een naaktfoto hebt van je vorige liefje. En of hij die mag hebben.";
                chain = 39;
                FadesIn(maleShadow);
                numberOfOptions = 3;
                option01Text = "\"Natuurlijk,\" zeg je \"ideaal als wraak.\"";
                option02Text = "\"Waarom?\" wil je weten.";
                option03Text = "\"Nee zo iets doe ik niet.\" En je wandelt weg.";
                break;

            case 2:
                narrativeText = "In de gang komt er iemand naar je toe en lijkt je te willen versieren. Al snel merk je dat het enkel is om met je te lachen. ";
                FadeBoyOrGirlShadow(true);
                chain = 9;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 3:
                narrativeText = "Je ziet plots dat er een papiertje in je rugzak zit. Je pakt het op en vouwt het open.";
                chain = 19;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 10:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "Je vrienden zien al snel wat er gebeurt en trekken je al snel mee.";
                    FadeBoyOrGirlShadow(false);
                    chain = 10;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                else
                {
                    narrativeText = "Omdat je een beetje later was, zijn jullie bijna alleen in de gang. ";
                    chain = 11;
                    numberOfOptions = 2;
                    option01Text = "Je probeert het gewoon te negeren en wandelt verder tot aan je lokaal. ";
                    option02Text = "Je reageert op de vervelende achtervolger.";
                }
                break;

            case 11:
                narrativeText = "\"Zo zijn we er sneller vanaf\" zeggen ze tegen je. \"Dank je,\" zeg je met een knipoog.";
                endOfEvent = true;
                break;

            case 12:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "Al snel hoor je dat de persoon opgeeft. \"Als je wordt genegeerd, is de pret er snel af hé.\" Lach je in jezelf.";
                    greenBox = true;
                    FadeBoyOrGirlShadow(false);
                    ScoreCounter(3);
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De persoon blijft je achtervolgen tot aan je lokaal. Wanneer je de deur opendoet, staat je leerkracht bij de deur.";
                    chain = 14;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                break;

            case 13:
                narrativeText = "Maar dat is juist wat je achtervolger wou. Je reageert nog eens, zonder resultaat.";
                redBox = true;
                ScoreCounter(1);
                chain = 13;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 14:
                narrativeText = "Je beslist om je achtervolger dan maar gewoon te negeren. Geen reactie, geen plezier blijkbaar want je achtervolger geeft al snel op.";
                //greenBox = true;
                FadeBoyOrGirlShadow(false);
                endOfEvent = true;
                break;

            case 15:
                narrativeText = "Ze ziet wat er aan de hand is en stuurt je belager snel weg. \"Alles ok?\" vraagt ze, \"ja hoor\" antwoord je en je gaat op je plaats zitten.";
                FadeBoyOrGirlShadow(false);
                endOfEvent = true;
                break;

            //***********************************************************

            case 20:
                narrativeText = "Het is een foto van je terwijl je naar het toilet gaat op school!";
                chain = 22;
                numberOfOptions = 2;
                option01Text = "Omdat je zelf op de foto staat, durf je het tegen niemand te zeggen.";
                option02Text = "Je probeert iemand te vinden die je kan vertrouwen om erover te praten.";
                break;

            case 23:
                narrativeText = "Wie heeft die foto genomen? Wie heeft de foto al gezien? Zoveel vragen zonder antwoord. Elke dag dat je naar school gaat ga je er mee zitten.";
                redBox = true;
                ScoreCounter(1);
                endOfEvent = true;
                break;

            case 24:
                narrativeText = "Misschien een leerkracht? Een van je beste vrienden? Of misschien moet je het eerst aan je ouders vertellen?";
                chain = 24;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 25:
                narrativeText = "Je verteld het tussen 2 lessen aan je beste vriend.";
                chain = 25;
                FadeBoyOrGirl(true);
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 26:
                narrativeText = "Die zegt dat je het best ook tegen de directeur kan zeggen, zij kan misschien de schuldige vinden.";
                greenBox = true;
                ScoreCounter(3);
                chain = 29;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 30:
                narrativeText = "Je gaat snel naar de directeur om te laten zien wat je gevonden hebt.";
                chain = 30;
                FadeBoyOrGirl(false);
                FadesIn(principal);
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 31:
                narrativeText = "Het is een beetje raar om de foto te laten zien, maar misschien help je anderen die het niet durven zeggen.";
                chain = 31;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 32:
                narrativeText = "De directeur belooft te onderzoeken wie dit gedaan heeft en hen te straffen.";
                greenBox = true;
                ScoreCounter(3);
                endOfEvent = true;
                break;

            /********************************************************************/
            case 40:
                narrativeText = "Je stuurt hem de foto door.";
                ScoreCounter(1);
                chain = 42;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 41:
                narrativeText = "Hij vertelt dat ze hem gewoon wat willen plagen.";
                chain = 43;
                numberOfOptions = 2;
                option01Text = "\"Dan is het goed,\" antwoord je.";
                option02Text = "Je hebt er een slecht gevoel bij en geeft hem de foto niet.";
                break;

            case 42:
                narrativeText = "\"Nee, zo iets doe ik niet.\" En je wandelt weg.";
                ScoreCounter(3);
                chain = 45;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 43:
                narrativeText = "Door de foto wordt je vorig liefje zo hard gepest dat hij van school veranderd. En dat is voor een groot deel jouw fout.";
                endOfEvent = true;
                break;

            case 44:
                narrativeText = "Je stuurt hem de foto door.";
                ScoreCounter(1);
                chain = 42;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 45:
                narrativeText = "Hij dringt nog even aan en dan gaat hij weg.";
                ScoreCounter(3);
                chain = 45;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 46:
                narrativeText = "Dat hij zo iets durft vragen, denk je. Misschien zou je moeten vertellen dat hij dat aan jou gevraagd heeft?";
                chain = 46;
                numberOfOptions = 2;
                option01Text = "Je gaat naar een leerkracht om het te vertellen.";
                option02Text = "\"Pffffft, het tegen iemand zeggen heeft toch geen zin.\"";
                break;

            case 47:
                narrativeText = "Later gaan ze hem aan de tand voelen en zijn ouders inlichten. Wat hij vroeg, kan gewoon niet.";
                ScoreCounter(3);
                endOfEvent = true;
                break;

            case 48:
                narrativeText = "Hij heeft blijkbaar van iemand anders wel de foto gekregen. Je vorig liefje wordt daarmee zo hard gepest dat hij van school moet veranderen. Als jij had laten weten dat iemand om die foto vroeg was dit niet gebeurt.";
                ScoreCounter(1);
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
