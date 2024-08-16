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
            // W키
            audioSource.PlayOneShot(clipList[0]);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // A키
            audioSource.PlayOneShot(clipList[1]);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // S키
            audioSource.PlayOneShot(clipList[2]);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // D키
            audioSource.PlayOneShot(clipList[3]);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 왼쪽 화살표
            audioSource.PlayOneShot(clipList[4]);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // 오른쪽 화살표
            audioSource.PlayOneShot(clipList[5]);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // 위쪽 화살표
            audioSource.PlayOneShot(clipList[6]);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // 아래쪽 화살표
            audioSource.PlayOneShot(pianoClip);
        }

        if (Input.GetMouseButtonDown(0))
        {
            // 좌클릭
        }
        if (Input.GetMouseButtonDown(1))
        {
            // 우클릭
        }
    }

    void AudioPlay(AudioClip clip)
    {
        //audioSource.PlayOneShot(clip);
    }
}
