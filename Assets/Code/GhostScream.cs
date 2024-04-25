using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScream : MonoBehaviour
{
    Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        anima = gameObject.GetComponent<Animator>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anima.SetTrigger("Scream");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
