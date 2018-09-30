using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textScript : MonoBehaviour {

    public TextMeshPro text;

    void Awake()
    {
        text = GetComponent<TextMeshPro>();
        text.faceColor = new Color32(255, 128, 0, 255);
    }
}
