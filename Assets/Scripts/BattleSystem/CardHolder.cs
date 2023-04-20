using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardHolder : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI attack, hp, cost,description, nameCard;
    [SerializeField]
    private Image cardImage;
    
    public void SetAttack(TextMeshProUGUI attack)
    {
        this.attack = attack;
    }
    public void SetHp(TextMeshProUGUI hp) 
    {
        this.hp = hp;
    }
    public void SetCost(TextMeshProUGUI cost) 
    {
        this.cost = cost;
    }
    public void SetDescription(TextMeshProUGUI description) 
    {
        this.description = description;
    }
    public void SetNameCard(TextMeshProUGUI nameCard)
    {
        this.nameCard = nameCard;
    }
    public void SetCardImage(Image cardImage) 
    {
        this.cardImage = cardImage;
    }
}
