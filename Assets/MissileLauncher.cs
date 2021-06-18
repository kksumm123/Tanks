using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviourPun
{
    [SerializeField] GameObject missile;
    [SerializeField] Transform startPosition;
    [SerializeField] Vector3 offset;
    void Update()
    {
        if (photonView.IsMine == false)
            return;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Assert(missile != null, "미사일 없음");
            PhotonNetwork.Instantiate(missile.name, startPosition.position, transform.rotation, 0);
        }
    }
}
