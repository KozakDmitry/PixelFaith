using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Inventory :MonoBehaviour
{
    private InventoryCell[] inventoryCapacity; 
    [SerializeField]
    private int countOfCells = 5;
    [SerializeField]
    private GameObject inventoryCell;
    [SerializeField]
    private GameObject inventoryScreen;
    public enum change
    {
        True,
        Change,
        False,
    }
    private void Start()
    {
        inventoryCapacity = new InventoryCell[15];
        
        for(int i = 0; i < countOfCells; i++)
        {
            Instantiate(inventoryCell, inventoryScreen.transform);
            inventoryCapacity[i] = new InventoryCell(i);
        }
    }
    public InventoryCell giveCell(int num)
    {
        return inventoryCapacity[num];
    }
    public void OpenCloseInventory(change change)
    {
        switch (change)
        {
            case change.True:
                inventoryScreen.SetActive(true);
                break;
            case change.False:
                inventoryScreen.SetActive(false);
                break;
            case change.Change:
                inventoryScreen.SetActive(!inventoryScreen.activeInHierarchy);
                break;
            default:
                break;
        }

    }
    private void Save()
    {

    }
}
