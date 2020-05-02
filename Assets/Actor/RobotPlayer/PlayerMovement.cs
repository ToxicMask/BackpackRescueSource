using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;


    // Input Varaibles
    [SerializeField] Vector2 walkDirection = Vector2.zero;
    [SerializeField] float walkSpeed = 1;

    public Vector2 fowardDirection = Vector2.right;

   

    // Standard Methods
    void Start()
    {
        // Auto Get Components        
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    { 
        // Walk
        rb2D.velocity = (walkDirection * walkSpeed * Time.fixedDeltaTime);
        
    }

    public void SetWalkDirection(Vector2 newVector)
    {
        //Debug.Log("ALERT: WALKING");
        walkDirection = newVector;

        if (newVector != Vector2.zero )fowardDirection = newVector.normalized;
    }
}
