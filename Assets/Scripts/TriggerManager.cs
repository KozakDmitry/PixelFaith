using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    private ICollectable iC;
    private RoomManager rm;
    [SerializeField]
    private Transform menuAdvices;
    [SerializeField]
    private AdviceManager adviceM;
    [SerializeField]
    private Transform playerCameraPosition;
    [SerializeField]
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
            if (Input.GetKeyDown(KeyCode.E))
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
            adviceM.DisableAll();
        }
    }
}
    


    


    

