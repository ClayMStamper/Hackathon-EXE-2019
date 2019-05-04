using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform barrel;
 
    
   public void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    
   
    
}
