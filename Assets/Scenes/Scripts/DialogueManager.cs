using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    // Reference to the first dialogue box panel
    public GameObject dialogueBox;

    // Reference to the second dialogue box panel (appears when "No" is pressed)
    public GameObject noDialogueBox;

    // Reference to the SceneLoader script
    public SceneLoader sceneLoader;

    void Start()
    {
        // Do not show the dialogue box automatically anymore
        // Remove ShowDialogueBox() here
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

        // Call the SceneLoader to load a new scene by index
        if (sceneLoader != null)
        {
            sceneLoader.LoadScene(2);  // Replace 1 with the actual index of the scene you want to load
        }
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
    }

    // Function to open the first dialogue box (to be called by the button)
    public void OpenDialogueBox()
    {
        if (dialogueBox != null)
        {
            dialogueBox.SetActive(true);
        }
    }
}
