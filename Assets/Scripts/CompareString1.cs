using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompareString1 : MonoBehaviour
{


    //find your dropdown object
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;

    public Transform dropdownMenu;
    string value;
    int menuIndex;
    public void compare() {

        

    //get the selected index
     menuIndex = dropdownMenu.GetComponent<Dropdown>().value;

    //get all options available within this dropdown menu
    List<Dropdown.OptionData> menuOptions = dropdownMenu.GetComponent<Dropdown>().options;

    //get the string value of the selected index
     value = menuOptions[menuIndex].text;

        Debug.Log(value);

        if (value == "Mix & Match Three - Chicken & Pork")
        {
            g1.SetActive(true);
        }
        else
        {
             
        }

        if (value == "Sampler - One of Each Taco")
        {
            g2.SetActive(true);
        }
        else
        {
            
        }
        if (value == "Two Beef + One Chicken or Pork")
        {
            g3.SetActive(true);
        }
        else
        {
           

        }
        if (value == "Three Beef")
        {
            g4.SetActive(true);
        }
        else
        {
            

        }




    }

    
}
