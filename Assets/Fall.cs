using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script controls what the meteorite does. Attach to the meteor prefab
public class Fall : MonoBehaviour
{//Lab 2 week 1
    public float FallSpeed;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -FallSpeed * Time.deltaTime, 0);//make the rock fall 
        if (transform.position.y <= -5)
        {
            Destroy(this.gameObject);//destroy the rock when it goes off the screen
        }
    }
}
