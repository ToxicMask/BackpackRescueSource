using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;


    // Input VAraibles
    [SerializeField] Vector2 walkDirection = Vector2.zero;
    [SerializeField] float walkSpeed = 1;

   

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
    }
}
