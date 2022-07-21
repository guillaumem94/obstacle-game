using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) transform.Translate(new Vector3(0, 0, MoveSpeed));
        if (Input.GetKey(KeyCode.S)) transform.Translate(new Vector3(0, 0, -MoveSpeed / 3));
        if (Input.GetKey(KeyCode.Q)) transform.Translate(new Vector3(-MoveSpeed, 0, 0));
        if (Input.GetKey(KeyCode.D)) transform.Translate(new Vector3(MoveSpeed, 0, 0));

        if (Input.GetKey(KeyCode.Space)) transform.Translate(new Vector3(0, MoveSpeed, 0));
    }
}
