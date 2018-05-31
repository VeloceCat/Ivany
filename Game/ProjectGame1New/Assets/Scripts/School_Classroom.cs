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

                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
