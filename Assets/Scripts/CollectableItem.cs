using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour,ICollectable
{
    public bool Collect()
    {
        return true;
    }
    public AdviceTypes InInteract()
    {
        return AdviceTypes.Usial;
    }
    public void OutInteract()
    {

    }
}
