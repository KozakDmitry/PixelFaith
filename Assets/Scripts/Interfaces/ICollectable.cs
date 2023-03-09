using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectable 
{
    public type GetObjectType();
    GameObject Collect();
    AdviceTypes InInteract();
    void OutInteract();
}
