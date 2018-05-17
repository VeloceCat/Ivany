using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class HUDController : MonoBehaviour {

    private int energyCounter;
    private int moodCounter;

    [SerializeField]
    protected Slider energyBar;
    [SerializeField]
    protected Slider moodBar;

    [SerializeField]
    protected Button compass;
    [SerializeField]
    protected Button book;
    [SerializeField]
    protected Button backpack;
    [SerializeField]
    protected Button phone;

    [SerializeField]
    protected Button loseEnergy;

    [SerializeField]
    protected float barSpeed;

	// Use this for initialization
	void Start () {
        //ResetBars();
        //energyCounter = PlayerPrefs.GetInt("PlayerEnergy");
        //moodCounter = PlayerPrefs.GetInt("PlayerMood");
        energyCounter = StaticInfo.Energy;
        moodCounter = StaticInfo.Mood;
        energyBar.value = energyCounter;
        moodBar.value = moodCounter;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (energyCounter < 0)
        {
            energyCounter = 0;
        }

        if (moodCounter < 0)
        {
            moodCounter = 0;
        }
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void DisableMenu()
    {
        compass.interactable = false;
        book.interactable = false;
        backpack.interactable = false;
        phone.interactable = false;
    }

    public void EnableMenu()
    {
        compass.interactable = true;
        book.interactable = true;
        backpack.interactable = true;
        phone.interactable = true;
    }

    public void ResetBars()
    {
        //PlayerPrefs.SetInt("PlayerEnergy", 100);
        //PlayerPrefs.SetInt("PlayerMood", 100);
        StaticInfo.Energy = 100;
        StaticInfo.Mood = 100;
    }

    public void MapButton()
    {
        SceneManager.LoadScene("Map");
    }

    public void DIE()
    {
        
        AffectEnergy(-15);
        AffectMood(-50);
    }


    public void AffectEnergy(int energyChange)
    {
        energyCounter += energyChange;
        //PlayerPrefs.SetInt("PlayerEnergy", energyCounter);
        StaticInfo.Energy += energyChange;
        StartCoroutine(MoveEnergyBar());
    }

    public void AffectMood(int moodChange)
    {
        moodCounter += moodChange;
        //PlayerPrefs.SetInt("PlayerMood", moodCounter);
        StaticInfo.Mood += moodChange;
        StartCoroutine(MoveMoodBar());
    }
    
    IEnumerator MoveEnergyBar()
    {
        while (energyBar.value != energyCounter)
        {
            StaticInfo.IsCountingEnergy = true;
            energyBar.value = Mathf.MoveTowards(energyBar.value, energyCounter, barSpeed);
            yield return null;
        }
        StaticInfo.IsCountingEnergy = false;
    }

    IEnumerator MoveMoodBar()
    {
        while (moodBar.value != moodCounter)
        {
            StaticInfo.IsCountingMood = true;
            moodBar.value = Mathf.MoveTowards(moodBar.value, moodCounter, 1f);
            yield return null;
        }
        StaticInfo.IsCountingMood = false;
    }
}
