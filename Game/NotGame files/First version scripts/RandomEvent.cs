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
                narrativeText = "Terwijl je rustig aan het wandelen bent fluit er iemand naar je. Je kijkt om je heen maar hebt geen idee wie het was. Maar het geeft je een raar gevoel en je denkt er de hele dag over na, “heb ik iets verkeerd gedaan?” ";
                moodValue = 0;
                endOfEvent = true;
                break;
            case 2:
                narrativeText = "Het is druk onderweg en plots voel je iets raars. Iemand die je duidelijk bewust aanraakt. Je kijkt haastig rond, maar je kan onmogelijk weten wie het gedaan heeft.";
                moodValue = 0;
                endOfEvent = true;
                break;
            case 3:
                narrativeText = "Een man roept naar je \"Hela! Met u wil ik wel eens een nachtje plezier maken!\" Gevolgd door luid gelach. Je besluit om snel verder te gaan en het gewoon te negeren. Je hoort verder niets meer, maar de beledigende woorden verpesten wel de rest van de dag. Dit gaat je nog wel lang bijblijven, jammer genoeg. ";
                moodValue = 0;
                endOfEvent = true;
                break;
            case 4:
                chain = 8;
                narrativeText = "Op de tram merk je dat er een vrouw al de hele tijd in jou richting zit te kijken. “Zit ze naar mij te staren?” vraag je jezelf af.";
                numberOfOptions = 3;
                option01Text = "Je krijg een ongemakkelijk gevoel en besluit een halte vroeger af te stappen. Het is goed weer een wandeling zal je goed doen.";
                option02Text = "Je verplaats je op de tram uit het zicht van de vrouw en stapt af aan je normale halte.";
                option03Text = "Je blijft zitten waar je zit en probeert de vrouw te negeren en je stapt aan je normale halte af.";
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
                option01Text = "Je bent beleefd en antwoord kort op zijn vragen en probeert duidelijk te maken dat je geen zin hebt om te praten.";
                option02Text = "Je negeert hem, hopelijk snapt hij dat je geen zin hebt in een gesprek.";
                option03Text = "Je praat met hem, je hebt toch nog heel wat tijd voor je bent waar je moet zijn.";
                if (StaticInfo.HasPhone)
                {
                    numberOfOptions = 4;
                    option04Text = "Je stuurt een vriend een bericht met wat er aan de hand is en dat je gebeld moet worden.";
                }
                
                break;
            case 6:
                narrativeText = "Bijna op je bestemming wordt je plots een steegje ingetrokken, je probeert te roepen maar al snel voel je een hand over je mond. Een vrouw heeft je de steeg in getrokken en is je aan het betasten.";
                numberOfOptions = 3;
                option01Text = "Je probeert met al je macht om jezelf vrij te krijgen.";
                option02Text = "Je bijt in de hand over je mond om zo te kunnen roepen.";
                option03Text = "\"Als ik ze niet tegen werk is het misschien sneller voorbij\" denk je en laat de vrouw begaan.";
                break;
            case 9:
                narrativeText = "Door de wandeling ben je een beetje later. “Waar bleef je?” vraagt iemand?";

                
                break;
            default:
                narrativeText = "Error";
                endOfEvent = true;
                break;
        }
    }

}
