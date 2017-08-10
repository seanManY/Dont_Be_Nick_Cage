using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private bool move;
    private bool end = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space) && !end)
        {
            move = true;
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            move = false;
            end = true;
        }
		
	}

    public bool getEnd()
    {
        return move;
    }
}
