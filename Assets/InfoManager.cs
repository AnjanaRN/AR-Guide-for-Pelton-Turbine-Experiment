using UnityEngine;
using TMPro;

public class InfoManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject infoPanel;
    public GameObject componentPopup;

    [Header("UI Text")]
    public TMP_Text titleText;
    public TMP_Text descriptionText;

    private void ShowInformation(string title, string description)
    {
        // Hide the popup
        componentPopup.SetActive(false);

        // Show the information panel
        infoPanel.SetActive(true);

        // Update text
        titleText.text = title;
        descriptionText.text = description;
    }

    public void ShowTank()
    {
        ShowInformation(
            "Tank",
            "Stores water before it is supplied to the centrifugal pump. It acts as the primary water reservoir."
        );
    }

    public void ShowStart()
    {
        ShowInformation(
            "Start",
            "Starts the centrifugal pump and begins water circulation."
        );
    }

    public void ShowStop()
    {
        ShowInformation(
            "Stop",
            "Stops the centrifugal pump and ends water circulation."
        );
    }

    public void ShowValve()
    {
        ShowInformation(
            "Valve Control",
            "Regulates the flow of water entering the Pelton wheel."
        );
    }

    public void ShowMotor()
    {
        ShowInformation(
            "Motor",
            "Converts electrical energy into mechanical energy to drive the centrifugal pump."
        );
    }

    public void ShowInlet()
    {
        ShowInformation(
            "Inlet",
            "Allows water to enter the centrifugal pump from the storage tank."
        );
    }

    public void CloseInfo()
    {
        infoPanel.SetActive(false);
    }
}
