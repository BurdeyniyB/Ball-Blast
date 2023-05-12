using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string SceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }

}
