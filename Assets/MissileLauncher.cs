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
            Debug.Assert(missile != null, "�̻��� ����");
            Instantiate(missile, transform.position, transform.rotation);
        }
    }
}
