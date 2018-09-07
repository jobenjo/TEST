using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlinescript : MonoBehaviour {
    public GameObject Player;
    public GameObject outline;
    bool invi;
    public SpriteRenderer rend;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            rend.flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            rend.flipX = false;
        }
    }
}
    
