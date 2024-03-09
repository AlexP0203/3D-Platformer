using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
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
        stats.CurrentHealth -= 1;
        view.Health(1);
        player.damage();
    }
}
