using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerAttack : MonoBehaviour {
    private Animator anim;

    [FormerlySerializedAs("col")] public Collider sabreCol;
    
    private void Start() {
        anim = GetComponent<Animator>();
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            anim.SetTrigger("Attack");
        } else if (Input.GetMouseButton(1)) {
            anim.SetBool("Blocking", true);
        }
        else {
            anim.SetBool("Blocking", false);
        }
            
    }
}
