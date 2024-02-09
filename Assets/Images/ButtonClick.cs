using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public string SceneToLoad;

    // Function to load the registration scene
    public void LoadNextScene(string SceneToLoad)
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}