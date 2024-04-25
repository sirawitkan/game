using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using StarterAssets;

public class Switch_Scene : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private GameObject uiElement;

    public Image black;
    public Animator anim;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")){

            uiElement.SetActive(true);
            Debug.Log("Trigger");

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(newLevel);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            uiElement.SetActive(false);

            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine("Fading");
        }
    }

    IEnumerable Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(newLevel);
    }
}
