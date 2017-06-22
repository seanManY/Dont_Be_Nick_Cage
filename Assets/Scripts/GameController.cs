using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject itFine;
    public GameObject okay;
    public GameObject great;
    public GameObject whatever;
    public GameObject kool;

    private GameObject[] wordAR;

    private float fireTimer;
    public int fireRate = 200;

    private int randomWord;
    private float randomY;
    private float randomX;
    

	// Use this for initialization
	void Start ()
    {
        fireTimer = 0;
        randomWord = 0;

        wordAR = new GameObject[5];
        wordAR[0] = itFine;
        wordAR[1] = okay;
        wordAR[2] = great;
        wordAR[3] = whatever;
        wordAR[4] = kool;
		
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
                randomX = Random.Range(4.0f, 6.0f);
                randomY = Random.Range(-0.5f, 1.8f);
                Instantiate(wordAR[randomWord], new Vector3(randomX, randomY, 5), Quaternion.identity);
            }
       }
	}
}
