using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
 
    
    void Start()
    {
        
    }

   public void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    
   
    
}
