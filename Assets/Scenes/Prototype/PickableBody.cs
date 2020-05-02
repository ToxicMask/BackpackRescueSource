using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PickableBody : MonoBehaviour, ICanBePicked
{

    [SerializeField] bool isPicked;



    public GameObject PickObject()
    {
        return gameObject;
    }


    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
