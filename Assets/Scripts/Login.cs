using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Login : MonoBehaviour
{
    public InputField inpt;
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    string str = "";

    
    void Start()
    {
        str = inpt.GetComponent<InputField>().text;
    }

    public void login()
    {   
        str = inpt.GetComponent<InputField>().text;

        Debug.Log(str);

        if (str != "")
        {
            obj.SetActive(true);
            //obj2.SetActive(false);
        }
        else
        {
            obj3.GetComponent<Text>().text = "Please fill in the field";

            //inpt.GetComponent<InputField>().text = "Name?";
        }

    }
}
