using UnityEngine;
using UnityEngine;
using TMPro;

public class PopupManager : MonoBehaviour
{
    public GameObject infoPopup;
    public TMP_Text titleText;
    public TMP_Text descriptionText;

    public void OpenPopup(string title, string description)
    {
        titleText.text = title;
        descriptionText.text = description;
        infoPopup.SetActive(true);
    }

    public void ClosePopup()
    {
        infoPopup.SetActive(false);
    }
}