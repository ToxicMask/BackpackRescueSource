using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] PlayerMovement playerMove;
    
    void Start()
    {
        // Auto Get

        playerMove = GetComponent<PlayerMovement>();
    }
    
    void Update()
    {

        // Input
        Vector2 walkDirection = new Vector2( Input.GetAxis("Horizontal"), 0 );

        if (playerMove != null) playerMove.SetWalkDirection(walkDirection);
        
    }
}
