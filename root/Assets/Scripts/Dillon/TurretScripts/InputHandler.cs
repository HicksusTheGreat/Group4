﻿using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour 
{
   
	// Update is called once per frame
	void Update () 
    {
        TurretPlacement.TurretSelect();
        if (Input.GetKeyDown(KeyCode.W))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.D))
        { 
            //walk state
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayerActions.instance.Slap();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            PlayerActions.instance.Shoot();
        }
	}


}
