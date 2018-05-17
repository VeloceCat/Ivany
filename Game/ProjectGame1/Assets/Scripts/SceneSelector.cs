using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelector : MonoBehaviour {


    [SerializeField]
    protected string sceneToLoad;

    [SerializeField]
    protected HUDController hudControl;

    [SerializeField]
    protected HintPanel hintPanel;

    protected int rnd;
    protected bool rndEventActive;
    // Use this for initialization
    void Start()
    {
        rnd = Random.Range(1, 7);
        if (rnd == 1)
        {
            rndEventActive = true;
        }
        else
        {
            rndEventActive = false;
        }
    }


    public void GoToScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void GoToSchool()
    {
        if (StaticInfo.Energy >= 55)
        {
            hudControl.AffectEnergy(-55);
            if (!rndEventActive)
            {
                SceneManager.LoadScene("School");
            }
            else
            {
                StaticInfo.NextScene = "School";
                SceneManager.LoadScene("RandomEventScene");
            }
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg energie om naar school te gaan.");
        }
        
        
    }

    public void GoHome()
    {
        if (!rndEventActive)
        {
            SceneManager.LoadScene("Home");
        }
        else
        {
            StaticInfo.NextScene = "Home";
            SceneManager.LoadScene("RandomEventScene");
        }

    }

    public void GoShopping()
    {
        if (StaticInfo.Energy >= 25)
        {
            hudControl.AffectEnergy(-25);
            if (!rndEventActive)
            {
                SceneManager.LoadScene("Shopping");
            }
            else
            {
                StaticInfo.NextScene = "Shopping";
                SceneManager.LoadScene("RandomEventScene");
            }
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg energie om te gaan winkelen.");
        }
        

    }
}
