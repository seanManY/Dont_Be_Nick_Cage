using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    //texture type - texture
    //wrap mode - repeat

    //put texture on 3d object quad

    public float speed = 0.5f;
    public Renderer rend;

    public PlayerScript player;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        player = GameObject.Find("Player").GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.Log(player.getEnd());
        if (player.getEnd())
        {
            Vector2 offset = new Vector2(Time.time * speed, 0);

            rend.material.mainTextureOffset = offset;
        }
        
        
	}
}
