using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerState : MonoBehaviour
{
    [SerializeField]
    Animator ani;

    void Start()
    {
    }


    void Update()
    {
        
    }

    public void changeState(int state)
    {
        ani.SetInteger("PlayerState", 1);
    }
}
