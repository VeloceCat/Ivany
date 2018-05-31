using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ChoiceScript : MonoBehaviour {

    [SerializeField]
    protected GameObject textBox;
    [SerializeField]
    protected GameObject choice01;
    [SerializeField]
    protected GameObject choice02;
    [SerializeField]
    protected GameObject choice03;
    [SerializeField]
    protected GameObject choice04;

    

    protected int choiceMade;

    protected bool endOfEvent;
    protected int numberOfOptions;

    protected int choiceTree;

    protected int chain;

    protected string narrativeText;

    // voor options -> eventueel array indien gemakkelijk te gebruiken
    protected string option01Text;
    protected string option02Text;
    protected string option03Text;
    protected string option04Text;

    


    // Use this for initialization
    void Start () {
        
        chain = 0;
        endOfEvent = false;
        StartDialogue();
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public virtual void StartDialogue()
    {

    }


    public void ChoiceOption01()
    {
        choiceMade = 1;
        choiceTree =chain + 1;
        Consequences(choiceTree);
        //Debug.Log(choiceTree);
    }

    public void ChoiceOption02()
    {
        choiceMade = 2;
        choiceTree = chain + 2;
        Consequences(choiceTree);
    }

    public void ChoiceOption03()
    {
        choiceMade = 3;
        choiceTree = chain + 3;
        Consequences(choiceTree);
    }

    public void ChoiceOption04()
    {
        if (!endOfEvent)
        {
            choiceMade = 4;
            choiceTree = chain + 4;
            Consequences(choiceTree);
        }
        else
        {
            // quit to next scene -> scene opvangen*********************************************************************************
            AfterDialogue();
        }
        
    }

    public virtual void StartTalking(int num)
    {

    }
    
    public void Consequences(int num)
    {
        // de chain houdt bij waar we juist zitten, altijd 4 voorzien om het makkelijk te houden (max keuzes is 4)
        chain += choiceMade * 4;

        StartTalking(num);
        
        

        textBox.GetComponentInChildren<Text>().text = narrativeText;

        // protocol voor aantal opties en exit maken (int numberOfOptions  en bool endOfEvent) 
        if (!endOfEvent)
        {
            switch (numberOfOptions)
            {
                case 1:
                    choice01.SetActive(true);
                    choice02.SetActive(false);
                    choice03.SetActive(false);
                    choice04.SetActive(false);
                    choice01.GetComponentInChildren<Text>().text = option01Text;
                    break;
                case 2:
                    choice01.SetActive(true);
                    choice02.SetActive(true);
                    choice03.SetActive(false);
                    choice04.SetActive(false);
                    choice01.GetComponentInChildren<Text>().text = option01Text;
                    choice02.GetComponentInChildren<Text>().text = option02Text;
                    break;
                case 3:
                    choice01.SetActive(true);
                    choice02.SetActive(true);
                    choice03.SetActive(true);
                    choice04.SetActive(false);
                    choice01.GetComponentInChildren<Text>().text = option01Text;
                    choice02.GetComponentInChildren<Text>().text = option02Text;
                    choice03.GetComponentInChildren<Text>().text = option03Text;
                    break;
                case 4:
                    choice01.SetActive(true);
                    choice02.SetActive(true);
                    choice03.SetActive(true);
                    choice04.SetActive(true);
                    choice01.GetComponentInChildren<Text>().text = option01Text;
                    choice02.GetComponentInChildren<Text>().text = option02Text;
                    choice03.GetComponentInChildren<Text>().text = option03Text;
                    choice04.GetComponentInChildren<Text>().text = option04Text;
                    break;
                default:
                    break;
            }
        }
        else
        {
            choice01.SetActive(false);
            choice02.SetActive(false);
            choice03.SetActive(false);
            choice04.SetActive(true);
            choice04.GetComponentInChildren<Text>().text = "Doorgaan...";
        }
        
        EventSystem.current.SetSelectedGameObject(null);
    }

    

    public virtual void AfterDialogue()
    {
        
    }

    public void ScoreCounter(int score)
    {
        StaticInfo.ScoresCounted++;
        StaticInfo.TotalScore += score;
    }
    
}
