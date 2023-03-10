using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    private ICollectable iC;
    private bool Interacting=false;
    private RoomManager rm;
    [SerializeField]
    private AdviceManager adviceM;
    [SerializeField]
    private Transform playerCameraPosition;
    private Inventory inventory;
    private GameObject collectItem;
    void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        iC = collision.gameObject.GetComponent<ICollectable>();
        if (iC != null)
        {
            adviceM.SetActive(iC.InInteract(), true);
            Interacting = true;

        }
        else
        {
            adviceM.DisableAll();
        }
        
    }

    public void ChangeCameraPosition(Transform cameraPosition)
    {
        playerCameraPosition = cameraPosition;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(iC == collision.gameObject.GetComponent<ICollectable>())
        {
            Interacting = false;
            iC = null;
            adviceM.DisableAll();
        }
    }

    internal void CheckInteract()
    {
        if (Interacting)
        {
            if (inventory.IsHasFreeCells())
            {
                collectItem = iC.Collect();
                inventory.setCell(collectItem);
                adviceM.SetActive(iC.InInteract(), false);
            }
            else
            {

            }

        }
    }
}
    


    


    

