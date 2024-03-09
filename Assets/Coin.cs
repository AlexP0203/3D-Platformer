using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    [SerializeField] PlayerStats stats;
    View view;
    // Start is called before the first frame update
    void Start()
    {
        view = FindAnyObjectByType<View>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        stats.Score += 1;
        view.Points(1);
        Destroy(this.gameObject);
        
    }
}
