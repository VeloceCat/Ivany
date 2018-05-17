using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticInfo {

    //Kaartje
    private static string nextScene = "Map";

    //Stats
    private static int energy = 100;
    private static int mood = 100;

    //School
    private static int dayCounter = 1;
    private static int daysPresent = 0;
    private static int chanceToSucceed = 10;
    private static int moneyReward = 0;
    private static bool getReward = false;

    //money
    private static int money = 0;

    //Items
    private static bool hasPhone = false;
    private static bool hasGame = false;
    private static bool hasBook = false;
    private static bool hasGoggles = false;

    private static bool menuInteractable = false;

    private static bool isCountingMood = false;
    private static bool isCountingEnergy = false;

    private static bool canTalkToParents = true;

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

    public static int Energy
    {
        get
        {
            return energy;
        }
        set
        {
            energy = value;
        }
    }

    public static int Mood
    {
        get
        {
            return mood;
        }
        set
        {
            mood = value;
        }
    }

    public static int DayCounter
    {
        get
        {
            return dayCounter;
        }
        set
        {
            dayCounter = value;
        }
    }

    public static int DaysPresent
    {
        get
        {
            return daysPresent;
        }
        set
        {
            daysPresent = value;
        }
    }

    public static int ChanceToSucceed
    {
        get
        {
            return chanceToSucceed;
        }
        set
        {
            chanceToSucceed = value;
        }
    }

    public static int MoneyReward
    {
        get
        {
            return moneyReward;
        }
        set
        {
            moneyReward = value;
        }
    }

    public static bool GetReward
    {
        get
        {
            return getReward;
        }
        set
        {
            getReward = value;
        }
    }

    public static int Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
        }
    }

    public static bool HasPhone
    {
        get
        {
            return hasPhone;
        }
        set
        {
            hasPhone = value;
        }
    }

    public static bool HasGame
    {
        get
        {
            return hasGame;
        }
        set
        {
            hasGame = value;
        }
    }

    public static bool HasBook
    {
        get
        {
            return hasBook;
        }
        set
        {
            hasBook = value;
        }
    }

    public static bool HasGoggles
    {
        get
        {
            return hasGoggles;
        }
        set
        {
            hasGoggles = value;
        }
    }

    public static bool MenuInteractable
    {
        get
        {
            return menuInteractable;
        }
        set
        {
            menuInteractable = value;
        }
    }

    public static bool IsCountingMood
    {
        get
        {
            return isCountingMood;
        }
        set
        {
            isCountingMood = value;
        }
    }
    public static bool IsCountingEnergy
    {
        get
        {
            return isCountingEnergy;
        }
        set
        {
            isCountingEnergy = value;
        }
    }

    public static bool CanTalkToParents
    {
        get
        {
            return canTalkToParents;
        }
        set
        {
            canTalkToParents = value;
        }
    }
}
