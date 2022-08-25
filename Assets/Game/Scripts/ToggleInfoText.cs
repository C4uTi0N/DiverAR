using UnityEngine;
using TMPro;

public class ToggleInfoText : MonoBehaviour
{
    public RectTransform textPanel;

    public TextMeshProUGUI nameToShow;
    public TextMeshProUGUI textToShow;
    public Gaze gaze;

    public void Enable(RaycastHit hitInfo)
    {
        Debug.Log("Enabling text panel");

        textPanel.localScale = Vector3.one;
        nameToShow.text = hitInfo.collider.gameObject.name;
        textToShow.text = hitInfo.collider.GetComponentInChildren<TextMeshProUGUI>().text;
        gaze.LookSlider(false);
    }

    public void Disable()
    {
        Debug.Log("Disabling text panel");
        textPanel.localScale = Vector3.zero;
    }
}