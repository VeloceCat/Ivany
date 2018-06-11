using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class School_Before : ChoiceScript
{

    [SerializeField]
    protected Image femaleFriend;
    [SerializeField]
    protected Image maleFriend;
    [SerializeField]
    protected Image teacher;

    protected bool isBoy = false;

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;

        femaleFriend.enabled = false;
        maleFriend.enabled = false;
        teacher.enabled = false;

        if (Random.Range(1,3) == 1)
        {
            isBoy = true;
        }
        else
        {
            isBoy = false;
        }

        Consequences(1);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();

        SceneManager.LoadScene("Classroom");
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


    public override void StartTalking(int num)
    {
        int rnd;
        switch (num)
        {
            case 1:
                narrativeText = "Je ziet je vrienden staan in de gang en gaat er naartoe.";
                chain = 1;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 2:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "Een van je vrienden ziet je en komt meteen naar je toe.";
                    FadesIn(femaleFriend);
                    chain = 9;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                else
                {
                    narrativeText = "Je gaat bij hen staan en praat met hen mee tot de bel gaat.";
                    chain = 29;
                    numberOfOptions = 1;
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
                narrativeText = "\"Als ik zei dat ik dat niet leuk vond, reageerde hij niet. Wanneer ik uitstapte, bleef hij mij volgen tot ik thuis was en naar binnen ging. Ik heb geen idee wat ik moet doen.\"";
                chain = 13;
                numberOfOptions = 3;
                option01Text = "Je stelt voor om naar een leerkracht te gaan.";
                option02Text = "Je stelt haar gerust";
                option03Text = "Je zegt haar dat ze zich maar wat inbeeldt.";
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
                ScoreCounter(3);
                greenBox = true;
                chain = 30;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 16:
                narrativeText = "Je vriend blijft nog staan als jij verder naar je vrienden wandelt";
                ScoreCounter(1);
                chain = 30;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 17:
                narrativeText = "\"Dit kunnen we best aan de politie vertellen, zij kunnen de dader opsporen en ervoor zorgen dat dit met niemand anders gebeurt.\"";
                chain = 17;
                FadesOut(femaleFriend);
                FadesIn(teacher);
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
                narrativeText = "Plots komt er iemand aangewandeld die een van je vrienden lastig valt.";
                chain = 39;
                numberOfOptions = 3;
                option01Text = "Je gaat dichter bij je vriend staan en praat met hem.";
                option02Text = "Je laat het gewoon gebeuren.";
                option03Text = "Je zegt tegen de belager dat hij moet weggaan.";
                break;

            case 31:
                narrativeText = "Praten met vrienden kan iemand heel erg hard helpen. Dus neem iemand die je zo iets vertelt altijd serieus.";
                chain = 31;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 32:
                narrativeText = "Vertellen over wat er gebeurd is, is vaak heel moeilijk. Maar het kan je erg helpen. Je moet op zoek gaan naar personen die je kan vertrouwen om je verhaal te kunnen doen.";
                chain = 32;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 33:
                narrativeText = "Vind je deze personen niet in je omgeving? Dan vind je op de website heel wat plaatsen waar mensen naar je zullen luisteren en die je kan vertrouwen.";
                endOfEvent = true;
                break;

            case 35:
                narrativeText = "De leerkracht luistert aandachtig naar het je verhaal.";
                chain = 16;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 34:
                narrativeText = "Wanneer jullie wat verder staan, vertel je je verhaal. Je vriend stelt voor om naar een van de leerkrachten te gaan. Een waarvan jullie allebei weten dat hij te vertrouwen is.";
                chain = 34;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 40:
                narrativeText = "Je vriend snapt wat je van plan bent en negeert zijn belager die even later weg gaat. Achteraf bedankt je vriend je.";
                ScoreCounter(3);
                endOfEvent = true;
                break;

            case 41:
                narrativeText = "Na een tijdje wandelt de belager lachend weg, je vriend doet alsof er niets gebeurd is. Misschien had je hem beter geholpen?";
                ScoreCounter(1);
                endOfEvent = true;
                break;

            case 42:
                narrativeText = "De belager zegt dat jij er niets mee te maken hebt. Maar omdat je je vriend helpt, druipt hij toch af.";
                ScoreCounter(3);
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
