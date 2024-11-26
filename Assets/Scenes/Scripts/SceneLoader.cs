using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private float transitionDelay = 0f;
    [SerializeField] private Animator transitionAnimator;

    public void LoadScene(int sceneIndex)
    {
        if (sceneIndex < 0 || sceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            Debug.LogError($"Scene index {sceneIndex} is out of range!");
            return;
        }

        StartCoroutine(LoadSceneCoroutine(sceneIndex));
    }

    public void LoadSceneByName(string sceneName)
    {
        if (string.IsNullOrEmpty(sceneName) || !SceneExists(sceneName))
        {
            Debug.LogError($"Scene name '{sceneName}' does not exist!");
            return;
        }

        StartCoroutine(LoadSceneByNameCoroutine(sceneName));
    }

    private IEnumerator LoadSceneCoroutine(int sceneIndex)
    {
        if (transitionAnimator != null)
        {
            transitionAnimator.SetTrigger("Start");
        }

        if (transitionDelay > 0f)
        {
            yield return new WaitForSeconds(transitionDelay);
        }

        SceneManager.LoadScene(sceneIndex);
    }

    private IEnumerator LoadSceneByNameCoroutine(string sceneName)
    {
        if (transitionAnimator != null)
        {
            transitionAnimator.SetTrigger("Start");
        }

        if (transitionDelay > 0f)
        {
            yield return new WaitForSeconds(transitionDelay);
        }

        SceneManager.LoadScene(sceneName);
    }

    private bool SceneExists(string sceneName)
    {
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            string name = System.IO.Path.GetFileNameWithoutExtension(path);
            if (name == sceneName)
            {
                return true;
            }
        }
        return false;
    }

    public void ReloadCurrentScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void QuitApplication()
    {
        Debug.Log("Quitting Application...");
        Application.Quit();
    }
    
}
