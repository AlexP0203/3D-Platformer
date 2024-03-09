using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    [SerializeField] PlayerStats stats;
    Player player;
    View view;

    void Start()
    {
        view = FindAnyObjectByType<View>();
        player = FindAnyObjectByType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        stats.CurrentHealth -= 10;
        view.Health(10);
        player.death();
    }
}
