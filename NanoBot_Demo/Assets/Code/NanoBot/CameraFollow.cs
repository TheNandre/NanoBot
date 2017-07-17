using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	//Functions//

    //GO Functions
	void Start ()
    {
		
	}
	
	void Update ()
    {
        this.vCurrentPos.Set(Target.transform.position.x, Target.transform.position.y, -10.0f);
        this.transform.position = this.vCurrentPos;
	}

    //Variables//

    //Private
    private Vector3 vCurrentPos;
    //Public
    public Transform Target;
}
