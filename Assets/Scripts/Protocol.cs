using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Protocol : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject turnOff;

    private float soundVolume, musicVolume;

    public void startPunishment()
    {
        audioMixer.GetFloat("MusicVolume", out musicVolume);
        audioMixer.GetFloat("SoundVolume", out soundVolume);

        audioMixer.SetFloat("MusicVolume", -80f);
        audioMixer.SetFloat("SoundVolume", -80f);
        turnOff.SetActive(false);
        StartCoroutine(WaitTime(5f));
    }

    IEnumerator WaitTime(float time)
    {
        yield return new WaitForSeconds(time);

        audioMixer.SetFloat("MusicVolume", musicVolume);
        audioMixer.SetFloat("SoundVolume", soundVolume);

        SceneLoader.instance.LoadScene("MainMenu");
        SceneLoader.instance.UnloadScene(SceneManager.GetSceneByName("Shop"));
    }
}
