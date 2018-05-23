using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingController : MonoBehaviour {


    [SerializeField]
    protected HintPanel hintPanel;

    [SerializeField]
    protected HUDController hudControl;

    [SerializeField]
    protected Winkel_Events shopEvent;

    [SerializeField]
    protected GameObject storePanel;

    [SerializeField]
    protected GameObject buttonGroup;

    [SerializeField]
    protected Button goggles;
    [SerializeField]
    protected Button book;
    [SerializeField]
    protected Button phone;
    [SerializeField]
    protected Button game;

    // Use this for initialization
    void Start () {
        int rnd = Random.Range(1, 6);
        if (rnd == 3)
        {
            DisableRoom();
            shopEvent.enabled = true;
            shopEvent.StartDialogue();
        }
        else
        {
            shopEvent.AfterDialogue();
        }
        if (StaticInfo.HasGoggles)
        {
            goggles.interactable = false;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ItemStore()
    {
        storePanel.SetActive(true);
    }

    public void SwimmingGoggles()
    {
        if (StaticInfo.Money >= 50)
        {
            StaticInfo.Money -= 50;
            StaticInfo.HasGoggles = true;
            goggles.interactable = false;
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg geld voor de zwembril.");
        }
    }
    public void StudyBook()
    {
        if (StaticInfo.Money >= 50)
        {
            StaticInfo.Money -= 50;
            StaticInfo.HasBook = true;
            book.interactable = false;
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg geld voor het boek.");
        }
    }

    public void SmartPhone()
    {
        if (StaticInfo.Money >= 50)
        {
            StaticInfo.Money -= 50;
            StaticInfo.HasPhone = true;
            phone.interactable = false;
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg geld voor de smartphone.");
        }
    }

    public void VideoGame()
    {
        if (StaticInfo.Money >= 50)
        {
            StaticInfo.Money -= 50;
            StaticInfo.HasGame = true;
            game.interactable = false;
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg geld voor het computerspel.");
        }
    }

    public void CloseStore()
    {
        storePanel.SetActive(false);
    }

    public void ClothingStore()
    {
        if (StaticInfo.Money >= 20)
        {
            hintPanel.ActivateHintPanel("Door het shoppen heb je je gedachten kunnen verzetten.");
            hudControl.AffectMood(+10);
            StaticInfo.Money -= 20;
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg geld om te kunnen shoppen.");
        }
    }

    public void CandyStore()
    {
        if (StaticInfo.Money >= 10)
        {
            hintPanel.ActivateHintPanel("Een lekker snoepje verfrist je gedachten een beetje.");
            hudControl.AffectMood(+4);
            StaticInfo.Money -= 10;
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg geld om snoep te kopen.");
        }
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
}
