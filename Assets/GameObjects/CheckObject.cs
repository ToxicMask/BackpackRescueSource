using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CheckObject : MonoBehaviour
{

    [SerializeField] ChangeScene changeScene;

    public string key = "flower";


    protected virtual void Start()
    {
        // Auto Get
        changeScene = GetComponent<ChangeScene>();
    }


    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {

        ICanBeChecked checkedObject = collision.transform.GetComponent<ICanBeChecked>();

        if (checkedObject != null)
        {
            if (checkedObject.Check(key))
            {
                Debug.LogWarning("End Game");
                if (changeScene != null) changeScene.ToStartMenu();
            }
        }
    }
}
