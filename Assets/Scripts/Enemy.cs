using MilkShake;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 90;
    public GameObject enemyDeathParticles;
    public Shaker MyShaker;
    public ShakePreset ShakePreset;
    public void TakeDamage(int Damage)
    {
        health -= Damage;
        if (health <= 0)
        {
            Die();
        }

    }
    void Die()
    {
        MyShaker.Shake(ShakePreset);
        Instantiate(enemyDeathParticles, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
