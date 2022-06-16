using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text min;
    public Text sec;
    public int IntegerMin = 0;
    public float IntegerSec = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IntegerSec > 10)
        {
            IntegerSec = 0;
            IntegerMin++;
            min.text = IntegerMin.ToString("00");
            Debug.Log("좀비 레벨업 함");
            for (int i = 0; i < EnemyStatus.EHp.Length; i++)
            {
                EnemyStatus.EHp[i] *= 1.5f;
            }
            EnemyStatus.ESpeed *= 1.3f;
            for (int i = 0; i < EnemyStatus.EAttack.Length; i++)
            {
                EnemyStatus.EAttack[i] *= 1.5f;
            }
            for (int i = 0; i < EnemyStatus.EExp.Length; i++)
            {
                EnemyStatus.EExp[i] *= 0.8f;
            }
        }
        IntegerSec += Time.deltaTime;
        sec.text = IntegerSec.ToString("00");
    }
}
