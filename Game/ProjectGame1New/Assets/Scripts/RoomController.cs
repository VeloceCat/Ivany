using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomController : MonoBehaviour {

    [SerializeField]
    protected Home_Start homeStart;

    [SerializeField]
    protected Home_End homeEnd;

    [SerializeField]
    protected Image fade;

    // Use this for initialization
    void Start () {

        if (StaticInfo.IsHomeStart)
        {
            homeStart.StartDialogue();
        }
        else
        {
            homeEnd.StartDialogue();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
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
