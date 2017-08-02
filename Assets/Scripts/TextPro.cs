using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextPro : MonoBehaviour {

    public TextMeshProUGUI tutorial;

	// Use this for initialization
	void Start () {
        tutorial = GameObject.Find("Tutorial").GetComponent<TextMeshProUGUI>();
        tutorial.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
