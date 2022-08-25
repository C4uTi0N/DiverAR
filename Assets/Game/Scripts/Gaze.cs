using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{
    public RectTransform textPanel;
    public RectTransform backToMenuButton;
    public ToggleInfoText toggleInfoText;
    public float lookTime = 5f;

    private float timer = 0f;
    private Slider lookSlider;

    void Start()
    {
        lookSlider = GameObject.Find("LookSlider").GetComponent<Slider>();
        lookSlider.maxValue = lookTime;
    }


    void Update()
    {
        ShowInfo();
    }


    public void ShowInfo()
    {
        if (textPanel.localScale != Vector3.one)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("hasInfo"))
                {
                    timer += Time.deltaTime;
                    LookSlider(true);
                    if (timer > lookTime) 
                    { 
                        toggleInfoText.Enable(hitInfo); 
                        backToMenuButton.localScale = Vector3.zero;
                    }
                }
                else 
                { 
                    timer = 0; 
                    LookSlider(false);
                    toggleInfoText.Disable();
                    backToMenuButton.localScale = Vector3.one;
                }
            }
            else
            {
                timer = 0;
                LookSlider(false);
                toggleInfoText.Disable();
            }
        }
    }


    public void LookSlider(bool stateTrue)
    {
        if (stateTrue)
        {
            lookSlider.gameObject.transform.localScale = Vector3.one;
            lookSlider.value = timer;
        } else
        {
            lookSlider.value = 0;
            lookSlider.gameObject.transform.localScale = Vector3.zero;
        }
    }
}
