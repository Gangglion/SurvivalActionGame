using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestroyBullet()
    {
        Destroy(this);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "S" || other.gameObject.tag == "M" || other.gameObject.tag == "L")
        {
            Destroy(this.gameObject);
        }
    }
}
