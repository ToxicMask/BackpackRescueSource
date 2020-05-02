using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour, ICanHold
{
    public Transform actionPivot;

    public Transform pickedObjectPosition;

    public ICanBePicked currentPicked;


    void Start(){}

    void Update() { }


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

            Collider2D[] hitInfo = Physics2D.OverlapCircleAll(actionPivot.position, .5f);


            foreach (Collider2D collisionObj in hitInfo)
            {

                ICanBePicked pickableObject = collisionObj.GetComponent<ICanBePicked>();

                if (pickableObject != null)
                {
                    //Debug.Log("!");
                    //Debug.Log(pickableObject.PickObject().name);

                    Hold(pickableObject);
                }
            }

        }
    }

    public void Hold(ICanBePicked picked)
    {
        Debug.Log("Hold :  " + picked.PickObject().name );
        currentPicked = picked;

    }

    public void Release()
    {
        Debug.Log("Release");
        currentPicked = null;
    }
}
