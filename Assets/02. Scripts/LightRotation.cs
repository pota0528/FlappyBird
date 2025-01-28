using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotation : MonoBehaviour
{
    public float rotSpeed = 10f; // 회전 속도 조절하는 변수
    void Update()
    {
        transform.Rotate(Vector3.right * rotSpeed * Time.deltaTime);
    } // 자기 자신이 회전하는 기능
}