using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingController : MonoBehaviour {


    [SerializeField]
    protected ShoppingEvent shopEvent;

    // Use this for initialization
    void Start () {
        shopEvent.StartDialogue();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
