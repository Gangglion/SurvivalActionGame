using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyController : MonoBehaviour
{   
    [SerializeField] Collider[] col;
    [SerializeField] float radius;
    [SerializeField] LayerMask layer;
    [SerializeField] Transform target;
    public float eHp,eAttack,eExp,eSpeed;

    // Start is called before the first frame update
    void Start()
    {
        SetStatus();
        InvokeRepeating("findplayer", 0, 0.5f); // 0.5초마다 findplayer 함수 실행
    }

    // Update is called once per frame
    void Update() // 좀비가 한마리 이상 있을때 Player가 있는 위치로 이동 한다.
    {
        if(col.Length > 0)
        {
            Quaternion dir = Quaternion.LookRotation(target.position - transform.position);

            Vector3 angle = Quaternion.RotateTowards(transform.rotation, dir, 200 * Time.deltaTime).eulerAngles;

            transform.rotation = Quaternion.Euler(0, angle.y, 0);

            transform.Translate(Vector3.forward * Time.deltaTime * EnemyStatus.ESpeed);
        }
    }
    // 좀비 피격 - 총알에 맞았을때
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "bullet")
        {
            Hit();
        }
    }
    // 좀비 공격 - 플레이어를 때렸을때(플레이어 오브젝트와 닿았을 때)
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().PlayerHit(eAttack);
        }
    }
    void findplayer() // 생성된 좀비를 기준으로 radius안에 Player가 있을경우 Player를 찾는다. 
    {
        col = Physics.OverlapSphere(transform.position, radius, layer);
        Transform t_col = null;

        if(col.Length > 0)
        {
            t_col = col[0].transform;
        }

        target = t_col;
    }
    // 좀비 종류마다 스텟이 다르기 때문에 변수를 생성하여 담아줌
    void SetStatus()
    {
        switch(this.gameObject.tag)
        {
            case "S":
            {
                eHp = EnemyStatus.EHp[0];
                eSpeed = EnemyStatus.ESpeed;
                eAttack = EnemyStatus.EAttack[0];
                eExp = EnemyStatus.EExp[0];
                break;
            }
            case "M":
            {
                eHp = EnemyStatus.EHp[1];
                eSpeed = EnemyStatus.ESpeed;
                eAttack = EnemyStatus.EAttack[1];
                eExp = EnemyStatus.EExp[1];
                break;
            }
            case "L":
            {
                eHp = EnemyStatus.EHp[2];
                eSpeed = EnemyStatus.ESpeed;
                eAttack = EnemyStatus.EAttack[2];
                eExp = EnemyStatus.EExp[2];
                break;
            }
        }
        Debug.Log("좀비 종류 : "+this.gameObject.tag+" 좀비 체력 : "+eHp+" 좀비 공격력 : "+eAttack+"좀비 속도 : "+eSpeed + "좀비 경험치 : "+eExp);
    }
    // 좀비 피격 함수
    void Hit(){
        if(eHp <=0)
        {
            Destroy(this.gameObject);
            GameObject.Find("PlayerCharacter").GetComponent<Player>().ExpUp(eExp);
        }
        else
        {
            eHp-=PlayerStatus.PAttack;
            // Debug.Log("현재 좀비 체력 : "+eHp);
        }
    }
}
