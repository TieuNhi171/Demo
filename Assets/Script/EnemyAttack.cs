using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using UnityEngine;

namespace Assets.Script
{
    internal class EnemyAttack : MonoBehaviour
    {
        public EnemyHealth enemyHealth;
        public float damage;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var player = collision.GetComponent<EnemyHealth>();
            if (player != null)
            {
                player.TakeDame(damage);
                enemyHealth.TakeDame(1000);
            }
        }
    }
}
