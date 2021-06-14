using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class setup : MonoBehaviour
{
    public GameObject human;
    public VirtualButtonBehaviour Vb;


    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        human.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        human.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //human.SetActive(false);
    }
}

