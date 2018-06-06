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
    private static int totalScore = 0;

    private static int scoresCounted = 0;


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

    public static int TotalScore
    {
        get
        {
            return totalScore;
        }
        set
        {
            totalScore = value;
        }
    }

    public static int ScoresCounted
    {
        get
        {
            return scoresCounted;
        }
        set
        {
            scoresCounted = value;
        }
    }

}
