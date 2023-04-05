using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New CardData", menuName = "Cards", order = 51)]
public class CardData : ScriptableObject
{

    [SerializeField]
    private CardBattle cardBattle;
    [SerializeField]
    private List<CardDeck> subCards;
    [SerializeField]
    private typeOfCard type;
    [SerializeField]
    private Sprite icon;

    public List<CardDeck> getSubCards()
    {
        return subCards;
    }
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



}
