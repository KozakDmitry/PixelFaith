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
    private GameObject playerCamera;
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
        playerCamera.transform.position = cameraPosition.position;
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
            if (inventory.setCell(iC.Collect()))
            {
                adviceM.SetActive(iC.InInteract(), false);
            }
            else
            {
                adviceM.NotEnoughSpace();
            }

        }
    }
}
    


    


    

