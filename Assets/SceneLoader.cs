using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OpenInformationScene()
    {
        SceneManager.LoadScene("InformationScene");
    }

    public void BackToARScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}