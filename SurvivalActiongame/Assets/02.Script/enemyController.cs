using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{   
    [SerializeField] Collider[] col;
    [SerializeField] float radius;
    [SerializeField] LayerMask layer;
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {
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

            transform.Translate(Vector3.forward * Time.deltaTime);
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
}
