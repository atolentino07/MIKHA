using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class SceneLoader : MonoBehaviour
{
    public ARSession arSession; // Assign the ARSession object in the Inspector.
    public string arSceneName = "ARScene"; // Name of your AR scene (customize this as needed).

    // Load a scene by name
    public void LoadScene(int sceneIndex)
    {
        // Get the name of the scene being loaded
        string sceneName = SceneManager.GetSceneByBuildIndex(sceneIndex).name;

        // If the target scene is the AR scene, reset the AR session
        if (sceneName == arSceneName)
        {
            RestartARSession();
        }

        // Load the scene by index
        SceneManager.LoadScene(sceneIndex);
    }

    // Method to reset/restart the AR session
    private void RestartARSession()
    {
        if (arSession != null)
        {
            Debug.Log("Restarting AR session...");
            arSession.Reset();
        }
        else
        {
            Debug.LogWarning("ARSession is not assigned. Ensure it is set in the Inspector.");
        }
    }
}