using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Destroy : MonoBehaviour
{
    public GameObject TestDestroy;
    static bool m_IsDeleted = false;
    //public bool Enter;
    public bool Action;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Action = !Action;

            if (Action)
            {
                Destroy(TestDestroy, 2);
                m_IsDeleted = true;
                //Action = false;
            }

        }
    }
    private void Awake()
    {
        if (m_IsDeleted)
            Destroy(TestDestroy);
    }
    
}
