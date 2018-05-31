using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomEvent : ChoiceScript {

    
    

    public override void StartDialogue()
    {
        choiceMade = 0;
        chain = 0;

        // In geval event begint met random
        int rnd = Random.Range(1, 7);
        Consequences(rnd);
    }

    public override void AfterDialogue()
    {
        SceneManager.LoadScene(StaticInfo.NextScene);
    }

    public override void StartTalking(int num)
    {
        int rnd;  // niet opnieuw aanmaken
        switch (num)
        {
            // bij alle cases narrativeText meegeven en numberOfChoices, voor exit bool endOfEvent op true zetten

            //Event begint nu met random getal van 1 tem 6, voor ander getal aanpassen in StartDialogue bovenaan dit script (vanuit 1 basistekst vertrekken, verander Consequences(rnd) naar Consequences(1)

            default:
                narrativeText = "Error";
                break;
        }
    }

}
