using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    private float health;
    public float defaultHealth;

    private void Start()
    {
        health = defaultHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    public void TakeDame(float damage)
    {
        if (health < 0)
            return;
        health -= damage;
        if (health < 0) 
            Die();
    }

    protected virtual void Die()
    {
        var explosionEnemy = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosionEnemy, 1);
        Destroy(gameObject);
    }
}


