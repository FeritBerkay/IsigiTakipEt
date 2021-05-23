using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControl : MonoBehaviour
{
    private float bulletSpeed = 10f;
    private Vector3 bulletWayR;
    private float countBack;
    private float bulletLifeTime = 5f;
    void Start()
    {
       // bulletWayR = spiritPlayer_movement.bulletWayTransitionValue;
    }

    void FixedUpdate()
    {
        transform.position += bulletWayR * bulletSpeed * Time.deltaTime;
        DestroyBullet();
    }
    void DestroyBullet()
    {
        Destroy(this.gameObject, bulletLifeTime);
    }
}
