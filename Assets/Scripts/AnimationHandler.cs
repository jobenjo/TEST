using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour {

    // Use this for initialization
    void Start() { }

        public float stopAnimation = 0.5f;

    // Update is called once per frame
    void Update()
    {



        Vector3 directionVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if ((directionVector.x > stopAnimation || directionVector.x < -stopAnimation) ||
                (directionVector.y > stopAnimation || directionVector.y < -stopAnimation) ||
           (directionVector.z > stopAnimation || directionVector.z < -stopAnimation))
        {
           
            Debug.Log("Walking");
        }
        else
        {
            
        }
    }
}
	
	


