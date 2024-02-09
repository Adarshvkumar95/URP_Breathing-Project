using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitApplication()
    {
        // Exit the application
        Application.Quit();
        Debug.Log("Application has quit."); // This line can be useful for debugging
    }
}

