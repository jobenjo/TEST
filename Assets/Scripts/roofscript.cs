using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roofscript : MonoBehaviour {
    public GameObject Player;
    public int Range;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");

	}
	
	// Update is called once per frame
	void Update () {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ENTERED");
        Color tmp = this.GetComponent<SpriteRenderer>().color;
        tmp.a = 0.3f;
        this.GetComponent<SpriteRenderer>().color = tmp;
        

    }
    void OnTriggerExit2D(Collider2D other)
    {
        Color tmp = this.GetComponent<SpriteRenderer>().color;
        tmp.a = 255f;
        this.GetComponent<SpriteRenderer>().color = tmp;
        Debug.Log("EXITED");
        


    }
}
