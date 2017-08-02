using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextPro : MonoBehaviour {

    public TextMeshProUGUI tutorial;
    public float counter = 5f;

	// Use this for initialization
	void Start () {
        tutorial = GameObject.Find("Tutorial").GetComponent<TextMeshProUGUI>();
        tutorial.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        //tutorial
        counter -= Time.deltaTime;
        if(counter < 0)
        {
            tutorial.gameObject.SetActive(true);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            tutorial.gameObject.SetActive(false);
        }        
	}
}
