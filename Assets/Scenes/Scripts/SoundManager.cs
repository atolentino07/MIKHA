using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;  // Singleton instance to access from anywhere
    private AudioSource audioSource;

    void Awake()
    {
        // Make sure this GameObject persists between scenes
        DontDestroyOnLoad(gameObject);

        // Singleton pattern to avoid duplicate SoundManagers
        if (instance == null)
        {
            instance = this;
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Method to play a sound clip
    public void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
