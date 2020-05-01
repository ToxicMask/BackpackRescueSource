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

        if (Input.GetButtonDown("Action1"))
        {
            // Try to Pick Object
            if (playerMove != null) playerAction.Try2PickObject();

           return;
        }


        // Input
        Vector2 walkDirection = new Vector2( Input.GetAxis("Horizontal"), 0 );

        if (playerMove != null) playerMove.SetWalkDirection(walkDirection);
        
    }
}
