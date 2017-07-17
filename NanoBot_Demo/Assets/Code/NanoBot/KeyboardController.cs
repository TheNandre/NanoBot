using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : ControllerStrategy
{
    //Constuctor
    public KeyboardController()
        :base()
    {

    }

    //Overidden Functions
    public override void Update(NanoBotController pNB)
    {
        if(Input.GetKey(KeyCode.W))
        {
            pNB.MoveForward2();
        }
        else if(Input.GetKey(KeyCode.S))
        {
            pNB.MoveBackward();
        }

        if(Input.GetKey(KeyCode.D))
        {
            pNB.RotateCW2();
        }
        else if(Input.GetKey(KeyCode.A))
        {
            pNB.RotateCCW2();
        }
    }
}
