using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public int[] array1 = { 1, 2, 3, 4, 5 }; // int Ÿ���� �迭�� �����ϰ� 5�� ���� �Ҵ� -> 5�� ���� ����
    public float[] array2; // float Ÿ���� �迭 ����
    public GameObject[] array3 = new GameObject[3]; // GameObject Ÿ���� �迭 ����, 3�� ���� ����

    public List<int> array4 = new List<int> { 1, 2, 3, 4, 5 };
    public List<float> array5;
    public List<GameObject> array6 = new List<GameObject>();
}

