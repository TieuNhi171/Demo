using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDame(damage);
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        var nPos = transform.position;
        nPos.y += flySpeed * Time.deltaTime;
        transform.position = nPos;
    }
}
