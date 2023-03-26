using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Puzzle2RuneTrigger : MonoBehaviour
{
    [SerializeField] int iRuneValue;
    [SerializeField] Puzzle2Controller P2C;
    public UnityEvent onEnter, onExit;
    public GameObject player1;
    private bool bLit;
    Material m_Material;

    private void Start()
    {
        player1 = GameObject.Find("Player1");
        
        //Find own material and set it's make it's color dark to indicate the rune is not lit
        m_Material = this.GetComponent<Renderer>().material;
        m_Material.color = Color.grey;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Light up the rune and receive it's value when the player steps on it
        if (other.gameObject == player1 && bLit == false)
        {
            m_Material.color = Color.white;
            P2C.IncreaseVal(iRuneValue);
            bLit = true;
        }
    }
}
