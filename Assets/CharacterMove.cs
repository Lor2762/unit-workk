using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float Speed = 1;//Lab 1 week 1

    // Update is called once per frame
    void Update()
    {
        //Lab 1 week 1        
        if (Input.GetKey("a"))
        {
            transform.Translate(-(Speed * Time.deltaTime), 0, 0); //left
        }
        else
        if (Input.GetKey("d"))
        {
            transform.Translate(+(Speed * Time.deltaTime), 0, 0); //right
        }
        else
        if (Input.GetKey("w"))
        {
            transform.Translate(0, +(Speed * Time.deltaTime), 0); // up     x,y,z
        }
        else
        if (Input.GetKey("s"))
        {
            transform.Translate (0, -(Speed * Time.deltaTime), 0); // down 
        }
    }
}
