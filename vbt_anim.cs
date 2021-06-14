using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbt_anim : MonoBehaviour
{
    public Animator anim;
    public VirtualButtonBehaviour Vb;

    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim.Play("humanoidanim");
    }
}
