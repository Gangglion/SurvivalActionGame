using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 작성자 : 김진렬
public class enemy : MonoBehaviour
{


   [Header("적생성")]
   [SerializeField] GameObject WeekZombie; // WeekZombie 오브젝트
   [SerializeField] GameObject MidZombie; // MidZombie 오브젝트
   [SerializeField] GameObject StrongZombie; // StrongZombie 오브젝트

   [SerializeField] Transform[] createEnemy1; // 좀비를 담을 리스트
   [SerializeField] Transform[] createEnemy2;
   [SerializeField] Transform[] createEnemy3;

   [SerializeField] float WeekZombie_create_time; // 좀비를 몇초마다 생성할 것인지 => Stage 오브젝트에서 설정가능함
   [SerializeField] float MidZombie_create_time;
   [SerializeField] float StrongZombie_create_time;

    private void Awake()
    {
        
    }

    void Start()
    {
        InvokeRepeating("weekZombie_create", 0, WeekZombie_create_time); // create_time 마다 create함수 실행
        InvokeRepeating("midZombie_create", 0, MidZombie_create_time);
        InvokeRepeating("strongZombie_create", 0, StrongZombie_create_time);

    }

    
    void Update()
    {
        
    }


    void weekZombie_create()
    {
        int i = Random.Range(0, 6); // 0~5 랜덤값 생성

        Instantiate(WeekZombie, createEnemy1[i].position, createEnemy1[i].rotation);
    }

    void midZombie_create()
    {
        int j = Random.Range(0, 4); 

        Instantiate(MidZombie, createEnemy2[j].position, createEnemy2[j].rotation);
    }

    void strongZombie_create()
    {
        int k = Random.Range(0, 2); 

        Instantiate(StrongZombie, createEnemy3[k].position, createEnemy3[k].rotation);
    }
}
