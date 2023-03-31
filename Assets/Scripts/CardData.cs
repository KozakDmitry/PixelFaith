using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New CardData", menuName = "Cards", order = 51)]
public class CardData : ScriptableObject
{

    [SerializeField]
    private int hp;
    [SerializeField]
    private int attackDamage;
    [SerializeField]
    private int defense;
    [SerializeField]
    private List<CardItem> subCards;
    [SerializeField]
    private typeOfCard type;
    [SerializeField]
    private Sprite icon;
    //[SerializeField]
    //private CardItem[] cards;

    public typeOfCard Type
    {
        get
        {
            return type;
        }
    }
    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }

    //public CardItem[] Cards
    //{
    //    get
    //    {
    //        return cards;
    //    }
    //}

}
