using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class LookAt : MonoBehaviour
{

    public Transform objectToLookAt;
    public float headWeight;
    public float bodyWeight;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnAnimatorIK(int layerIndex)
    {
        animator.SetLookAtPosition(objectToLookAt.position);
        animator.SetLookAtWeight(1, bodyWeight, headWeight);
    }
}
