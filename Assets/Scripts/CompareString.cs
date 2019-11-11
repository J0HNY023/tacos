using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompareString : MonoBehaviour
{


    //find your dropdown object
    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    
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

        // Debug.Log(value);

        if (value == "Beef")
        {
            g1.SetActive(true);
        }
        else
        {
          //  g1.SetActive(false);
        }

        if (value == "Pork")
        {
            g2.SetActive(true);
        }
        else
        {
          //  g2.SetActive(false);
        }
        if (value == "Chicken")
        {
            g3.SetActive(true);
        }
        else
        {
          //  g3.SetActive(false);

        }




    }

    
}
