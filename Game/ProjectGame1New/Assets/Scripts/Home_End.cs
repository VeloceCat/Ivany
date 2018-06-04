using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home_End : ChoiceScript {

    [SerializeField]
    protected Image fade;

    public override void StartDialogue()
    {
        fade.enabled = false;
        choiceMade = 0;
        chain = 0;

        int rnd = Random.Range(1, 3);
        Consequences(rnd);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();
        EnterFade();
        //SceneManager.LoadScene("Ending");

    }

    public void EnterFade()
    {
        StartCoroutine(CrossFadeOut());
    }

    IEnumerator CrossFadeOut()
    {
        fade.canvasRenderer.SetAlpha(0);
        fade.enabled = true;
        fade.CrossFadeAlpha(1, 2.0f, false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Ending");
    }


    public override void StartTalking(int num)
    {
        int rnd;
        switch (num)
        {
            case 1:
                narrativeText = "Wanneer je thuiskomt merk je niet dat je oma op bezoek is, je gaat gewoon meteen naar je kamer zonder iets te zeggen. Even later hoor je iemand op de deur kloppen \"Oma is hier, kom je even hallo zeggen?\"";
                chain = 13;
                numberOfOptions = 3;
                option01Text = "\"Ja hoor, ik kom direct\", zeg je.";
                option02Text = "\"Nee, te veel werk\" zeg je.";
                option03Text = "Je zegt helemaal niets.";
                break;

            case 2:
                narrativeText = "Wanneer je thuiskomt merken je ouders merken er iets niet klopt en vragen nog maar eens wat er is. Maar je antwoord niet.";
                chain = 2;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 3:
                narrativeText = "Je gaat gewoon meteen weer naar je kamer. Je ouders zijn erg ongerust en je moeder klopt op de deur van je kamer en vraagt wat er is.";
                chain = 21;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 14:
                narrativeText = "Even later ga je naar beneden om hallo te zeggen tegen je oma. Ze ziet dat je er een beetje triest uitziet. \"Wat is er?\" vraagt ze.";
                chain = 16;
                numberOfOptions = 3;
                option01Text = "\"Het was een moeilijke dag, meer niet.\" Zeg je.";
                option02Text = "Je zegt helemaal niets en gaat weer naar je kamer.";
                option03Text = "Je verteld hen wat er gebeurt is vandaag.";
                break;

            case 15:
                narrativeText = "Je hoort beneden iedereen dag zeggen tegen je oma en daarna hoor je de voordeur dichtslaan. Niet veel later roept je moeder je. Ze is wat boos op je omdat je zelfs niet even de moeite gedaan hebt om gewoon \"hallo\" te komen zeggen.";
                endOfEvent = true;
                break;

            case 16:
                narrativeText = "Je moeder klinkt boos wanneer ze even later voor de tweede keer komt vragen of je niet even naar beneden komt.";
                chain = 20;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 17:
                narrativeText = "\"Ooh zulke dagen heb je nu eenmaal\" zegt je oma. Je neemt een koekje en gaat weer naar je kamer.";
                ScoreManager(2);
                endOfEvent = true;
                break;

            case 18:
                narrativeText = "\"Tja, kleine kindjes worden groot\" zegt je oma al lachend tegen je ouders.";
                ScoreManager(1);
                redBox = true;
                endOfEvent = true;
                break;

            case 19:
                narrativeText = "Iedereen luistert aandachtig tot je je hele verhaal hebt gedaan, je moeder komt naast je zitten en slaagt haar arm om je. \n\"We zullen samen naar een oplossing zoeken\" stelt ze voor, en je kan enkel nog knikken. Je verhaal doen was moeilijk maar je weet dat dit de juiste beslissing was.";
                ScoreManager(3);
                greenBox = true;
                endOfEvent = true;
                break;

            case 21:
                rnd = Random.Range(1, 3);
                chain = 13;
                numberOfOptions = 2;
                option01Text = "Je gaat toch maar naar beneden";
                option01Text = "Je zegt nog steeds niets.";
                break;

            case 22:
                narrativeText = "Maar je antwoord niet. Je gaat gewoon meteen weer naar je kamer. Je ouders zijn erg ongerust en je moeder klopt op de deur van je kamer en vraagt nog maar eens wat er is.";
                chain = 22;
                numberOfOptions = 2;
                option01Text = "Je zegt weer niks.";
                option02Text = "Je verteld je ouders wat je allemaal hebt meegemaakt.";
                break;

            case 23:
                narrativeText = "Je durft het niet te zeggen, je gaat naar je kamer en staart uit de raam. Je kan niet meer. Misschien moet je het toch maar zeggen.";
                ScoreManager(2);
                chain = 24;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 24:
                narrativeText = "Je ouders kunnen niets anders doen dan luisteren. En daarna doen ze alles wat ze kunnen om je te helpen.";
                chain = 29;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 25:
                rnd = Random.Range(1, 3);
                if (rnd == 1)
                {
                    narrativeText = "Je moeder hoort je zachtjes wenen en stapt de kamer binnen.";
                    chain = 25;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                else
                {
                    narrativeText = "Je hoort je moeder weer naar beneden gaan. En voelt je zo alleen.";
                    chain = 26;
                    numberOfOptions = 1;
                    option01Text = "...";
                }
                break;

            case 26:
                narrativeText = "Je merkt pas dat ze er is als je een arm om je heen voelt. Je moeder zegt niks, maar houd je gewoon vast.\nJe voelt jezelf blij worden, en voor je het weet doe je je verhaal. Je moeder luistert gewoon, maar je voelt dat hij alles voor je zal doen om je te helpen.";
                greenBox = true;
                ScoreManager(3);
                chain = 29;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 27:
                narrativeText = "Je laat je tranen de vrije loop gaan. Wanneer je even later naar beneden gaat voor het avond eten zien je ouders dat er iets niet klopt.";
                ScoreManager(2);
                chain = 27;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 28:
                narrativeText = "Ze zijn zo bezorgd om je en zonder nog verder aan het eten te denken slaan ze hun armen om je heen om vragen je wat er is. Je voelt plots toch de kracht om het te vertellen en je verteld over de dingen die je de laatste dagen hebt meegemaakt.";
                greenBox = true;
                chain = 29;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 30:
                narrativeText = "De volgende dag ga je met je ouders naar de politie om je verhaal te doen.\nDaarna nemen ze je mee naar een van die leuke plekjes waar jullie vroeger vaak naartoe ging. \nVJe  voelt je gewoon blij en gelukkig.";
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
