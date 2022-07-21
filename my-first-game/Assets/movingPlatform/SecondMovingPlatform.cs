using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondMovingPlatform : MonoBehaviour
{
    Vector3 pointA = new Vector3(-10, 5, 50);
    Vector3 pointB = new Vector3(10, 5, 50);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
        
    }
}
