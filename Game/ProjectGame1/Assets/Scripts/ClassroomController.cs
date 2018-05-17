using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassroomController : MonoBehaviour {

    [SerializeField]
    protected School_Events schoolEvent;

    private int testScore;

    [SerializeField]
    protected HintPanel hintPanel;

    [SerializeField]
    protected HUDController hudControl;
    // Use this for initialization
    void Start () {
        schoolEvent.StartDialogue();
        if (StaticInfo.DayCounter % 6 < 4)
        {
            StaticInfo.DaysPresent += 1;
            StaticInfo.ChanceToSucceed += 10;
            
        }
        else if (StaticInfo.DayCounter % 6 == 5)
        {
            if (StaticInfo.DaysPresent == 4)
            {
                string prefix = "Vrijdag testdag!\nJe hebt {0}%.\n";
                testScore = Random.Range(StaticInfo.ChanceToSucceed, 101);
                if (testScore >= 50)
                {
                    if (testScore >= 75)
                    {
                        hintPanel.ActivateHintPanel(prefix + "Wow, je hebt zowat de beste punten van de klas. De leerkracht is duidelijk tevreden en je ouders zijn heel trots, je krijgt meer zakgeld dan gewoonlijk.");
                        hudControl.AffectMood(+10);
                    }
                    else
                    {
                        hintPanel.ActivateHintPanel(prefix + "Door je harde werk ben je geslaagd voor de wekelijkse test. Goed gedaan!");
                        hudControl.AffectMood(+5);
                    }
                    StaticInfo.MoneyReward = testScore / 10 * 5;
                    StaticInfo.GetReward = true;
                }
                else
                {
                    hintPanel.ActivateHintPanel(prefix + "\"Heb je wel genoeg geleerd?\" vraagt de leerkracht als je je test terug krijgt. Hier gaan je ouders niet tevreden mee zijn.");
                    hudControl.AffectMood(-10);
                }
            }
            else
            {
                // niet genoeg aanwezig geweest om test af te leggen
                
            }
            StaticInfo.DaysPresent = 0;
            StaticInfo.ChanceToSucceed = 10;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
