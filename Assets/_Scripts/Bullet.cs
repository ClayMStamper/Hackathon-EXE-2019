using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 2f;

    public Transform myDroid;
    private Transform target;
    
    private void Start() {
        target = Player.instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * bulletSpeed);
        transform.LookAt(target);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.transform.root.GetComponent<PlayerHealth>()) {
            other.transform.root.GetComponent<PlayerHealth>().OnHit(.3f);
            Destroy(gameObject);
        } else if (other.GetComponent<LightSaber>()) {
            Flip();
        }
    }

    public void Flip() {
        target = myDroid;
    }
}
