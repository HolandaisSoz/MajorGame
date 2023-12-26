using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed, force;
    public bool canJump;
    private Player player;
    public string posState;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
        posState = "right";
    }

    private void Update()
    {
       
        
        if(player.gm.gameStatus == GameStates.Play)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
            {
                rb.AddForce(Vector2.up * force);
                canJump = false;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) posState = "right";
            else if (Input.GetKeyDown(KeyCode.LeftArrow)) posState = "left";


        }
        if (player.gm.gameStatus == GameStates.Play)
        {
            float axis = Input.GetAxis("Horizontal");
            print(axis);
            rb.velocity = new Vector2(speed * axis * Time.fixedDeltaTime, rb.velocity.y);


        }
    }
    void FixedUpdate()
    {
       

    }

    
}
