using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    [SerializeField] GameObject missile;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Assert(missile != null, "미사일 없음");
            Instantiate(missile, transform.position, transform.rotation);
        }
    }
}
