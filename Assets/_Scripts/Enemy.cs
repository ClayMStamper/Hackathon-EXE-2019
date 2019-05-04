using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform barrel;

    public Transform body;
    
   public void Shoot() {
       GameObject shot = Instantiate(bullet, barrel.position, barrel.rotation);
       shot.GetComponent<Bullet>().myDroid = transform;
       Destroy(shot, 10);
   }
    
   
    
}
