using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomController : MonoBehaviour {

    [SerializeField]
    protected HomeEvent homeEvent;

    [SerializeField]
    protected GameObject buttonGroup;

    [SerializeField]
    protected HintPanel hintPanel;

    [SerializeField]
    protected HUDController hudControl;

    [SerializeField]
    protected Button game;

    [SerializeField]
    protected Image fade;

    // Use this for initialization
    void Start () {
        
        int rnd = Random.Range(1, 8);
        if (rnd > 5)
        {
            DisableRoom();
            homeEvent.enabled = true;
            homeEvent.StartDialogue();
        }
        else
        {
            homeEvent.AfterDialogue();
        }
        Debug.Log(rnd);

        if (!StaticInfo.HasGame)
        {
            game.enabled = false;
        }
        else
        {
            game.enabled = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisableRoom()
    {
        Button[] btns = buttonGroup.GetComponentsInChildren<Button>();
        foreach (Button b in btns)
        {
            b.interactable = false;
        }
    }

    public void EnableRoom()
    {
        Button[] btns = buttonGroup.GetComponentsInChildren<Button>();
        foreach (Button b in btns)
        {
            b.interactable = true;
        }
    }

    public void StudyBook()
    {
        if (StaticInfo.Energy >= 10)
        {
            hudControl.AffectEnergy(-10);
            hudControl.AffectMood(-2);
            if (!StaticInfo.HasBook)
            {
                StaticInfo.ChanceToSucceed += 15;
            }
            else
            {
                StaticInfo.ChanceToSucceed += 20;
            }
        }
        
    }

    public void SleepInBed()
    {
        Debug.Log(StaticInfo.DayCounter%5);
        EnterFade();
        StaticInfo.Energy = 100;
        StaticInfo.AfterClass = false;
        hudControl.AffectEnergy(100);
        StaticInfo.DayCounter += 1;
        if (StaticInfo.DayCounter % 6 == 5 && StaticInfo.DaysPresent < 4)
        {
            hintPanel.ActivateHintPanel("AANDACHT!\nJe bent niet genoeg aanwezig geweest voor de test, je faalt automatisch en iedereen is teleurgesteld.\nOm mee te kunnen doen moet je elke dag naar school gaan!");
            hudControl.AffectMood(-10);
        }
        else if (StaticInfo.DayCounter > 4 && StaticInfo.DayCounter %6 == 0 && StaticInfo.DaysPresent >0)
        {
            hintPanel.ActivateHintPanel("AANDACHT!\nJe hebt de test op school gemist, je faalt automatisch en iedereen is teleurgesteld.\nOm mee te kunnen doen moet je elke dag naar school gaan!");
            hudControl.AffectMood(-10);
            StaticInfo.DaysPresent = 0;
        }
    }

    public void TalkToParents()
    {

    }

    public void PlayGame()
    {

    }


    public void EnterFade()
    {
        StartCoroutine(CrossFade());
    }

    IEnumerator CrossFade()
    {
        fade.canvasRenderer.SetAlpha(0);
        fade.enabled = true;
        fade.CrossFadeAlpha(1, 2.0f, false);
        yield return new WaitForSeconds(2);
        fade.CrossFadeAlpha(0, 2.0f, false);
        yield return new WaitForSeconds(2);
        fade.enabled = false;
    }
}
