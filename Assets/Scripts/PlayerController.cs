using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private float playerSpeed = 7.0f;

    void Update()
    {
        //Read player input and assign the values to a new vector
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (move != Vector3.zero)
        {
            //Move the player when there is input
            Vector3 movePos = transform.position + move * Time.deltaTime * playerSpeed;
            transform.position = movePos;
            gameObject.transform.forward = move;
        }

        //Toggle visability of the rune value sheet
        if (Input.GetKey(KeyCode.F))
        {
            obj.SetActive(true);
        }
        else
        {
            obj.SetActive(false);
        }
    }
}
