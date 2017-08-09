using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour {

    private int score = 0;
    TextMeshProUGUI scoreText;
    public GameObject FloatingTextPrefab;
    public Canvas canvas;

    public int    maxRange = 5;
    public int    minRange = 10;
    private float timer;
    
    private int   ranScore;

    private int   penCounter = 0;
    public  int   penalty = 5;
    public int    penMax = 25;
    public int    penMin = 50;


    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();

        //random value to award the player with goodness
        timer = Random.Range(minRange, maxRange);

        //sets random arbitary amount of points for the player
        ranScore = Random.Range(1, 100);
    }
		
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score: " + score;

        if (Input.GetKey(KeyCode.Space))
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                score += ranScore;
                createText();

                //random value to award the player with goodness
                timer = Random.Range(minRange, maxRange);

                //sets random arbitary amount of points for the player
                ranScore = Random.Range(1, 100);

                penCounter--;
                if(penCounter > penalty)
                {
                    //penFuntion
                    penCounter = 0;
                }
            }
        }
	}

    public void addScore(int add_score)
    {
        score += add_score;
    }

    private FloatText createText()
    {

        GameObject floatingText = Instantiate(FloatingTextPrefab) as GameObject;
        FloatText FloatTextObject = floatingText.GetComponent<FloatText>();
        FloatTextObject.score = ranScore;
        FloatTextObject.transform.SetParent(canvas.transform, false);
        return FloatTextObject;
    }
}
