using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectable 
{
    bool Collect();
    AdviceTypes InInteract();
    void OutInteract();
}
