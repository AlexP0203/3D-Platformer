using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

public class View : MonoBehaviour
{
    TMP_Text heading;
    int points = 0;
    int health = 10;

    // Start is called before the first frame update
    void Start()
    {
        heading = FindAnyObjectByType<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Points(int pts)
    {
        points += pts;
        if (points == 10)
        {
            SceneManager.LoadScene(3);
        }
        heading.text = points.ToString();
    }

    public void Health(int hit)
    {
        health -= hit;
        if(health == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
