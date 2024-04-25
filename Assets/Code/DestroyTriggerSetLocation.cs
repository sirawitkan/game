using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTriggerSetLocation : MonoBehaviour
{
    public GameObject TrgSetLocation2;
    static bool m_IsDeleted = false;
    public bool Enter;
    public bool Action;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Enter)
        {
            Action = !Action;

            if (Action)
            {
                Destroy(TrgSetLocation2, 2);
                m_IsDeleted = true;
                //Action = false;
            }

        }
    }
    private void Awake()
    {
        if (m_IsDeleted)
            Destroy(TrgSetLocation2);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            //Action = true;
            Enter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            //Action = true;
            Enter = false;
        }
    }
}
