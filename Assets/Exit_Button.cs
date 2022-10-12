using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Button : MonoBehaviour
{
    public GameObject RedButtonObject;

    public void PressButton(){
        Application.Quit();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        /*if ("action") {
            Application.Quit();
        }*/
    }
}
