using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTarget : MonoBehaviour
{
    public Transform target;

    public float radius = 0f; // 반지름
    public float rotSpeed = 0f; // 자전 속도
    public float rotAroundSpeed = 0f; // 공전 속도
    public float angle = 0f; // 각도

    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        transform.RotateAround(target.position, Vector3.up, rotAroundSpeed * Time.deltaTime);
    }
}
