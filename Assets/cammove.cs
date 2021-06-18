using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammove : MonoBehaviour
{
    [SerializeField] Transform tankTr;
    [SerializeField] float camSpeed = 1f;
    Vector3 offset;
    private void Start()
    {
        offset.x = transform.position.x - tankTr.position.x;
        offset.y = transform.position.y - tankTr.position.y;
        offset.z = transform.position.z - tankTr.position.z;
        Debug.Log("::" + offset);
    }

    void Update()
    {
        //var pos = tankTr.position;

        //transform.position = (tankTr.position + offset);

        if (tankTr.position.y == 0)
        {
            var distance = (tankTr.position + offset) - transform.position;

            distance.x *= Time.deltaTime * camSpeed;
            distance.y = 0f;
            distance.z *= Time.deltaTime * camSpeed;

            transform.Translate(distance);
        }
    }
}