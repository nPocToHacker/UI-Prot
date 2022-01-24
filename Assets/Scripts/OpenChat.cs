using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChat : MonoBehaviour
{
    public RectTransform chatWindow;
    private bool isOpen;

    const float moveDistance = 430f;

    void Start()
    {
        isOpen = false;
    }

    public void CallChat()
    {
        if (isOpen)
        {
            chatWindow.position -= new Vector3(moveDistance, 0f, 0f);
            isOpen = false;
        }
        else
        {
            chatWindow.position += new Vector3(moveDistance, 0f, 0f);
            isOpen = true;
        }
    }
}
