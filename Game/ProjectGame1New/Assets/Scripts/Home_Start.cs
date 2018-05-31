using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home_Start : ChoiceScript {

    void Start ()
    {
        StaticInfo.RandomEventNbr = Random.Range(1, 4);
    }

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;


        Consequences(1);
    }

    public override void AfterDialogue()
    {
        base.AfterDialogue();

        StaticInfo.NextScene = "School";

        if (StaticInfo.RandomEventNbr == 1)
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
