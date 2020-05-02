using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableBody : MonoBehaviour, ICanBePicked
{

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
