using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter;
    public GameObject player;

    void Start()
    {
        //Find the player object
        player = GameObject.Find("Player1");
    }

    private void OnTriggerEnter(Collider other)
    {
        //Advance to the next scene when stepping on the finish
        if (other.gameObject == player)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
