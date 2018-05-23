using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Npc : MonoBehaviour {
    private string blockToStop;
    private Player player;

    public Flowchart flowchart;
    public Button btnInteract;
    
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void InitFlowchart(string blockInit)
    {
        flowchart.ExecuteBlock(blockInit);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            btnInteract.gameObject.SetActive(true);
        }
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            btnInteract.gameObject.SetActive(false);
        }
    }

}
