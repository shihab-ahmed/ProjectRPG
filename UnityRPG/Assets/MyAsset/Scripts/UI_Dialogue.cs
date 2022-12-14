using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Dialogue : MonoBehaviour
{
    public Image speakerImage;
    public TextMeshProUGUI textSpeakerName;
    public TextMeshProUGUI textDialogue;

    public DialogueManager dialogueManager;
    public void OnClickedNext()
    {
        dialogueManager.DisplayNextSentence();
        Debug.Log("Next Dialogue");
    }
}
