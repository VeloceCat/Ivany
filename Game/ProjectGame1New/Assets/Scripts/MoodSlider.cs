using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodSlider : MonoBehaviour {

    [SerializeField]
    protected Image headImageComponent;
    [SerializeField]
    protected Image faceImageComponent;

    [SerializeField]
    protected Slider slider;

    [SerializeField]
    protected Sprite greenHead;
    [SerializeField]
    protected Sprite redHead;
    [SerializeField]
    protected Sprite yellowHead;
    [SerializeField]
    protected Sprite happyFace;
    [SerializeField]
    protected Sprite sadFace;
    [SerializeField]
    protected Sprite neutralFace;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        slider.value = StaticInfo.SliderCount;

        if (StaticInfo.SliderCount < 0)
        {
            SadFace();
        }
        else if (StaticInfo.SliderCount > 0)
        {
            HappyFace();
        }
        else
        {
            NeutralFace();
        }

	}


    public void HappyFace() //method to set our first image
    {
        headImageComponent.sprite = greenHead;
        faceImageComponent.sprite = happyFace;
    }

    public void SadFace()
    {
        headImageComponent.sprite = redHead;
        faceImageComponent.sprite = sadFace;
    }

    public void NeutralFace()
    {
        headImageComponent.sprite = yellowHead;
        faceImageComponent.sprite = neutralFace;
    }
}
