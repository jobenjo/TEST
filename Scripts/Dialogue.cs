using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour {
    public GameObject Fred;
    public GameObject Player;
    public float Range = 5;
    public GameObject Panel;
    public bool close = false;
    bool clicked;
    public string text;
    public UnityEngine.UI.Text dialogueboxtxt;
    
    
    
	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(new Vector2(Player.GetComponent<Transform>().position.x, Player.GetComponent<Transform>().position.y), new Vector2(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.y)) < Range)
        {

            bool close = true;
        }
        else
        {
            bool close = false;
            
            
        }
        

    }
    private void OnMouseDown()
    {
        if (Panel.activeSelf)
        {
            Panel.SetActive(false);
        }
        else
        {
            Panel.SetActive(true);
            dialogueboxtxt.text = text;

            
        }
    }
    

}
