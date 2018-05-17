using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SchoolController : MonoBehaviour {

    [SerializeField]
    protected Friends_Events friendEvent;

    [SerializeField]
    protected GameObject buttonGroup;

    // Use this for initialization
    void Start()
    {

        friendEvent.AfterDialogue();
        

        
    }

    // Update is called once per frame
    void Update()
    {

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

    public void TalkToFriends()
    {
        friendEvent.enabled = true;
        DisableRoom();
        friendEvent.StartDialogue();
    }

    public void EnterClassroom()
    {
        SceneManager.LoadScene("Classroom");
    }
}
