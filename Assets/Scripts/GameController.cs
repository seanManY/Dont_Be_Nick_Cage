using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject itFine;
    public GameObject okay;
    public GameObject great;
    public GameObject whatever;
    public GameObject kool;
    public GameObject sure;
    public GameObject score;

    private GameObject[] wordAR;

    private float fireTimer;
    public int fireRate = 200;

    private int randomWord;
    private float randomY;
    private float randomX;

    public GameObject canvas;
    

	// Use this for initialization
	void Start ()
    {
        fireTimer = 0;
        randomWord = 0;

        wordAR = new GameObject[6];
        wordAR[0] = itFine;
        wordAR[1] = okay;
        wordAR[2] = great;
        wordAR[3] = whatever;
        wordAR[4] = kool;
        wordAR[5] = sure;
        

    }

    void Update()
    {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () 
    {
       if(Input.GetKey(KeyCode.Space)) 
       {
            fireTimer++;
        
            if ((fireTimer >= fireRate) && (fireRate != 100))
            {
            
                fireTimer = 0;

                randomWord = Random.Range(0, 5);
                randomX = Random.Range(-500, -80);
                randomY = Random.Range(150, 0);

                GameObject floatingText = Instantiate(wordAR[randomWord]) as GameObject;
                Vector2 spawnPosition = new Vector2(randomX, randomY);
                floatingText.transform.SetParent(canvas.transform);
                floatingText.GetComponent<RectTransform>().anchoredPosition = spawnPosition;

                //Instantiate(wordAR[randomWord], new Vector3(randomX, randomY, 40), Quaternion.identity);
            }
       }
      
	}

}
