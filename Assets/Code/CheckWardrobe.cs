using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using StarterAssets;

public class CheckWardrobe : MonoBehaviour
{
    public GameObject MessagePanel; // ������ʴ���ͤ����͹���������� Trigger
    public bool Action; // ����� Check ����ա�� Action �������
    public bool Enter; // ����� Check ����ա�� enter trigger �������

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
