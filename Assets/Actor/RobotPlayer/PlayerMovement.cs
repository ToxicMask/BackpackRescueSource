using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;

    public Transform groundRaycastPivot;

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

        // Set Ground
        GroundDetect();
    }

    public void SetWalkDirection(Vector2 newVector)
    {
        //Debug.Log("ALERT: WALKING");
        walkDirection = newVector;

        if (newVector != Vector2.zero )fowardDirection = newVector.normalized;
    }

    public void GroundDetect()
    {
        // End Function
        if (groundRaycastPivot == null) return;


        int targetLayer = 1 << LayerMask.NameToLayer("Default"); // Default

        float lenght = Mathf.Abs(groundRaycastPivot.localPosition.y);

        RaycastHit2D hitInfo = Physics2D.Raycast(groundRaycastPivot.position, Vector2.down, lenght, targetLayer);
        Debug.DrawRay(groundRaycastPivot.position, Vector2.down * lenght, Color.green, 0.05f);

        // Is in ground
        if (hitInfo.collider != null)
        {
            //Debug.Log(hitInfo.collider);

            // Adjust Height
            if (transform.position.y < hitInfo.point.y) transform.position = hitInfo.point;

            // Eliminate Fall
            rb2D.velocity = new Vector2( rb2D.velocity.x , 0); 

        }
    }
}
