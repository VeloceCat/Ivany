using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class School_Classroom : ChoiceScript {

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;


        Consequences(1);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();
        StaticInfo.AfterClass = true;

        SceneManager.LoadScene("School");
    }


    public override void StartTalking(int num)
    {
        int rnd;
        switch (num)
        {
            case 1:
                narrativeText = "Weeral een doodnormale, redelijk saaie schooldag.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 2:
                narrativeText = "Vandaag was er een leerkracht jarig. Een feestje in de klas en een leuke les.";
                moodValue = 5;
                endOfEvent = true;
                break;

            case 3:
                narrativeText = "In de gang komt er iemand naar je toe en lijkt je te willen versieren. Als snel merk je dat het enkel is om met je te lachen. ";
                chain = 9;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 4:
                narrativeText = "Je ziet plots dat er een papiertje in je rugzak zit. Je pakt het op en vouwt het open.";
                chain = 19;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 10:
                int rnd = Random.Range(1, 3);
                if (rnd = 1)
                {
                    narrativeText = "Je vrienden zien al snel wat er gebeurd en trekken je al snel mee.";
                    chain = 10;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                else
                {
                    narrativeText = "Omdat je een beetje later was zijn jullie bijna alleen in de gang. ";
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
                int rnd = Random.Range(1, 3);
                if (rnd = 1)
                {
                    narrativeText = "Al snel hoor je dat de persoon opgeeft. \"Als je wordt genegeerd is de pret er snel af hé.\" Lach je in jezelf.";
                    moodValue = 5;
                    endOfEvent = true;
                }
                else
                {
                    narrativeText = "De persoon blijft je achtervolgen tot aan je lokaal. Wanneer je de deur opendoet staat je leerkracht bij de deur.";
                    chain = 14;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                break;

            case 13:
                narrativeText = "Maar dat is juist wat je achtervolger wou. Je reageert nog eens, zonder resultaat.";
                chain = 13;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 14:
                narrativeText = "Je beslist om je achtervolger dan maar gewoon te negeren. Geen reactie, geen plezier blijkbaar want je achtervolger geeft al snel op.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 15:
                narrativeText = "Ze ziet wat er aan de hand is en stuurt je belager snel weg. \"Alles ok?\" vraagt ze, \"ja hoor\" antwoord je en je gaat op je plaats zitten.";
                moodValue = -5;
                endOfEvent = true;
                break;

            //***********************************************************

            case 20:
                narrativeText = "Het is een foto van je terwijl je naar het toilet gaat op school!";
                chain = 20;
                numberOfOptions = 2;
                option01Text = "Je weet niet goed wat je ermee moet doen.";
                option02Text = "Je bent erg aangeslagen en vindt dat je dit moet zeggen.";
                break;

            case 21:
                narrativeText = "Het is een foto van je terwijl je naar het toilet gaat op school!";
                chain = 22;
                numberOfOptions = 2;
                option01Text = "Omdat je zelf op de foto staat durf je het tegen niemand te zeggen.";
                option02Text = "Je probeert iemand te vinden die je kan vertrouwen om erover te praten.";
                break;

            case 22:
                narrativeText = "Je gaat snel naar de directeur om te laten zien wat je gevonden hebt.";
                chain = ;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 23:
                narrativeText = "Wie heeft die foto genomen? Wie heeft de foto al gezien? Zoveel vragen zonder antwoord. Elke dag dat je naar school gaat ga je er mee zitten.";
                moodValue = -5;
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
                chain = 21;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 26:
                narrativeText = "Die zegt dat je het best ook tegen de directeur moet zeggen, zij kunnen misschien de schuldige vinden.";
                chain = 26;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 30:
                narrativeText = "Je gaat snel naar de directeur om te laten zien wat je gevonden hebt.";
                chain = 30;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 31:
                narrativeText = "Het is een beetje raar om de foto te laten zien, maar je misschien help je andere die het niet durven zeggen.";
                chain = 31;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 32:
                narrativeText = "De directeur beloofd te onderzoeken wie dit gedaan heeft en hen te straffen.";
                moodValue = -10;
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
