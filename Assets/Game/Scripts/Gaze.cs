using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{
    public RectTransform uITextTransform;


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo))
        {
            if (hitInfo.collider.gameObject.CompareTag("hasInfo"))
            {
                Text objectText = hitInfo.collider.GetComponentInChildren<Text>();
                Text uIText = uITextTransform.GetComponentInChildren<Text>();
                uIText.text = objectText.text;
                uITextTransform.localScale = Vector3.one;
            }
            else
            {
                uITextTransform.localScale = Vector3.zero;
            }
        } 
    }
}
