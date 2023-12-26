using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public List<string> dialogues;
    public GameManager gm;
     public GameObject dialoguePanel;
    public DialogueManager dm;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Managers").GetComponent<GameManager>();
        dm = GameObject.Find("Managers").GetComponent<DialogueManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            dm.player = collision.gameObject;
            dm.enemy = this.gameObject;
            gm.gameStatus = GameStates.Interact;
            dialoguePanel.SetActive(true);
          //  dialoguePanel.GetComponent<DialogueAnimation>().text = dialogues[0];
        }
    }
    public void StartDialogue()
    {
        print(dialogues[0]);
    }
}
