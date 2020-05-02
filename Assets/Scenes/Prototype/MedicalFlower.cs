using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicalFlower : PickableBody, ICanBeChecked
{

    string keyValue = "flower";

    public bool Check(string key)
    {
        bool result = ( key == keyValue );

        return result;
    }

}
