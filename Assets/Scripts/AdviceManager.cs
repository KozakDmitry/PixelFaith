using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum AdviceTypes { Usial, Window };
public class AdviceManager : MonoBehaviour
{
    [SerializeField]
    private GameObject adviceUsial;
    [SerializeField]
    private GameObject adviceInteract;


    public void DisableAll()
    {
        adviceUsial.SetActive(false);
        adviceInteract.SetActive(false);
    }
    public void SetActive(AdviceTypes type, bool state)
    {
        switch (type)
        {
            case AdviceTypes.Usial:
                adviceUsial.SetActive(state);
                break;
            case AdviceTypes.Window:
                adviceInteract.SetActive(state);
                break;
        }
    }

}