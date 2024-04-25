using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using StarterAssets;


public class Read_Book : MonoBehaviour
{
    
[SerializeField]
private GameObject _noteImage;

public GameObject MessagePanel;
public bool Action;
public bool enter;


public void Update()
{

    if (Input.GetKeyDown(KeyCode.E) && enter)
    {
            Action = !Action;
        if (Action)
        {
            MessagePanel.SetActive(false);
            //Action = false;
            _noteImage.SetActive(true);
                Time.timeScale = 0f;    

        }

            if (!Action)
            {
                MessagePanel.SetActive(true);
                //Action = true;
                _noteImage.SetActive(false);
                Time.timeScale = 1f;

            }


        }
}
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        MessagePanel.SetActive(true);
        //Action = true;        
        enter = true;
    }
}
void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
        MessagePanel.SetActive(false);
        //Action = false;        
        enter = false;
        }
}
}
