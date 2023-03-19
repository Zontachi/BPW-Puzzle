using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text m_TextComponent;
    [SerializeField] GameObject Pillars;
    public float startingTime = 30f;
    private bool bCounting;
    float fCurrentTime;

    void Start()
    {
        fCurrentTime = startingTime;
    }

    void Update()
    {
        if (bCounting)
        {
            countdown();
        }
    }

    public void StartCountdown()
    {
        bCounting = true;
    }

    void countdown()
    {
        fCurrentTime -= 1 * Time.deltaTime;
        m_TextComponent.text = fCurrentTime.ToString("0");

        if (fCurrentTime <= 0)
        {
            fCurrentTime = 0;
            Destroy(Pillars);
        }
    }
}