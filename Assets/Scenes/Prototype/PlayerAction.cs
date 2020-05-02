using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public Transform actionPivot;

    public Transform pickedObjectPosition;

    void Start()
    {
        
    }

    public void Try2PickObject()
    {
        //Debug.Log("Picked");


        Collider2D[] hitInfo = Physics2D.OverlapCircleAll( actionPivot.position , .5f);

        
        foreach (Collider2D collisionObj in hitInfo)
        {
            
            ICanBePicked pickableObject = collisionObj.GetComponent<ICanBePicked>();

            if (pickableObject != null)
            {
                //Debug.Log("!");
                Debug.Log(pickableObject.PickObject().name);
            }
        }
    }

}
