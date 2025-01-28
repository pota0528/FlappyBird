using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource; // ����Ŀ
    public AudioClip[] clips; // �Ҹ� ���� 0. ��Ʈ�� / 1. ���� / 2. ���� / 3. �浹
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        OnIntroBGM();
    }

    public void OnIntroBGM()
    {
        audioSource.clip = clips[0];
        audioSource.Play();
    }
    public void OnMainBGM()
    {
        audioSource.clip = clips[1];
        audioSource.Play();
    }
    public void OnJumpSound() // 1���� �����ϴ� Event ����
    {
        audioSource.PlayOneShot(clips[2]);
    }
    public void OnCollisionSound() // 1���� �����ϴ� Event ����
    {
        audioSource.PlayOneShot(clips[3]);
    }
}
