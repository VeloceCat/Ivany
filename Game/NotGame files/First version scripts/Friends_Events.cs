using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend_Events : ChoiceScript {

    public override void RandomDialogue()
    {
        choiceMade = 0;
        chain = 0;
        //int rnd = Random.Range(1, 6);
        Consequences(1);
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
        switch (num)
        {
            case 1:
                narrativeText = "Je ziet je vrienden staan in de gang en gaat er nog even naartoe.";
                chain = 1;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 2:
                int rnd = Random.Range(1, 3);
                if (rnd = 1)
                {
                    narrativeText = "Een van je vrienden ziet je en komt meteen naar je toe.";
                    chain = 9;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                else
                {
                    narrativeText = "Als ze zien dat je er bent zeggen ze allemaal hallo tegen je en ze praten rustig verder.";
                    chain = 29;
                    numberOfOptions = 2;
                    option01Text = "Je hebt het gevoel dat je aan iemand je verhaal wilt vertellen.";
                    option02Text = "Je ziet het niet zitten om je verhaal te vertellen. ";
                }
                break;

            case 10:
                narrativeText = "\"Kan ik je even spreken?\"";
                chain = 10;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 11:
                int rnd = Random.Range(1, 3);
                if (rnd = 1)
                {
                    narrativeText = "\"Ik moet je iets zeggen dat ik niet zomaar aan iedereen wil vertellen, maar jou vertrouw ik wel.\"";
                    chain = 11;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                else
                {
                    narrativeText = "\"Je ziet er niet zo blij uit de laatste tijd, is er iets?\"";
                    chain = 18;
                    numberOfOptions = 2;
                    option01Text = "\"Ooh niets hoor\" zeg je, \"gewoon slecht geslapen.\"";
                    option02Text = "Je vertelt je verhaal.";
                }
                break;

            case 12:
                narrativeText = "\"Gisteren zat er een man naast me in de tram. Het was superdruk en hij zat heel dicht tegen me aan. Hij zat me al een hele tijd aan te staren en na een tijd legde hij zijn hand op mijn been.\"";
                chain = 12;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 13:
                narrativeText = "\"Als ik zie dat ik dat niet leuk vond reageerde hij niet. En wanneer ik uitstapte achtervolgde hij mij tot ik thuis was en naar binnen ging. En ik heb geen idee wat ik moet  doen.\"";
                chain = 13;
                numberOfOptions = 3;
                option01Text = "Je stelt voor om naar een leerkracht te gaan.";
                option02Text = "Je stelt haar gerust";
                option03Text = "Je zegt haar dat ze zich maar wat inbeeld.";
                break;


            case 14:
                narrativeText = "Hij luistert aandachtig naar het verhaal van je vriend.";
                chain = 16;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 15:
                narrativeText = "Je zegt dat ze die man waarschijnlijk nooit meer zal zien.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 16:
                narrativeText = "Je zegt haar dat ze zich maar wat inbeeld.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 17:
                narrativeText = "\"Dit kunnen we best aan de politie vertellen, zij kunnen de dader opsporen en ervoor zorgen dat dit met niemand anders gebeurd.\"";
                chain = 17;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 18:
                narrativeText = "\"Daarna gaan voor jou zorgen, vandaag ga ik geen les geven en jullie 2 hoeven niet naar de les. Ik zal met jullie meegaan naar de politie.\"";
                moodValue = 5;
                endOfEvent = true;
                break;

            case 19:
                narrativeText = " Na aan rare blik gaan jullie weer bij de rest staan.";
                moodValue = -5;
                break;

            case 20:
                narrativeText = "Je vriend stelt voor om naar een van de leerkrachten te gaan.";
                chain = 20;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 21:
                narrativeText = "Hij luistert aandachtig naar je verhaal.";
                chain = 16;
                numberOfOptions = 1;
                option01Text = "...";
                break;
            //**************************************************************************

            case 30:
                narrativeText = "Je neemt je beste vriend even apart en verteld je verhaal";
                chain = 20;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 31:
                narrativeText = "Praten met je vrienden helpt je om je zorgen even te vergeten. Jammer genoeg gaat de bel al snel.";
                chain = 31;
                numberOfOptions = 2;
                option01Text = "Je gaat gewoon naar de klas.";
                option02Text = "Je probeert je vrienden te overhalen om niet naar school te gaan vandaag.";
                break;

            case 32:
                narrativeText = "Al pratend gaan jullie samen naar het lokaal.";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 33:
                int rnd = Random.Range(1, 3);
                if (rnd = 1)
                {
                    narrativeText = "\"Voor 1 keer dan\" geven een aantal vrienden uiteindelijk toe.";
                    chain = 33;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                else
                {
                    narrativeText = "Geen van je vrienden zien dat zitten. \"school is belangrijk\", zeggen ze";
                    chain = 34;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                break;

            case 34:
                narrativeText = "Waar dacht je naartoe te gaan?";
                moodValue = -5;
                endOfEvent = true;
                break;

            case 35:
                narrativeText = "En ze hebben gelijk, denk je in jezelf. Jullie gaan allemaal naar de klas.";
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                endOfEvent = true;
                break;
        }
    }
    }
