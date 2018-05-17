using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeEvent : ChoiceScript {

    [SerializeField]
    protected RoomController RoomControl;

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;
        StaticInfo.CanTalkToParents = true;
        
        Consequences(1);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();
        textBox.SetActive(false);
        choice01.SetActive(false);
        choice02.SetActive(false);
        choice03.SetActive(false);
        choice04.SetActive(false);
        StaticInfo.MenuInteractable = true;
        RoomControl.EnableRoom();
    }


    public override void StartTalking(int num)
    {
        int rnd;
        switch (num)
        {
            case 1:
                narrativeText = "Je doet de deur achter je dicht, zet je schoenen aan de kant en wandelt naar binnen.";
                rnd = Random.Range(1, 6); //range is dus 1-5, chain wordt 2-6
                chain = rnd;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 2:
                narrativeText = "Er is niemand thuis als je binnen komt. Dus je eet een appel en gaat naar je kamer.";
                endOfEvent = true;
                StaticInfo.CanTalkToParents = false;
                break;

            case 3:
                narrativeText = "Je komt goed gezind thuis en je ouders vragen hoe je dag geweest is.";
                chain = 6;
                numberOfOptions = 3;
                option01Text = "\"Goed\" antwoord je een beetje tegen je zin.";
                option02Text = "\"Heel goed\" zeg je tegen je vader.";
                option03Text = "Je zegt niets en gaat meteen naar je kamer.";
                break;

            case 4:
                narrativeText = "Wanneer  je thuiskomt zien je ouders meteen dat je niet helemaal jezelf bent.";
                chain = 12;
                numberOfOptions = 1;
                option01Text = "...";
                break;


            case 5:
                narrativeText = "Wanneer je thuiskomt merk je niet dat je oma op bezoek is, je gaat gewoon meteen naar je kamer zonder iets te zeggen. Even later hoor je iemand op de deur kloppen \"Oma is hier, kom je even hallo zeggen?\"";
                chain = 13;
                numberOfOptions = 3;
                option01Text = "\"Ja hoor, ik kom direct\", zeg je.";
                option02Text = "\"Nee, te veel werk\" zeg je.";
                option03Text = "Je zegt helemaal niets.";
                break;

            case 6:
                narrativeText = "Voor de zoveelste dag op rij ga je zonder iets te zeggen meteen naar je kamer en tijdens het eten kijk je maar lusteloos naar je bord. Je ouders merken dat er iets niet klopt en vragen nog maar eens wat er is.";
                chain = 21;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 7:
                narrativeText = "Je hebt geen zin in een gesprek dus ga je meteen naar je kamer. Tijdens het eten vragen je ouders nog eens hoe je dag was.";
                chain = 9;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 8:
                narrativeText = "Je ouders komen net terug van de supermarkt en je vertelt wat over je dag terwijl je helpt met het uitladen van de boodschappen. Daarna ga je naar je kamer.";
                moodValue = 5;
                endOfEvent = true;
                break;

            case 9:
                narrativeText = "Je hoort even later iemand op je deur kloppen “Is alles ok?” hoor je je moeder vragen.";
                chain = 10;
                numberOfOptions = 2;
                option01Text = "\"Ja\" zeg je droog terug.";
                option02Text = "\"Ja hoor, gewoon niets speciaals gebeurd vandaag.\"";
                break;

            case 10:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "\"Goed\" zeg je nog eens waarna je een nieuwe hap neemt.";
                    //geen effect

                }
                else
                {
                    narrativeText = "Je verteld tijdens het eten over je dag en je hebt een leuke gesprek met je ouders.";
                    moodValue = 5;

                }
                endOfEvent = true;
                break;

            case 11:
                narrativeText = "\"Hier ga ik het mee moeten doen vandaag\" besluit je moeder en ze gaat weer naar beneden.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 12:
                narrativeText = "Je moeder gaat terug naar beneden."; //geen effect
                endOfEvent = true;
                break;


            case 13:
                narrativeText = "Ze vragen wat er is. \"Niets\" is je korte antwoord en je gaat snel naar je kamer om verder geen gesprek te hoeven voeren.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 14:
                narrativeText = "Even later ga je naar beneden om hallo te zeggen tegen je oma. Ze ziet dat je er een beetje triest uitziet. \"Wat is er?\" vraagt ze.";
                chain = 16;
                numberOfOptions = 3;
                option01Text = "\"Het was een moeilijke dag, meer niet.\" Zeg je.";
                option02Text = "Je zegt helemaal niets en gaat weer naar je kamer.";
                option03Text = "Je verteld hen wat er gebeurt is de voorbije dagen.";
                break;

            case 15:
                narrativeText = "Je hoort beneden iedereen dag zeggen tegen je oma en daarna hoor je de voordeur dichtslaan. Niet veel later roept je moeder je. Ze is wat boos op je omdat je zelfs niet even de moeite gedaan hebt om gewoon \"hallo\" te komen zeggen.";
                chain = 19;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 16:
                narrativeText = "Ook de tweede keer zeg je helemaal niets, je moeder klinkt boos wanneer ze even later voor de derde keer komt vragen of je niet even naar beneden komt.";
                chain = 20;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 17:
                narrativeText = "\"Ooh zulke dagen heb je nu eenmaal\" zegt je oma. Je neemt een koekje en gaat  weer naar je kamer.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 18:
                narrativeText = "\"Tja, kleine kindjes worden groot.\" zegt je oma al lachend tegen je ouders.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 19:
                narrativeText = "Iedereen luistert aandachtig tot je je hele verhaal hebt gedaan, je moeder komt naast je zitten en slaagt haar arm om je. \n\"We zullen samen naar een oplossing zoeken\" stelt ze voor, en je kan enkel nog knikken. Je verhaal doen was  moeilijk maar je weet dat dit de juiste beslissing was.";
                moodValue = 5;
                endOfEvent = true;
                break;

            case 20:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "Je gaat toch maar even naar beneden.  Je zegt even hallo en eet een koekje. Daarna ga je snel weer naar boven.";
                    //geen effect

                }
                else
                {
                    narrativeText = "Je zegt nog steeds niets, ook al weet je dat je moeder daar helemaal niet blij mee gaat zijn.";
                    moodValue = -5;

                }
                endOfEvent = true;
                break;

            case 21:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "\"Goed\" zeg je nog eens waarna je een nieuwe hap neemt.";
                    //geen effect

                }
                else
                {
                    narrativeText = "Je verteld tijdens het eten over je dag en je hebt een leuke gesprek met je ouders.";
                    moodValue = 5;

                }
                endOfEvent = true;
                break;

            case 22:
                narrativeText = "Maar je antwoord niet. Je gaat gewoon meteen weer naar je kamer. Je ouders zijn erg ongerust en je vader klopt op de deur van je kamer en vraagt nog maar eens wat er is.";
                chain = 22;
                numberOfOptions = 2;
                option01Text = "Je zegt weer niks.";
                option02Text = "Je verteld je ouders wat je allemaal hebt meegemaakt.";
                break;

            case 23:
                narrativeText = "Je durft het niet te zeggen, je gaat naar je kamer en staart uit de raam. Je probeert je tranen te bedwingen maar het gaat niet. Je kan niet meer.";
                chain = 24;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 24:
                narrativeText = "Je ouders kunnen niets anders doen dan luisteren. En daarna doen ze alles wat ze kunnen om je te helpen.";
                chain = 27;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 25:
                rnd = Random.Range(1, 2);
                if (rnd == 1)
                {
                    narrativeText = "Je vader hoort je zachtjes wenen en stapt de kamer binnen.";
                    chain = 25;

                }
                else
                {
                    narrativeText = "Je hoort je vader weer naar beneden gaan. En voelt je zo alleen.";
                    chain = 26;

                }
                break;

            case 26:
                narrativeText = "Je merkt pas dat ze er is als je een arm om je heen voelt. Je vader zegt niks, maar houd je gewoon vast.\nJe voelt jezelf blij worden, en voor je het weet doe je je verhaal. Je vader luistert gewoon, maar je voelt dat hij alles voor je zal doen om je te helpen.";
                chain = 27;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 27:
                narrativeText = "Je laat je tranen de vrije loop gaan. Wanneer je even later naar beneden gaat voor het avond eten zien je ouders dat er iets niet klopt.\nZe zijn zo bezorgd om je en zonder nog verder aan het eten te denken slaan ze hun armen om je heen om vragen je wat er is. Je voelt plots toch de kracht om te praten over de dingen die je de laatste dagen hebt meegemaakt.";
                chain = 27;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 28:
                narrativeText = "De volgende dag ga je met je ouders naar de politie om je verhaal te doen.\nDaarna nemen ze je mee naar een van die leuke plekjes waar jullie vroeger vaak naartoe gingen en voor het eerst in een lange tijd voel je je gewoon blij en gelukkig.";
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                endOfEvent = true;
                break;
        }
    }
    }
