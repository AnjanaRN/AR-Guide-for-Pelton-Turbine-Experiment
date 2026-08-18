using UnityEngine;

public class DropdownToggle : MonoBehaviour
{
    public GameObject descriptionPanel;

    private bool isOpen = false;

    public void ToggleDropdown()
    {
        isOpen = !isOpen;
        descriptionPanel.SetActive(isOpen);
    }
}