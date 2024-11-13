using UnityEngine;

public class OpenLink : MonoBehaviour
{
    // Link to your Google Drive file or folder
    public string googleDriveUrl = "https://drive.google.com/drive/folders/15XN9GY61dyiZMCu7anOhqBsc_iKiKG9z?usp=sharing";

    // Method to open the URL
    public void OpenGoogleDriveLink()
    {
        Application.OpenURL(googleDriveUrl);
    }
}
