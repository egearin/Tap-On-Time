using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Starting : MonoBehaviour
{
    public TextMeshProUGUI newTextPro;
    public TextMeshProUGUI textPro;
    public string EXIT_TEXT;
    public float seconds;
    public bool isReady;
   
    // Start is called before the first frame update
    void Start()
    {
        newTextPro = GetComponent<TextMeshProUGUI>();
        textPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(CheckPressDown()) {
            textPro.enabled = false;
        }*/

        if (CheckClick())
        {
            isReady = true;
            textPro.enabled = false;
            textPro.text = EXIT_TEXT;
            textPro.enabled = true;
        }
    }

        bool CheckPressDown() {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                return true;
            }

            else {
                return false;
            }
        }

        bool CheckClick() {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
}
