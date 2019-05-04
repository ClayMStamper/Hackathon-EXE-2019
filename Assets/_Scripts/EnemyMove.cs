using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float attackRange = 2f;
    
   //for shooting
    [SerializeField] private float fireRate = 1f;
    private float nextFire = 0.0f;
    
    private float distance;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = Player.instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();
        if (distance <= attackRange && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GetComponent<Enemy>().Shoot();
            GetComponent<Animator>().SetBool("Attacking", true);
            
        }

    }

    public void MoveTowardsPlayer()
    {
        
        transform.rotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        distance = Mathf.Abs(Vector3.Distance(transform.position, Player.instance.transform.position));
        if (distance >= attackRange)
        {

            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        

        //set x rotation 
        //Debug.Log(distance);
        //transform.localEulerAngles = new Vector3(-90, transform.localEulerAngles.y, transform.localEulerAngles.z);
        
    }

   

        
    
}
