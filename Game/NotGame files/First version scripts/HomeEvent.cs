using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeEvent : ChoiceScript {

    public override void RandomDialogue()
    {
        choiceMade = 0;
        chain = 0;
        int rnd = Random.Range(1, 6);
        Consequences(rnd);
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
            default:
                narrativeText = "Error";
                endOfEvent = true;
                break;
        }
    }
    }
