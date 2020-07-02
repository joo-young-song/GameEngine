using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    GameObject player;

    public static bool check_game_over = false;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == player)
            check_game_over = true;
    }
}
