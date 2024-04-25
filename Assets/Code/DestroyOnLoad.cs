using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnLoad : MonoBehaviour
{
    public GameObject trg;
    static bool m_IsDeleted = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Triggered");
            Destroy(trg);
            m_IsDeleted = true;
        } 
    }

    private void Awake()
    {
        if (m_IsDeleted)
            Destroy(trg);
    }
}
