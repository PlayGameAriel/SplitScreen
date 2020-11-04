using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Uparrow=up, downarrow=down, leftarrow=turn left, rightarrow= turn right*/
public class Move_Blue : MonoBehaviour
{
    public GameObject obj;
    public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;

    public void MoveMe()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            obj.transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            obj.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    }

    void Update()
    {



        MoveMe();




    }
}

