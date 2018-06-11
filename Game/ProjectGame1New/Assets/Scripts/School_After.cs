using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class School_After : ChoiceScript {

    [SerializeField]
    protected Image maleFriend;
    [SerializeField]
    protected Image femaleFriend;

    protected bool isBoy;

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;

        maleFriend.enabled = false;
        femaleFriend.enabled = false;

        if (Random.Range(1, 3) == 1)
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

        if (StaticInfo.ShopNotPool)
        {
            StaticInfo.NextScene = "Shopping";
        }
        else
        {
            StaticInfo.NextScene = "Pool";
        }
        

        if (StaticInfo.RandomEventNbr == 2)
        {
            SceneManager.LoadScene("RandomEventScene");
        }
        else
        {
            SceneManager.LoadScene(StaticInfo.NextScene);
        }

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
        //int rnd;
        switch (num)
        {
            case 1:
                narrativeText = "\"Trrriiing\" eindelijk, het laatste belsignaal. Wanneer je naar buiten wandelt, voel je je maag grommen. \"Iemand zin om een broodje te gaan eten en deze schoolvoormiddag even te vergeten?\" vraag je aan je vrienden.";
                chain = 1;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 2:
                narrativeText = "\"Natuurlijk,\" zeggen de meeste enthousiast. Onderweg vraagt er iemand of jullie zin hebben om na het eten iets te gaan doen.";
                chain = 2;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 3:
                if (StaticInfo.NextScene == "Shopping")
                {
                    narrativeText = "\"Het is mooi weer vandaag dus waarom niet?\" zeg je. \"Laten we gaan shoppen!\" stelt iemand voor.";
                }
                else
	            {
                    narrativeText = "\"Het is mooi weer vandaag dus waarom niet?\" zeg je. \"Laten we gaan zwemmen!\" stelt iemand voor.";

                }
                FadeBoyOrGirl(true);
                chain = 3;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 4:
                narrativeText = "De anderen zijn meteen akkoord. \"Dat is dan afgesproken, even thuis onze schoolspullen wegzetten en dan kunnen we vertrekken!\"";
                chain = 2;
                numberOfOptions = 1;
                option01Text = "...";
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
