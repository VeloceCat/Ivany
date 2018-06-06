using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningController : MonoBehaviour {


    [SerializeField]
    protected GameObject startButton;
    [SerializeField]
    protected GameObject beginButton;
    [SerializeField]
    protected GameObject title;
    [SerializeField]
    protected GameObject introText;

    [SerializeField]
    protected Image fade;

    // Use this for initialization
    void Start () {
        startButton.SetActive(true);
        title.SetActive(true);
        beginButton.SetActive(false);
        introText.SetActive(false);

        fade.canvasRenderer.SetAlpha(0);
    }
	
	public void StartGame()
    {
        startButton.SetActive(false);
        title.SetActive(false);
        beginButton.SetActive(true);
        introText.SetActive(true);
    }

    public void BeginDay()
    {
        EnterFade();
        //SceneManager.LoadScene("Home");
    }

    public void EnterFade()
    {
        StartCoroutine(CrossFade());
    }

    IEnumerator CrossFade()
    {
        
        fade.enabled = true;
        fade.CrossFadeAlpha(1, 2.0f, false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Home");
    }
}
