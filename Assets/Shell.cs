using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
