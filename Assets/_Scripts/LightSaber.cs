using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : Weapon {
    
    private float damage = 1;
    
    private void OnTriggerEnter(Collider other) {
        ITakeDamage droid = other.GetComponent<ITakeDamage>();
        droid?.OnHit(damage);
    }

    public void OnHit(float damage) {
        
    }
    
}
