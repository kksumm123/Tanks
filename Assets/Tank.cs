using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    void Update()
    {
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
            move.z = 1;
        if (Input.GetKey(KeyCode.DownArrow))
            move.z = -1;
        if (Input.GetKey(KeyCode.RightArrow))
            move.x = 1;
        if (Input.GetKey(KeyCode.LeftArrow))
            move.x = -1

        if(move.sqrMagnitude > 0)
        {
            // πÊ«‚
            move.Normalize();

            transform.Translate(move * speed * Time.deltaTime);
        }

    }
}
