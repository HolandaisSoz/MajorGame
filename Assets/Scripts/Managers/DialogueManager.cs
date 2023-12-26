using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject player, enemy;
    public ConversationTurn CT;
    public DialogueAnimation da;
    public GameManager gm;
    public int playerDialogueIndex, enemyDialogueIndex;
    // Start is called before the first frame update
    void Start()
    {
        CT = ConversationTurn.Enemy;
        gm = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.gameStatus == GameStates.Interact )
        {
            if (da.isFinished == true)
            {
                if (CT == ConversationTurn.Enemy)
                {
                    enemyDialogueIndex++;
                    CT = ConversationTurn.Player;
                }
                else
                {
                    playerDialogueIndex++;
                    CT = ConversationTurn.Enemy;
                }
                da.isFinished = false;
            }
            startDialogue();
            if (enemyDialogueIndex >= enemy.GetComponent<Enemy>().dialogues.Count)
            {
                enemyDialogueIndex = 0;
                gm.gameStatus = GameStates.Play;
            }
        }
      

        
    }
   
     void startDialogue()
    {
        if (CT == ConversationTurn.Enemy)
        {
            da.text = enemy.GetComponent<Enemy>().dialogues[enemyDialogueIndex];
        }
        else
        {
            da.text = player.GetComponent<Player>().dialogues[playerDialogueIndex];
        }
    }
}
public enum ConversationTurn
{
    Enemy,
    Player
}
