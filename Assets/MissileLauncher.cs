using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviourPun
{
    [SerializeField] GameObject missile;
    [SerializeField] Transform startPosition;
    [SerializeField] Vector3 offset;
    [SerializeField] LayerMask layer;
    [SerializeField] Transform canonBarrel;
    void Update()
    {
        if (photonView.IsMine == false)
            return;

        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    Debug.Assert(missile != null, "미사일 없음");
        //    PhotonNetwork.Instantiate(missile.name, startPosition.position, transform.rotation, 0);
        //}
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hitData,1000, layer))
            {
                var desPos = hitData.point;
                var dir = desPos - transform.position;
                canonBarrel.forward = dir;
                //dir 방향으로 포신 돌리기
                Instantiate(missile, startPosition.position, canonBarrel.rotation);
            }
        }
    }
}
