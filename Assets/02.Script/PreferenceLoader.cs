using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreferenceLoader : MonoBehaviour
{
    public Button timer;
    public AudioSource bgmSource;
    public AudioSource effSource;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("배경음악 크기 : " + GamePreferences.BackgroundVol.ToString());
        // Debug.Log("효과음 크기 : " + GamePreferences.EffectVol.ToString());
        // Debug.Log("화면 해상도 : " + GamePreferences.InterfaceSize);
        // Debug.Log("타이머 크기 : " + GamePreferences.TimerSize);
        bgmSource.volume = GamePreferences.BackgroundVol / 100;
        effSource.volume = GamePreferences.EffectVol / 100;
        switch (GamePreferences.InterfaceSize)
        {
            case "S":
                Screen.SetResolution(640,320,true);
                break;
            case "M":
                Screen.SetResolution(1280,720,true);
                break;
            case "L":
                Screen.SetResolution(1980,1080,true);
                break;
        }
        switch (GamePreferences.TimerSize)
        {
            case "S":
                timer.transform.localScale = new Vector3(1, 1, 1);
                break;
            case "M":
                timer.transform.localScale = new Vector3(3, 3, 3);
                break;
            case "L":
                timer.transform.localScale = new Vector3(5, 5, 5);
                break;
        }
    }
}
