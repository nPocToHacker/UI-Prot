using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GoToURL : MonoBehaviour
{
    public void OpenWeb(string url)
    {
        Application.OpenURL(url);
    }
}
