using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class Game_page_click : MonoBehaviour
{
    public Slider bgmVol;
    public Slider effVol;
    public Toggle interfaceS;
    public Toggle interfaceM;
    public Toggle interfaceL;

    public Toggle timerS;
    public Toggle timerM;
    public Toggle timerL;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "01-2.GameSetting")
        {
            bgmVol.onValueChanged.AddListener(SetBgmVol);
            effVol.onValueChanged.AddListener(SetEffVol);
            
            if(interfaceS.isOn)GamePreferences.InterfaceSize="S";
            else if(interfaceM.isOn)GamePreferences.InterfaceSize="M";
            else GamePreferences.InterfaceSize="L";

            if(timerS.isOn)GamePreferences.TimerSize="S";
            else if(timerM.isOn)GamePreferences.TimerSize="M";
            else GamePreferences.TimerSize="L";
        }

    }
    public void scenchange()
    {
        SceneManager.LoadScene("01-2.GameSetting");
    }

    public void page_back()
    {
        SceneManager.LoadScene("01-1.StartPage");
    }

    public void GameQuit()
    {
        Application.Quit();
    }
    public void scenchange_Again()
    {
        SceneManager.LoadScene("02-1.GameScene");
    }
    public void SetBgmVol(float value)
    {
        GamePreferences.BackgroundVol = (int)value;
        // Debug.Log("배경음악 크기" + GamePreferences.BackgroundVol.ToString());
    }
    public void SetEffVol(float value)
    {
        GamePreferences.EffectVol = (int)value;
        // Debug.Log("효과음 크기" + GamePreferences.EffectVol.ToString());
    }
}


