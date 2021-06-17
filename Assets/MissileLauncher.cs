using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    [SerializeField] GameObject missile;
    [SerializeField] Transform startPosition;
    [SerializeField] Vector3 offset;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Assert(missile != null, "미사일 없음");
            Instantiate(missile, startPosition.position, transform.rotation);
        }
    }
}
