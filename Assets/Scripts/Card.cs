using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour,ICollectable
{
    [SerializeField]
    private type type;
    [SerializeField]
    private typeOfCard typyofcard;
    public type GetObjectType()
    {
        return type;
    }
    public GameObject Collect()
    {

        Destroy(this.gameObject,0.1f);
        return this.gameObject;
    }
    public AdviceTypes InInteract()
    {
        return AdviceTypes.Usial;
    }
    public void OutInteract()
    {

    }
}
