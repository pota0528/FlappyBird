using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomPipeMap : MonoBehaviour
{
    public enum PIPE_TYPE { TOP, BOTTOM, ALL };
    public PIPE_TYPE pipeType;

    public GameObject[] pipes;
    public float pipeSpeed = 10f;

    void Start()
    {
        RandomPipeType();
    }
    void Update()
    {
        pipes[0].transform.position -= Vector3.right * pipeSpeed * Time.deltaTime;
        pipes[1].transform.position -= Vector3.right * pipeSpeed * Time.deltaTime;

        foreach (GameObject pipe in pipes)
        {
            pipe.transform.position -= Vector3.right * pipeSpeed * Time.deltaTime;

            if (pipe.transform.position.x <= -10f)
            {
                RandomPipeType();
                pipe.transform.position = new Vector3(10f, pipe.transform.position.y, pipe.transform.position.z);
            }
        }
    }

    private void RandomPipeType() // ������ �缳�� ���
    {
        // ó�� ������ �� ������ Ÿ���� ����!!
        int ranInt = Random.Range(0, 3); // 0, 1, 2
        pipeType = (PIPE_TYPE)ranInt; // ����ȯ(ĳ����)

        if (pipeType == PIPE_TYPE.TOP) // ������ Ÿ���� TOP�� ���
        {
            pipes[0].SetActive(true);
            pipes[1].SetActive(false);
        }
        else if (pipeType == PIPE_TYPE.BOTTOM) // ������ Ÿ���� BOTTOM�� ���
        {
            pipes[0].SetActive(false);
            pipes[1].SetActive(true);
        }
        else if (pipeType == PIPE_TYPE.ALL) // ������ Ÿ���� ALL�� ���
        {
            pipes[0].SetActive(true);
            pipes[1].SetActive(true);
        }

        // ������ ���̸� �����ϰ� �ٲٴ� ���

        float ranFloat = Random.Range(-2f, 2f); // float Ÿ���� ���� ��

        transform.position = new Vector3(transform.position.x, ranFloat, transform.position.z);
    }
}
