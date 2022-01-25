using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    public GameObject loadingScreen;
    public string defaultSceneName;

    private void Awake()
    {
        instance = this;

        LoadScene(defaultSceneName, true);
    }

    public void LoadScene(string toLoad, bool doShowLoadingScreen = true)
    {
        if (!SceneManager.GetSceneByName(toLoad).isLoaded)
        {
            if (doShowLoadingScreen)
            {
                loadingScreen.gameObject.SetActive(true);
            }

            StartCoroutine(LoadAsync(toLoad));
        }
    }

    IEnumerator LoadAsync(string sceneName)
    {
        AsyncOperation sceneLoading = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        while (!sceneLoading.isDone)
        {
            yield return null;
        }

        loadingScreen.gameObject.SetActive(false);
    }
}
