using UnityEngine;
using UnityEngine.UI;

public class ButtonHighlighter : MonoBehaviour
{
    public Button[] buttons;

    Color normalColor = new Color32(240, 240, 240, 255);
    Color selectedColor = new Color32(0, 170, 255, 255);

    public void Highlight(Button selectedButton)
    {
        foreach (Button button in buttons)
        {
            ColorBlock colors = button.colors;

            colors.normalColor = (button == selectedButton) ? selectedColor : normalColor;
            colors.selectedColor = colors.normalColor;
            colors.highlightedColor = colors.normalColor;

            button.colors = colors;
        }
    }
}
