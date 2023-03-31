using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Puzzle2Controller : MonoBehaviour
{
    [SerializeField] private int iTotalRuneValue, iRequiredRuneValue;
    [SerializeField] private GameObject Pillars;
    private GameObject Player;
    private bool bFinished;
    [SerializeField] TMP_Text m_TextComponent, g_TextComponent;
    [SerializeField] private AudioSource runeSoundEffect, pillarSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        //Find the player object
        Player = GameObject.Find("Player1");
    }

    //Add the received parameter value to the total value
    public void IncreaseVal(int iVal)
    {
        iTotalRuneValue += iVal;
        runeSoundEffect.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Update the HUD
        m_TextComponent.text = "Current total: " + iTotalRuneValue.ToString() + "/" + iRequiredRuneValue.ToString();

        //Destroy the pillars blocking the exit when the value is correct
        if (iTotalRuneValue == iRequiredRuneValue && bFinished == false)
        {
            Destroy(Pillars);
            bFinished = true;
            pillarSoundEffect.Play();
        }

        //Destroy the player and update the HUD if the player overshoots his rune value
        if (iTotalRuneValue > iRequiredRuneValue)
        {
            Destroy(Player);
            g_TextComponent.text = "You overshot! Press R to reset.";
        }

        //Reload the scene, moved from player controller to ensure functionality after the player object gets destroyed
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
