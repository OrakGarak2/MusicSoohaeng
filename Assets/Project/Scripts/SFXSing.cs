using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXSing : MonoBehaviour
{
    [SerializeField] List<AudioClip> clipList = new List<AudioClip>();
    [SerializeField] AudioClip pianoClip;
    [SerializeField] AudioSource audioSource;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            // WŰ
            audioSource.PlayOneShot(clipList[0]);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // AŰ
            audioSource.PlayOneShot(clipList[1]);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // SŰ
            audioSource.PlayOneShot(clipList[2]);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // DŰ
            audioSource.PlayOneShot(clipList[3]);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // ���� ȭ��ǥ
            audioSource.PlayOneShot(clipList[4]);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // ������ ȭ��ǥ
            audioSource.PlayOneShot(clipList[5]);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // ���� ȭ��ǥ
            audioSource.PlayOneShot(clipList[6]);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // �Ʒ��� ȭ��ǥ
            audioSource.PlayOneShot(pianoClip);
        }

        if (Input.GetMouseButtonDown(0))
        {
            // ��Ŭ��
        }
        if (Input.GetMouseButtonDown(1))
        {
            // ��Ŭ��
        }
    }

    void AudioPlay(AudioClip clip)
    {
        //audioSource.PlayOneShot(clip);
    }
}
