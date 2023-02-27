using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    private ICollectable iC;
    [SerializeField]
    private Transform menuAdvices;
    [SerializeField]
    private AdviceManager adviceM;


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


    private void OnTriggerExit2D(Collider2D collision)
    {
        if(iC == collision.gameObject.GetComponent<ICollectable>())
        {
            adviceM.DisableAll();
        }
    }
}
    


    


    

