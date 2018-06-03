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
                narrativeText = "\"Tuuuuuut, tuuuuut\" nog half slapend duw je de snooze knop van de wekker in. \"Opstaan!!\" hoor je iemand roepen.";
                chain = 1;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 2:
                narrativeText = "Redelijk slecht gezind sta je toch maar op. Gelukkig is het woensdag, maar een halve dag dus. Je staat op, doet je kleren aan en gaat naar beneden.";
                chain = 2;
                numberOfOptions = 1;
                option01Text = "...";
                break;

            case 3:
                narrativeText = "Iedereen is al druk in de weer. Je sloft naar de keukentafel voor je ontbijt. Na de laatste hap voel je je al een pak beter en je vertrekt naar de tramhalte om naar school te gaan.";
                endOfEvent = true;
                break;

            default:
                narrativeText = "Error";
                break;
        }
    }
}
