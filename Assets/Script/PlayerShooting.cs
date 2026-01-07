using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet;
    public float delayBulletTime;
    private float lastBulletTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time -  lastBulletTime > delayBulletTime)
            {
                Shooting();
                lastBulletTime = Time.time;
            }
        }
    }

    private void Shooting()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
