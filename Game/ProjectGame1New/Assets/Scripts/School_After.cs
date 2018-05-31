using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class School_After : ChoiceScript {

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;


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


    public override void StartTalking(int num)
    {
        int rnd;
        switch (num)
        {
            case 1:

                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
