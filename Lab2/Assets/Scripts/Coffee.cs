using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coffee : MonoBehaviour
{

    [SerializeField] float talkDistance = 2;
    bool inConversation;
    public string[] finalD = {"Congrats you have collected all the ingredients, go back to the wizard!"};


    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the collider is the player
        if (other.CompareTag("Player"))
        {
            
            Interact();
            
            Destroy(gameObject);
        }
    }

    void Interact()
    {
        
        if (inConversation)
        {
            
            GameManager.Instance.SkipLine();
        }
        else
        {
            
            RaycastHit2D hit = Physics2D.CircleCast(transform.position, talkDistance, Vector2.up, 0, LayerMask.GetMask("NPC"));
            if (hit)
            {

                if (hit.collider.gameObject.TryGetComponent(out NPC npc))
                {

                    if (npc.npcName == "Coffee Mix"){
                        
                        GameManager.Instance.coffee = true;
                    }else if (npc.npcName == "Sugar"){
                        
                        GameManager.Instance.sugar = true;
                    }else if (npc.npcName == "Milk"){
                        GameManager.Instance.milk = true;
                    }else if (npc.npcName == "Water"){
                        GameManager.Instance.water = true;
                    }
                    if (GameManager.Instance.coffee && GameManager.Instance.sugar && GameManager.Instance.milk && GameManager.Instance.water){
                        GameManager.Instance.StartDialogue(finalD, 0, "The Game");
                    }else{
                        GameManager.Instance.StartDialogue(npc.dialogueAsset.dialogue, npc.StartPosition, npc.npcName);
                    }
                }
            }
        }
    }

}
