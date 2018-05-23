using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SchoolController : MonoBehaviour {

    [SerializeField]
    protected HintPanel hintPanel;

    [SerializeField]
    protected FriendEvent friendEvent;

    [SerializeField]
    protected HUDController hudControl;

    [SerializeField]
    protected Button door;

    [SerializeField]
    protected Button friends;

    // Use this for initialization
    void Start()
    {
        friends.interactable = true;
        friendEvent.AfterDialogue();
        if (StaticInfo.AfterClass)
        {
            door.interactable = false;
        }
        else
        {
            door.interactable = true;
        }

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisableRoom()
    {
        door.interactable = false;
    }

    public void EnableRoom()
    {
        door.interactable = true;
    }

    public void TalkToFriends()
    {
        if (StaticInfo.Energy >= 10)
        {
            friends.interactable = false;
            hudControl.AffectEnergy(-10);
            DisableRoom();
            friendEvent.enabled = true;
            friendEvent.StartDialogue();
        }
        else
        {
            hintPanel.ActivateHintPanel("Je hebt niet genoeg energie voor je vrienden.");
        }
        
    }

    public void EnterClassroom()
    {
        SceneManager.LoadScene("Classroom");
    }
}
