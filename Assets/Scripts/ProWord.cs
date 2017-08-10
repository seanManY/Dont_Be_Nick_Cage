using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProWord : MonoBehaviour {

    public float killTimer = 10;
    public int speed = 100;
    private bool end = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        killTimer -= Time.deltaTime;
        
        if(!end)
            gameObject.GetComponent<RectTransform>().Translate(Vector2.left * speed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space))
            end = true;

    
        if(killTimer < 0)
        {
            Destroy(this.gameObject);
        }
		
	}
}
