using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RuleButton : MonoBehaviour
{
    public string SceneName;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
           SceneManager.LoadScene(SceneName);
        });
    }
}
