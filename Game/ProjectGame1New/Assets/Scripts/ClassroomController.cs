using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassroomController : MonoBehaviour {

    [SerializeField]
    protected School_Classroom schoolEvent;

    
    // Use this for initialization
    void Start () {
        StaticInfo.AfterClass = true;
        schoolEvent.StartDialogue();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
