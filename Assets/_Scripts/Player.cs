using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region singleton
    
    public static Player instance { get; private set; }

    private void Awake() {
        instance = this;
    }

    #endregion

    public Transform head;

}
