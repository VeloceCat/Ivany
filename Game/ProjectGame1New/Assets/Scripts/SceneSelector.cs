using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelector : MonoBehaviour {


    [SerializeField]
    protected string sceneToLoad;

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

    
}
