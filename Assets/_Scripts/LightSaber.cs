using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : Weapon {
    
    private float damage = 1;
    
    private void OnTriggerEnter(Collider other) {
        ITakeDamage droid = other.GetComponent<ITakeDamage>();
        if (droid is EnemyHealth)
            droid?.OnHit(damage);
        
        if (other.GetComponent<Bullet>())
            Destroy(other.gameObject);
        
    }

    public void OnHit(float damage) {
        
    }

}
