using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    float bulletSpeed = -.5f;
    float coolDown;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= coolDown)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }
        }
    }
    void Fire()
    {
        Rigidbody2D lPrefab = Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.rotation.z-1), gameObject.transform.rotation) as Rigidbody2D;
       
        lPrefab.GetComponent<Rigidbody2D>().AddForce(transform.right * 500);
        coolDown = Time.time + bulletSpeed;

    }
}