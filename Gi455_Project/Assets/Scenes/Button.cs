using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text ans;
    
    public Text Checking;


    // Start is called before the first frame update
    void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Check()
    {
        if (ans.text == "drama")
        {
            Checking.text = ans.text + " is Found";
        }
        else if (ans.text == "comedy")
        {
            Checking.text = ans.text + " is Found";
        }
        else if (ans.text == "sifi")
        {
            Checking.text = ans.text + " is Found";
        }
        else if (ans.text == "horror")
        {
            Checking.text = ans.text + " is Found";
        }
        else if (ans.text == "action")
        {
            Checking.text = ans.text + " is Found";
        }
        else
        {
            Checking.text = ans.text + " is not Found";
        }
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
