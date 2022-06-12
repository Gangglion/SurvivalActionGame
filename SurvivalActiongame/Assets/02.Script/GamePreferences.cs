using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class GamePreferences{
    private static int backgroundVol = 50;
    public static int BackgroundVol{
        get{
            return backgroundVol;
        }
        set{
            backgroundVol = value;
        }
    }
    private static int effectVol = 50;
    public static int EffectVol{
        get{
            return effectVol;
        }
        set{
            effectVol = value;
        }
    }
    private static string interfaceSize = "mid";
    public static string InterfaceSize{
        get{
            return interfaceSize;
        }
        set{
            interfaceSize = value;
        }
    }
    private static string timerSize = "mid";
    public static string TimerSize{
        get{
            return timerSize;
        }
        set{
            timerSize = value;
        }
    }
}
