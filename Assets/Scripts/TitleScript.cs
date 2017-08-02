using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

    public Button play;
    public Button Instructions;
    public Button Exit;

    public Image Arrow;

	// Use this for initialization
	void Start () {

        play = GameObject.Find("Play").GetComponent<Button>();
        play.onClick.AddListener(playEvent);

        Instructions = GameObject.Find("Intructions").GetComponent<Button>();
        Instructions.onClick.AddListener(instructionEvent);

        Exit = GameObject.Find("Exit").GetComponent<Button>();
        Exit.onClick.AddListener(exitEvent);

        Arrow = GameObject.Find("Arrow").GetComponent<Image>();
        Arrow.gameObject.SetActive(false);

    }

    void playEvent()
    {
        SceneManager.LoadScene("Main");
    }

    void instructionEvent()
    {
        Arrow.gameObject.SetActive(true);
    }

   void exitEvent()
    {
        Application.Quit();
    }
}
