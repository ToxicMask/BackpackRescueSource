using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    [SerializeField] Animator animControl;


    void Start()
    {
        //Auto Get
        animControl = GetComponentInChildren<Animator>();
    }


    // Movement || Idle; Walk
    public void UpdateMovementAnimation() {

        //Debug.Log("Animation");

        // Return if null Animator
        if (animControl == null) return;

    }


}
