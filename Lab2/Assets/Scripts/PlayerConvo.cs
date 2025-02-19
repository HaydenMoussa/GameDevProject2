using UnityEngine;

public class PlayerConvo : MonoBehaviour
{
    [SerializeField] float talkDistance = 2;
    bool inConversation;
    public string[] finalD = {"Wow that was fast, thank you for your work! I'm going to enjoy this!"};

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
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
                    if (GameManager.Instance.coffee && GameManager.Instance.sugar && GameManager.Instance.milk && GameManager.Instance.water && npc.npcName == "The Wizard"){
                        GameManager.Instance.StartDialogue(finalD, 0, "The Wizard");
                    } else{
                        GameManager.Instance.StartDialogue(npc.dialogueAsset.dialogue, npc.StartPosition, npc.npcName);
                    }
                    
                }
            }
        }
    }

    void JoinConversation()
    {
        inConversation = true;
    }

    void LeaveConversation()
    {
        inConversation = false;
    }

    private void OnEnable()
    {
        GameManager.OnDialogueStarted += JoinConversation;
        GameManager.OnDialogueEnded += LeaveConversation;
    }

    private void OnDisable()
    {
        GameManager.OnDialogueStarted -= JoinConversation;
        GameManager.OnDialogueEnded -= LeaveConversation;
    }
}
