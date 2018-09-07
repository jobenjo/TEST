using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characterscript : MonoBehaviour {
    public string text;
    public GameObject panel;
    bool active = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void settext(string wish)
    {
        text = wish;
    }
}
