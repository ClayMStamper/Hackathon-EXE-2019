using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    private Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
    }

    private void Update() {
        if (Input.GetMouseButton(0)) {
            anim.SetTrigger("Attack");
        }
            
    }
}
