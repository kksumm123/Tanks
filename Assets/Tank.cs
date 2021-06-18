using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviourPun
{
    [SerializeField] float speed = 5f;
    TextMesh nameText;
    private void Awake()
    {
        nameText = GetComponentInChildren<TextMesh>();
    }
    private void Start()
    {
        if (photonView != null && photonView.Owner != null)
        {
            nameText.text = photonView.Owner.NickName;
            name = "Tank_" + nameText.text;
        }
    }
    void Update()
    {
        if (photonView.IsMine == false)
            return;

        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
            move.z = 1;
        if (Input.GetKey(KeyCode.DownArrow))
            move.z = -1;
        if (Input.GetKey(KeyCode.RightArrow))
            move.x = 1;
        if (Input.GetKey(KeyCode.LeftArrow))
            move.x = -1;

        if (move.sqrMagnitude > 0)
        {
            // 방향
            move.Normalize();

            transform.Translate(move * speed * Time.deltaTime, Space.World);

            //transform.LookAt(transform.position + move);
            transform.forward = Vector3.Slerp(transform.forward, move, rotateLerp);
        }

    }
    [SerializeField] float rotateLerp = 0.05f;
}
