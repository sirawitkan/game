using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyConditions : MonoBehaviour
{
    public GameObject trg_condition;
    static bool m_IsDeleted = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Triggered");
            Destroy(trg_condition);
            m_IsDeleted = true;
        }
    }

    private void Awake()
    {
        if (m_IsDeleted)
            Destroy(trg_condition);
    }
}
