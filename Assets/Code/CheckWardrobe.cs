using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using StarterAssets;

public class CheckWardrobe : MonoBehaviour
{
    public GameObject MessagePanel; // ตัวแฟรแสดงข้อความตอนเข้ามาในระยะ Trigger
    public bool Action; // ตัวแปร Check ว่ามีการ Action หรือไม่
    public bool Enter; // ตัวแปร Check ว่ามีการ enter trigger หรือไม่

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Enter)
        {
            Action = !Action;

            if (Action)
            {
                MessagePanel.SetActive(false);
                //Action = false;
            }

            if (Action)
            {
                MessagePanel.SetActive(true);
                //Action = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MessagePanel.SetActive(true);
            //Action = true;
            Enter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MessagePanel.SetActive(false);
            //Action = false;
            Enter = false;
        }
    }

}
