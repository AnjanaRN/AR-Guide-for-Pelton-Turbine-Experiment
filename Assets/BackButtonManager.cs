using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonManager : MonoBehaviour
{
    public void GoBackToAR()
    {
        SceneManager.LoadScene("SampleScene");
    }
}