using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }
    private void Die()
    {
        var explosionEnemy = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosionEnemy, 1);
        Destroy(gameObject);
    }
}
