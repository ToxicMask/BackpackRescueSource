using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICanHold
{
    void Hold(ICanBePicked pickeableObject);

    void Release();
}
