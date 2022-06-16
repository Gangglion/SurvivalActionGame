using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    RaycastHit hit;
    public GameObject bullet;
    public GameObject bulletPos;
    float maxDistance = 3f;
    float bulletSpeed = 1000f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(transform.position, transform.forward * maxDistance, Color.red);
            GameObject myBullet = Instantiate(bullet,bulletPos.transform.position,bullet.transform.rotation);
            myBullet.GetComponent<Rigidbody>().AddForce(bulletPos.transform.forward * bulletSpeed);
        }
    }
}
