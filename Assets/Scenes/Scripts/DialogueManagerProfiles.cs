using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerProfiles : MonoBehaviour
{
    public GameObject dialogueBox; // Reference to the dialogue panel

    void Start()
    {
        // Ensure the dialogue box is hidden at the start
        dialogueBox.SetActive(false);
    }

    public void ShowDialogue()
    {
        // Show the dialogue box
        dialogueBox.SetActive(true);
    }

    public void CloseDialogue()
    {
        // Hide the dialogue box
        dialogueBox.SetActive(false);
    }
}
