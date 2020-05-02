using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class CheckObject : MonoBehaviour
{

    public string key = "flower";

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("#");

        ICanBeChecked checkedObject = collision.transform.GetComponent<ICanBeChecked>();

        if (checkedObject != null)
        {
            if (checkedObject.Check(key))
            {
                Debug.LogWarning("End Game");
                //SceneManager.LoadScene();
            }
        }
    }
}
