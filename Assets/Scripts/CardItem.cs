using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardItem : MonoBehaviour,ICollectable
{
    public int id;
    [SerializeField]
    private type type;
    [SerializeField]
    private CardData cardData;

    
    public type GetObjectType()
    {
        return type;
    }
    public CardData GetCardData()
    {
        return cardData;
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
