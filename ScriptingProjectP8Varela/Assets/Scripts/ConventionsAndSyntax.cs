using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///I want to get the x location of a game 
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        ///I want to know when a game object y position is lower than 5
        if (transform.position.y >= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
