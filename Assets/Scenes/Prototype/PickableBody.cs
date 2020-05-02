using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PickableBody : MonoBehaviour, ICanBePicked
{

    public GameObject PickObject()
    {
        return gameObject;
    }
}
