using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CallSceneLoader : MonoBehaviour
{
    public string sceneToLoad;
    public bool unloadCurrentScene;
    public bool showLoadingScreen;

    public void CallLoader()
    {
        if (unloadCurrentScene)
        {
            SceneManager.UnloadSceneAsync(gameObject.scene);
        }

        SceneLoader.instance.LoadScene(sceneToLoad, showLoadingScreen);
    }
}