using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puzzle2Controller : MonoBehaviour
{
    [SerializeField] private int iTotalRuneValue, iRequiredRuneValue;
    [SerializeField] private GameObject Pillars;
    private bool bFinished;
    private GameObject Player;
    [SerializeField] TMP_Text m_TextComponent, g_TextComponent;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player1");
    }

    public void IncreaseVal(int iVal)
    {
        iTotalRuneValue += iVal;
    }

    // Update is called once per frame
    void Update()
    {
        m_TextComponent.text = "Current total: " + iTotalRuneValue.ToString() + "/" + iRequiredRuneValue.ToString();

        if (iTotalRuneValue == iRequiredRuneValue)
        {
            Destroy(Pillars);
            bFinished = true;
        }

        if (iTotalRuneValue > iRequiredRuneValue && bFinished == false)
        {
            g_TextComponent.text = "You overshot! Press R to reset.";
        }
    }
}
