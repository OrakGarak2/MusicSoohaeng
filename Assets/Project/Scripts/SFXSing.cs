using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXSing : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            // W키
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // A키
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // S키
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // D키
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 왼쪽 화살표
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // 오른쪽 화살표
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // 위쪽 화살표
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // 아래쪽 화살표
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
}
