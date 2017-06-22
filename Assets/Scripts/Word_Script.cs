using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word_Script : MonoBehaviour
{

    public int speed = 1;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(Time.deltaTime * -speed, 0, 0);

    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "KillWall")
        {

            Destroy(this.gameObject);
        }
    }


}
