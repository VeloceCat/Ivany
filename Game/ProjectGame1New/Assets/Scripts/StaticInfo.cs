using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticInfo {

    //Volgorde
    private static string nextScene = "Home";

    private static bool shopNotPool;

    private static int randomEventNbr;


    // HomeStart or HomeEnd
    private static bool isHomeStart = true;
    
    private static bool afterClass = false;


    // Scoreteller
    private static int sliderCount = 0;



    //*****************************************************
    public static string NextScene
    {
        get
        {
            return nextScene;
        }
        set
        {
            nextScene = value;
        }
    }

    public static bool ShopNotPool
    {
        get
        {
            return shopNotPool;
        }
        set
        {
            shopNotPool = value;
        }
    }

    public static int SliderCount
    {
        get
        {
            return sliderCount;
        }
        set
        {
            sliderCount = value;
        }
    }

    public static int RandomEventNbr
    {
        get
        {
            return randomEventNbr;
        }
        set
        {
            randomEventNbr = value;
        }
    }

    public static bool IsHomeStart
    {
        get
        {
            return isHomeStart;
        }
        set
        {
            isHomeStart = value;
        }
    }

    public static bool AfterClass
    {
        get
        {
            return afterClass;
        }
        set
        {
            afterClass = value;
        }
    }


}
