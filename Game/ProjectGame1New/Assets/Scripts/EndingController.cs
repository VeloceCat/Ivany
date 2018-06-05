using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingController : MonoBehaviour {

    [SerializeField]
    protected GameObject reStartButton;
    [SerializeField]
    protected GameObject continueButton;
    [SerializeField]
    protected GameObject resultText;
    [SerializeField]
    protected GameObject endText;

    [SerializeField]
    protected Image fade;

    // Use this for initialization
    void Start () {
        StartCoroutine(CrossFadeIn());
        continueButton.SetActive(true);
        resultText.SetActive(true);
        reStartButton.SetActive(false);
        endText.SetActive(false);

        int score;

        if (StaticInfo.ScoresCounted < 1)
        {
            score = 2;
        }
        else
        {
            score = StaticInfo.TotalScore / StaticInfo.ScoresCounted;
        }
        
        switch (score)
        {
            case 1:
                resultText.GetComponent<Text>().text = "Je zal tijdens het spelen regelmatig een rode achtergrond gezien hebben achter de tekst. Dit betekent dat je vooral ‘slechte’ keuzes hebt gemaakt tijdens het spel.\nEr zijn een aantal dingen die je zelf kan doen als slachtoffer of als iemand naar jou komt die zelf slachtoffer is die jou of de ander erg kunnen helpen. De belangrijkste daarvan is praten, zelf iemand vinden om mee te kunnen praten of klaarstaan om te luisteren is vaak de eerste stap in het verwerken en hulp zoeken.\nDaarnaast kan wat voorzichtig zijn heel wat slechte situaties voorkomen.";
                break;
            case 2:
                resultText.GetComponent<Text>().text = "Je zal tijdens het spelen van de game regelmatig rode of groene achtergronden hebben gezien. Dit betekent dat je zowel ‘goede’ als ‘slechte’ keuzes hebt gemaakt. Je zal dus een aantal situaties goed hebben aangepakt en een aantal slecht. Dan ben je al op de goede weg om slachtoffers van seksuele intimidatie goed op te vangen of zou je de juiste keuzes maken als je zelf slachtoffer bent.";
                break;
            case 3:
                resultText.GetComponent<Text>().text = "Je zal tijdens het spelen regelmatig een groene achtergrond gezien hebben achter de tekst. Dit betekent dat je vooral ‘goede’ keuzes hebt gemaakt tijdens het spel. Super! Je weet hoe je moet omgaan met mogelijk gevaarlijke situaties en je weet hoe je moet reageren als er iemand jou om hulp vraagt. Je bent iemand waar slachtoffers bij terug zouden kunnen en je weet je als slachtoffer er niet alleen voor staat.";
                break;
            default:
                break;
        }


    }

    public void Restart()
    {
        StaticInfo.TotalScore = 0;
        StaticInfo.ScoresCounted = 0;
        EnterFade();
        //SceneManager.LoadScene("Home");
    }

    public void Continue()
    {
        continueButton.SetActive(false);
        resultText.SetActive(false);
        reStartButton.SetActive(true);
        endText.SetActive(true);
    }

    public void EnterFade()
    {
        StartCoroutine(CrossFadeOut());
    }

    IEnumerator CrossFadeOut()
    {
        fade.canvasRenderer.SetAlpha(0);
        fade.enabled = true;
        fade.CrossFadeAlpha(1, 2.0f, false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Home");
    }

    IEnumerator CrossFadeIn()
    {
        fade.canvasRenderer.SetAlpha(1);
        fade.enabled = true;

        fade.CrossFadeAlpha(0, 2.0f, false);
        yield return new WaitForSeconds(2);
        fade.enabled = false;
    }
}
