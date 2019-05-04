using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 2f;
    [SerializeField] private AudioClip blasterSound;

    public Transform myDroid;
    private Transform target;
    
    private void Start() {
        target = Player.instance.head;
        AudioSource.PlayClipAtPoint(blasterSound, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * bulletSpeed);
    }

    private void OnTriggerEnter(Collider other) {
        
        if (other.GetComponent<LightSaber>()) {
            Flip();
        }
        else if (other.transform.root.GetComponent<PlayerHealth>()) {
            other.transform.root.GetComponent<PlayerHealth>().OnHit(.3f);
            Destroy(gameObject);
        } 
        
    }

    public void Flip() {
        target = myDroid;
    }
}
