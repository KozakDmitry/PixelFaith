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

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        iC = collision.gameObject.GetComponent<ICollectable>();
        if (iC != null)
        {
            adviceM.SetActive(iC.InInteract(), true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                iC.Collect();
                adviceM.SetActive(iC.InInteract(), false);

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
    


    


    

