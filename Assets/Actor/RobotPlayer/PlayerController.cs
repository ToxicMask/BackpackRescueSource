using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] PlayerMovement playerMove;
    [SerializeField] PlayerAction playerAction;
    
    void Start()
    {
        // Auto Get
        playerMove = GetComponent<PlayerMovement>();
        playerAction = GetComponent<PlayerAction>();
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
        
    }
}
