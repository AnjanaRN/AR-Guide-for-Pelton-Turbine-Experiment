using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    // Opens the Safety Instructions scene
    public void OpenSafetyScene()
    {
        SceneManager.LoadScene("SafetyScene");
    }

    // Opens the AR scene
    public void OpenARScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}