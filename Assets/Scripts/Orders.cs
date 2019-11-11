using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 


public class Orders : MonoBehaviour
{
    //tacos
    public InputField beef;
    public InputField pork;
    public InputField chicken;
    //combos
    public InputField mix;
    public InputField sampler;
    public InputField beef2;
    public InputField beef3;
    //drinks
    public InputField coke;
    public InputField royal;
    public InputField dew;
    public InputField water;



    public InputField txt;


    string str1;
    string str2;
    string str3;

    string str4;
    string str5;
    string str6;
    string str7;

    string str8;
    string str9;
    string str10;
    string str11;

    string result;

    int a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11;


    //TACOS
    int Beef = 40;
    int Pork = 35;
    int Chicken=35; //₱

    //Combos
    int Mix=100;
    int Sampler=105;
    int TwoBeef=110;
    int ThreeBeef=115;

    //DRINKS
    int CRMBW = 20;
     

    int total;

    public void NumberOfOrders()
    {//tacos
     //str1 = beef.GetComponent<InputField>().text;
     //str2 = pork.GetComponent<InputField>().text;
     //str3 = chicken.GetComponent<InputField>().text;

        a1 = int.Parse(beef.GetComponent<InputField>().text);
        a2 = int.Parse(pork.GetComponent<InputField>().text);
        a3 = int.Parse(chicken.GetComponent<InputField>().text);

        //combos
        a4 = int.Parse(mix.GetComponent<InputField>().text);
        a5 = int.Parse(sampler.GetComponent<InputField>().text);
        a6 = int.Parse(beef2.GetComponent<InputField>().text);
        a7 = int.Parse(beef3.GetComponent<InputField>().text);


        //drinks
        a8 = int.Parse(coke.GetComponent<InputField>().text);
        a9 = int.Parse(royal.GetComponent<InputField>().text);
        a10 = int.Parse(dew.GetComponent<InputField>().text);
        a11 = int.Parse(water.GetComponent<InputField>().text);

        
       
        result = "Order(s)|Price(s)";

        str1 = "\n("+a1 + ")Beef-----|₱"+Beef*a1;
        str2 = "\n("+a2 + ")Pork-----|₱"+Pork*a2;
        str3 = "\n("+a3 + ")Chicken--|₱"+Chicken*a3;
        str4 = "\n("+a4 + ")Mix&Match|₱"+Mix*a4;
        str5 = "\n("+a5 + ")Sampler--|₱"+Sampler*a5;
        str6 = "\n("+a6 + ")2Beef----|₱"+TwoBeef*a6;
        str7 = "\n("+a7 + ")3Beef----|₱"+ThreeBeef*a7;
        str8 = "\n("+a8 + ")Coke-----|₱"+ CRMBW * a8;
        str9 = "\n("+a9 + ")Royal----|₱"+ CRMBW * a9;
        str10= "\n("+a10+ ")Mt.Dew---|₱"+ CRMBW * a10;
        str11= "\n("+a11+ ")Water----|₱"+ CRMBW * a11;
        // Debug.Log("Order(s)   \t Price(s) " +
        //            "\n Beef   \t php      " + a1+"");

            
        if (a1 > 0){
            result = result + str1;
        }
        else { }
        if (a2 > 0) {
            result = result + str2;

        }
        else { }
        if (a3 > 0)
        {
            result = result + str3;
        }
        else { }
        if (a4 > 0)
        {
            result = result + str4;
        }
        else { }
        if (a5 > 0)
        {
            result = result + str5;
        }
        else { }
        if (a6 > 0)
        {
            result = result + str6;
        }
        else { }
        if (a7 > 0)
        {
            result = result + str7;
        }
        else { }
        if (a8 > 0)
        {
            result = result + str8;
        }
        else { }
        if (a9 > 0)
        {
            result = result + str9;
            
        }
        else { }
        if (a10 > 0)
        {
            result = result + str10;
            
        }
        else { }
        if (a11 > 0)
        {
            result = result + str11;
            

        }
        else { }

         total = (Beef * a1) + (Pork * a2)+ (Chicken * a3)+ (Mix * a4)+ (Sampler * a5)+ (TwoBeef * a6)+ (ThreeBeef * a7)+ (CRMBW * a8)
            + (CRMBW * a9)+ (CRMBW * a10)+ (CRMBW * a11);

        
            if(total > 0){
        txt.GetComponent<InputField>().text = result +"\n \n Total = ₱"+ total;
        }
        //Debug.Log("Tacos: Beef: "+str1);
    }


}

