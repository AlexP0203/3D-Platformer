using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] PlayerStats stats;
    public void moveScene()
    {
        SceneManager.LoadScene(1);
        stats.CurrentHealth = 10;
        stats.Score = 0;
    }

    public void exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
