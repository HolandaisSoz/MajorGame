using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement PlayerMove;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMove = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Through"))
        {
            collision.gameObject.tag = "Floor";
            this.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            PlayerMove.canJump = true;
        }

        
    }
}
