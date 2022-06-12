using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreferenceLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("배경음악 크기 : "+GamePreferences.BackgroundVol.ToString());
        Debug.Log("효과음 크기 : "+GamePreferences.EffectVol.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
