using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    //texture type - texture
    //wrap mode - repeat

    //put texture on 3d object quad

    public float speed = 0.5f;
    public Renderer rend;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector2 offset = new Vector2(Time.time * speed, 0);

            rend.material.mainTextureOffset = offset;
        }
        
        
	}
}
