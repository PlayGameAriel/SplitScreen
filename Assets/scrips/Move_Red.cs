using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* U=up, D=down, L=turn left, R= turn right*/
public class Move_Red : MonoBehaviour
{
    public GameObject obj;
    public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;

    public void MoveMe()
    {
        if (Input.GetKey(KeyCode.U))
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.L))
            obj.transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.R))
            obj.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    }

    void Update()
    {

      
        
            MoveMe();
        

    

    }
}
