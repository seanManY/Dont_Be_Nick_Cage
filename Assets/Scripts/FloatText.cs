using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatText : MonoBehaviour {

    TextMeshProUGUI text;
    public int score = 0;

    bool display = false;

    // Use this for initialization
    void Start () {
        text = gameObject.GetComponent<TextMeshProUGUI>();
        
        
    }
	
	// Update is called once per frame
	void Update () {

        text.text = "+" + score;
	}
    
}
