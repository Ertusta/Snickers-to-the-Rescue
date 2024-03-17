using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class ManScript : MonoBehaviour
{

    public float Speed = 5;
    public float Duration = 1;

    public GameObject Left;
    public GameObject Right;

    bool control=true;

    public Animator animator;


    void Start()
    {
        
        InvokeRepeating("Movement", Duration, Duration);


    }

    


    void Movement()
    {
        if (control)
        {
            Left.SetActive(true);
            Right.SetActive(false);
            animator.SetBool("State", false);
            control = false;
        }
        else 
        { 
            Right.SetActive(true);
            Left.SetActive(false);
            control = true;
            animator.SetBool("State", true);
        }

    }
}
