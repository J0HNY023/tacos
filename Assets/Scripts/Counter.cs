using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    int ctr=0;
    string text="0";
    string a="";
   

    public void Add()
    {
        ctr++;
        text = "" + ctr;
        this.GetComponent<InputField>().text = text;

    }
    public void Sub()
    {
        if (ctr != 0)
        {
            ctr--;
            text = "" + ctr;
            this.GetComponent<InputField>().text = text;
        }
        else { }
    }
    public void Val()
    {
        a = this.GetComponent<InputField>().text;
        ctr = int.Parse(a);
       // Debug.Log(a);
        this.GetComponent<InputField>().text = ""+ctr;
    }
}
