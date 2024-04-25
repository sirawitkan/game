using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCkeck : MonoBehaviour
{

    [SerializeField] private GameObject uiElement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            uiElement.SetActive(true);
            Debug.Log("Trigger");

           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            uiElement.SetActive(false);


        }
    }
}
