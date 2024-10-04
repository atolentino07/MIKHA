using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    // Reference to the first dialogue box panel
    public GameObject dialogueBox;

    // Reference to the second dialogue box panel (appears when "No" is pressed)
    public GameObject noDialogueBox;

    void Start()
    {
        // Show the first dialogue box when the game starts
        ShowDialogueBox();
    }

    // Show the first dialogue box
    public void ShowDialogueBox()
    {
        dialogueBox.SetActive(true);
    }

    // Hide the first dialogue box
    public void HideDialogueBox()
    {
        dialogueBox.SetActive(false);
    }

    // Function to handle the "Yes" button
    public void OnYesButtonPressed()
    {
        Debug.Log("Yes button pressed.");
        HideDialogueBox();
        // Add any actions for the "Yes" button here
    }

    // Function to handle the "No" button (show second dialogue box)
    public void OnNoButtonPressed()
    {
        Debug.Log("No button pressed.");
        HideDialogueBox();  // Hide the first dialogue box

        // Show the second dialogue box
        if (noDialogueBox != null)
        {
            noDialogueBox.SetActive(true);
        }
    }

    // Function to handle the "Okay" button on the second dialogue box
    public void OnOkayButtonPressed()
    {
        Debug.Log("Okay button pressed.");
        if (noDialogueBox != null)
        {
            noDialogueBox.SetActive(false); // Hide the second dialogue box
        }
        // Add any actions for the "Okay" button here
    }
}
