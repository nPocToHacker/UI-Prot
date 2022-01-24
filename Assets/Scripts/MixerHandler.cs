using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixerHandler : MonoBehaviour
{
    public AudioMixer audioMixer;
    public string parameter;

    const float normalVolume = 0f;
    const float zeroVolume = -80f;

    public void SetValue(Toggle value)
    {
        if (value.isOn)
        {
            audioMixer.SetFloat(parameter, normalVolume);
        }
        else
        {
            audioMixer.SetFloat(parameter, zeroVolume);
        }
    }

    public void SetValue(float value)
    {
        audioMixer.SetFloat(parameter, value);
    }

}
