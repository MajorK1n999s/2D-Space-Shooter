using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Movement : MonoBehaviour
{
    public Transform bullet;
    public float bulletSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
        if (bullet.transform.position.y > 6.5f)
        {
            Destroy(gameObject);
        }
    }

    void BulletMove()
    {
        bullet.position += new Vector3(0f, bulletSpeed * Time.deltaTime, 0f);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Astroid")
        {
            Destroy(gameObject);
        }
    }

}
