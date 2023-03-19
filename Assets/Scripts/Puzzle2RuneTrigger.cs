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
    public GameObject player2;
    private bool bLit;
    Material m_Material;

    private void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        m_Material = this.GetComponent<Renderer>().material;
        m_Material.color = Color.grey;
    }

    private void OnTriggerEnter(Collider other)
    {
        onEnter.Invoke();
        if (other.gameObject == (player1 || player2) && bLit == false)
        {
            m_Material.color = Color.white;
            P2C.IncreaseVal(iRuneValue);
            bLit = true;
        }
    }
}
