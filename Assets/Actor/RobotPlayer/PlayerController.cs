using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Componnets
    [SerializeField] PlayerAnimation playerAnim;
    [SerializeField] PlayerAction playerAction;
    [SerializeField] PlayerMovement playerMove;

    
    void Start()
    {
        // Auto Get
        playerAnim = GetComponent<PlayerAnimation>();
        playerAction = GetComponent<PlayerAction>();
        playerMove = GetComponent<PlayerMovement>();
    }
    
    void Update()
    {
        
        // Actions
        if (Input.GetButtonDown("Action1"))
        {
            // Try to Pick / Release Object
            if (playerAction != null)
            {
                playerAction.TryPickObject();
                return;
            }
        }

        else if (Input.GetButtonDown("Action2"))
        {
            // Try to Pick / Release Object
            if (playerAction != null)
            {
                playerAction.TryThrowingObject( playerMove.fowardDirection );
                return;
            }
        }

        // Input
        Vector2 walkDirection = new Vector2( Input.GetAxis("Horizontal"), 0 );

        // Set Walk Direction
        if (playerMove != null) playerMove.SetWalkDirection(walkDirection);
        if (playerAnim != null) playerAnim.UpdateMovementAnimation();
        
    }
}
