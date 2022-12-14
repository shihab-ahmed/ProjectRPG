using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Canvas UICanvas;

    public UI_Dialogue ui_Dialogue;

    private Queue<string> sentenceQueue;
    private void Start()
    {
        sentenceQueue = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Start convo " + dialogue.name);
        sentenceQueue.Clear();

        foreach (var sentence in dialogue.sentences)
        {
            sentenceQueue.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentenceQueue.Count == 0)
        {
            EndDialogue();
        }
        else
        {
            ui_Dialogue.textDialogue.text = sentenceQueue.Dequeue();
        }
    }
    private void EndDialogue()
    {
        ui_Dialogue.gameObject.SetActive(false);
    }
}
