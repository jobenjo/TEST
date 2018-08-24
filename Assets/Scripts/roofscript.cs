using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roofscript : MonoBehaviour {
    public GameObject Player;
    public int Range;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(this.gameObject.activeSelf && Vector2.Distance(new Vector2(Player.GetComponent<Transform>().position.x, Player.GetComponent<Transform>().position.y), new Vector2(transform.position.x, transform.position.y)) < Range)
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().enabled = true;
        }

    }
}
