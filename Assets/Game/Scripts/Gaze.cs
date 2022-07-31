using System.Collections;
using UnityEngine;

public class Gaze : MonoBehaviour
{
    public RectTransform textPanel;
    public ToggleInfoText toggleInfoText;

    void Update()
    {
        if (textPanel.localScale != Vector3.one)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("hasInfo"))
                {
                    toggleInfoText.Enable(hitInfo);
                }
                else { toggleInfoText.Disable(); }
            }
        }
    }
}
