using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour, ICanHold
{
    public Transform actionPivot;

    public Transform pickedObjectPosition;

    public ICanBePicked currentPicked;


    public void Try2PickObject()
    {
        //Debug.Log("Picked");

        // Release Current Picked Object
        if ( currentPicked != null )
        {
            Release();
            return;
        }


        else {

            Collider2D[] hitInfo = Physics2D.OverlapCircleAll(actionPivot.position, .6f);


            foreach (Collider2D collisionObj in hitInfo)
            {

                ICanBePicked pickableObject = collisionObj.GetComponent<ICanBePicked>();

                if (pickableObject != null)
                {
                    //Debug.Log("!");
                    //Debug.Log(pickableObject.PickObject().name);

                    Hold(pickableObject);

                    // Ends the loop
                    break;
                }
            }

        }
    }

    public void Hold(ICanBePicked picked)
    {
        //Debug.Log("Hold :  " + picked.PickObject().name );

        Transform pickTransform = picked.PickObject().transform;
        Rigidbody2D pickRB2D = picked.PickObject().GetComponent<Rigidbody2D>();

        // Transform
        pickTransform.position = pickedObjectPosition.position;
        pickTransform.rotation = pickedObjectPosition.rotation;
        pickTransform.SetParent(pickedObjectPosition);

        // RigidBody
        pickRB2D.isKinematic = true;


        currentPicked = picked;

    }

    public void Release()
    {
        //Debug.Log("Release");

        Transform pickTransform = currentPicked.PickObject().transform;
        Rigidbody2D pickRB2D = currentPicked.PickObject().GetComponent<Rigidbody2D>();

        //Transform
        pickTransform.SetParent(null);

        // RigidBody
        pickRB2D.isKinematic = false;

        currentPicked = null;
    }
}
