using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for instantiation of meteorites. Attach to the camera object
public class RockSpawn : MonoBehaviour
{//Lab 2 week 1
    public GameObject Rock;
    public int timelimit;
    public float timer;

    // Use this for initialization
    void Start()
    {
        timer = 0;
        timelimit = Random.Range(5, 8);
    }

    // Update is called once per frame
    void Update()
    {

        timer += 1 * Time.deltaTime;
        if (timer >= timelimit)
        {
            Vector3 pos = new Vector3(Random.Range(-8, 3),10, 0);
            Instantiate(Rock, new Vector3(Random.Range(-8, 3), 6.1f, 0), transform.rotation);
           // GameObject.Instantiate(Rock).transform.SetPositionAndRotation(pos, Quaternion.Euler(0, 0, 0));
            timelimit = Random.Range(0, 5);
            timer = 0;
        }
    }
}

