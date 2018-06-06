using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SchoolController : MonoBehaviour {

    
    [SerializeField]
    protected School_Before beforeSchool;

    [SerializeField]
    protected School_After afterSchool;

    // Use this for initialization
    void Start()
    {
        if (StaticInfo.AfterClass)
        {
            afterSchool.StartDialogue();
        }
        else
        {
            beforeSchool.StartDialogue();
        }

        
    }
}
