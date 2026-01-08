using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float delayBulletTime;
    public Vector3 bulletOffSet;

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
            BulletFiring();
        }
    }

    private void BulletFiring()
    {
        if (Time.time - lastBulletTime > delayBulletTime)
        {
            Shooting();
            lastBulletTime = Time.time;
        }
    }

    private void Shooting()
    {
        var bullet = Instantiate(bulletPrefab, transform.position + bulletOffSet, transform.rotation);
    }
}
