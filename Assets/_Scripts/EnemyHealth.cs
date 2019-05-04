using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, ITakeDamage
{
    [SerializeField] private float health = 1f;
    [SerializeField] private GameObject DestroyVFX; 
    
    
    public void OnHit(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Instantiate(DestroyVFX, transform.position, Quaternion.identity);
            Destroy(gameObject, 1.5f);
            //put death anim here
        }
    }
    
}
