using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {

    public float y;//Lab 2 week 1
    public float MinMaxBoundsX;//Lab 2 week 1
    public float x;
    public float MinMaxBoundsY;

    // Update is called once per frame
    void Update () {
        if (transform.position.x >= MinMaxBoundsX)
        {
            transform.position = new Vector3(MinMaxBoundsX, y, 0);
        }
        if (transform.position.x <= -MinMaxBoundsX)
        {
            transform.position = new Vector3(-MinMaxBoundsX, y, 0);
        }

        if (transform.position.y >= MinMaxBoundsY)
        {
            transform.position = new Vector3(MinMaxBoundsY, x, 0);
        }
        if (transform.position.y <= -MinMaxBoundsY)
        {
            transform.position = new Vector3(-MinMaxBoundsY, x, 0);
        }
    }
}

