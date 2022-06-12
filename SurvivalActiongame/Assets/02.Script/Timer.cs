using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text min;
    public Text sec;
    int IntegerMin = 0;
    float IntegerSec = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IntegerSec > 59.5)
        {
            IntegerSec = 0;
            IntegerMin++;
            min.text = IntegerMin.ToString("00");
        }
        IntegerSec += Time.deltaTime;
        Debug.Log(IntegerSec.ToString("00"));
        sec.text = IntegerSec.ToString("00");
    }
}
