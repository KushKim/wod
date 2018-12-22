using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Animator animator;
    [SerializeField]
    GameObject doorPos;

    [SerializeField]
    FadeOutIn fadeOutIn;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (PlayerManager.getInstance().Animator == 1)
        {
            animator.SetBool("End", true);
            transform.position = Vector3.MoveTowards(transform.position, doorPos.transform.position,Time.deltaTime);          
        }

        if(transform.position == doorPos.transform.position)
        {
            fadeOutIn.StartFadeAnim();
        }
    }
}
