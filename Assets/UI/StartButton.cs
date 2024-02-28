using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public string SceneName;

    public FadeInScene FadeInScene;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            //SceneManager.LoadScene(SceneName);
            FadeInScene.LoadScene(SceneName);
        });
    }
}
