using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class School_Before : ChoiceScript {

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;


        Consequences(1);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();

        SceneManager.LoadScene("Classroom");
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
                rnd = Random.Range(1, 3);
                if (rnd == 1)
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
                    option01Text = "...";
                }
                break;

            case 10:
                narrativeText = "\"Kan ik je even spreken?\"";
                chain = 10;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 11:
                narrativeText = "\"Ik moet je iets zeggen dat ik niet zomaar aan iedereen wil vertellen, maar jou vertrouw ik wel.\"";
                chain = 11;
                numberOfOptions = 1;
                option01Text = "...";
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
                narrativeText = "De leerkracht luistert aandachtig naar het verhaal van je vriend.";
                ScoreCounter(3);
                chain = 16;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 15:
                narrativeText = "Je zegt dat ze die man waarschijnlijk nooit meer zal zien.";
                ScoreCounter(2);
                chain = 30;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 16:
                narrativeText = "Je vriend blijft nog staan als jij verder naar he vrienden wandeld";
                ScoreCounter(1);
                chain = 30;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 17:
                narrativeText = "\"Dit kunnen we best aan de politie vertellen, zij kunnen de dader opsporen en ervoor zorgen dat dit met niemand anders gebeurd.\"";
                chain = 17;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 18:
                narrativeText = "\"We zorgen er later voor dat we dit aan de politie vertellen. Gaan jullie nu maar gewoon naar de les zodat niemand zich afvraagt waar jullie zijn.\"";
                chain = 31;
                numberOfOptions = 1;
                option01Text = "...";
                break;
            //**************************************************************************

            case 30:
                narrativeText = "Je vraagt aan de vriend die je het meest vertrouwd of je hem even kan spreken. \"Wij gaan even naar de WC\" zeggen jullie tegen de rest.";
                chain = 33;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 31:
                narrativeText = "Praten met vrienden kan iemand heel erg hard helpen. Dus neem iemand die je zo iets verteld altijd serieus.";
                chain = 31;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 32:
                narrativeText = "Vertellen over wat er gebeurt is is vaak heel moeilijk. Maar het kan je erg helpen. Je moet op zoek gaan naar personen die je kan vertrouwen om je verhaal te kunnen doen.";
                chain = 32;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 33:
                narrativeText = "Vind je deze personen niet in je omgeving? Dan vind je op de website heel wat plaatsen waar mensen naar je zullen luisteren en die je kan vertrouwen.";
                endOfEvent = true;
                break;

            case 34:
                narrativeText = "Wanneer jullie wat verder staan vertel je je verhaal. Je vriend stelt voor om naar een van de leerkrachten te gaan. Een waarvan jullie allebei weten dat hij te vertrouwen is.";
                chain = 34;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 35:
                narrativeText = "De leerkracht luistert aandachtig naar het je verhaal.";
                chain = 16;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
