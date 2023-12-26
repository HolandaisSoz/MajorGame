using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    public float speed;
    public float distance;
    public string state;
    public Vector3 startPos;
    float timer, posX;
    public bool canAttack;
    string moveDirection;
    public Animator anim;
    public PlayerMovement PM;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        state = "forward";
        canAttack = true;
        PM = transform.parent.GetComponent<PlayerMovement>();
        moveDirection = PM.posState;
    }

    // Update is called once per frame
    void Update()
    {
       if(canAttack == true)
        {
            timer += Time.deltaTime;
            posX = Mathf.PingPong(timer * speed, distance);
            transform.Rotate(Vector3.forward * speed);
            if(Vector3.Distance(startPos,transform.position) >= distance - 0.1f && state == "forward")
            {
                state = "back";
            }
            
            if(moveDirection == "right")
            {
                transform.position = new Vector3(startPos.x + posX, startPos.y, 0);
            }
            if (moveDirection == "left")
            {
                transform.position = new Vector3(startPos.x - posX, startPos.y, 0);
            }
        }
        if(Vector3.Distance(startPos, transform.position) <= 0.4f && state == "back")
        {
             Destroy();  
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("Player"))
        {
            anim.SetBool("Boom", true);
            canAttack = false;
          
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
