using UnityEngine;

public class MachinePartButton : MonoBehaviour
{
    public PopupManager popupManager;

    [TextArea]
    public string title;

    [TextArea(3, 10)]
    public string description;

    public void ShowInfo()
    {
        popupManager.OpenPopup(title, description);
    }
}