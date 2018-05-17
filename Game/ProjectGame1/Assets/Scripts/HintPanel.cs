using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintPanel : MonoBehaviour {


    [SerializeField]
    protected GameObject panel;
    [SerializeField]
    protected GameObject[] panelChildren;
    [SerializeField]
    protected GameObject txt;

    [SerializeField]
    protected int setX;

    protected bool boxIsOpen = false;
    
    RectTransform panelRectTransform;
    //GameObject[] panelChildren;
    // Use this for initialization
    void Start () {
        panelRectTransform = panel.GetComponent<RectTransform>();
        
        panelRectTransform.sizeDelta = new Vector2(0, 0);
        foreach (GameObject x in panelChildren)
        {
            x.SetActive(false);
        }

        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ActivateHintPanel(string newText)
    {
        txt.GetComponent<Text>().text = "";
        StartCoroutine(OpenBox(newText));
    }

    public void CloseHintPanel()
    {
        StartCoroutine(CloseBox());
    }

    IEnumerator OpenBox(string newText)
    {
        if (!boxIsOpen)
        {
            yield return new WaitForSeconds(0.01f);
            int newX = 0;
            boxIsOpen = true;
            while (newX < setX)
            {
                newX += 1;
                panelRectTransform.sizeDelta = new Vector2(panelRectTransform.sizeDelta.x + 28, panelRectTransform.sizeDelta.y + 8);
                yield return null;
                //yield return new WaitForSeconds(0.00001f);
            }

            foreach (GameObject x in panelChildren)
            {
                x.SetActive(true);

            }
            foreach (char letter in newText)
            {
                txt.GetComponent<Text>().text += letter;
                yield return null;
            }
        }
        
        

        yield return null;
    }

    IEnumerator CloseBox()
    {
        //yield return new WaitForSeconds(1);
        int newX = 0;
        boxIsOpen = false;
        foreach (GameObject x in panelChildren)
        {
            x.SetActive(false);
        }

        while (newX < setX)
        {
            newX += 1;
            panelRectTransform.sizeDelta = new Vector2(panelRectTransform.sizeDelta.x - 28, panelRectTransform.sizeDelta.y - 8);
            
            yield return new WaitForSeconds(0.00001f);
        }
        yield return null;
    }
}
