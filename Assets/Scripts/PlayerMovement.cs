using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 0.5f;

    private void Update()
    {
        // 좌, 우 움직임
        float x = Input.GetAxis("Horizontal");
        // 앞, 뒤 움직임
        float y = Input.GetAxis("Vertical");

        // 이동 방향 설정
        Vector3 move = transform.right * x + transform.forward * y;
        // 이동 속도 설정
        controller.Move(move * speed * Time.deltaTime);
    }
}
