using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public GameObject canvas;

    public Text nameToShow;
    public Text textToShow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Disable()
    {
        Debug.Log("disabling canvas");
        canvas.SetActive(false);
    }
    public void Activate()
    {
        Debug.Log("activating canvas");

        //Text objectText = hitInfo.collider.GetComponentInChildren<Text>();
        //Text uIText = uITextTransform.GetComponentInChildren<Text>();

        nameToShow.text = "testobjekt-navn";
        textToShow.text = "det her er også en test-text";

        canvas.SetActive(true);
    }
}
