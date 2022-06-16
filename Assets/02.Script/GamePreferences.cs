using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class GamePreferences
{
    private static float backgroundVol = 50;
    private static float effectVol = 50;

    private static string interfaceSize = "M";
    private static string timerSize = "M";
    public static float BackgroundVol
    {
        get
        {
            return backgroundVol;
        }
        set
        {
            backgroundVol = value;
        }
    }
    public static float EffectVol
    {
        get
        {
            return effectVol;
        }
        set
        {
            effectVol = value;
        }
    }
    public static string InterfaceSize
    {
        get
        {
            return interfaceSize;
        }
        set
        {
            interfaceSize = value;
        }
    }
    public static string TimerSize
    {
        get
        {
            return timerSize;
        }
        set
        {
            timerSize = value;
        }
    }
}
