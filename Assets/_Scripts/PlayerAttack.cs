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
        if (Input.GetMouseButton(0)) {
            anim.SetTrigger("Attack");
        }
            
    }
}
