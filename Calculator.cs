using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using System;

public class Calculator : MonoBehaviour
{
    public Text res;
    public Text shower;
    public string calc;
    public string x1;
    string x2 = "";
    
    

    public void On_Click_Bttn()
    {
        shower.text += calc;
    }

    public void Reset()
    {
        shower.text = "";
    }
    
    public void Calculate()
    {
        DataTable dt = new DataTable();
        x1=(dt.Compute(shower.text,"")).ToString();
        x2 = x1;
        x2= Math.Round(Convert.ToDouble(x2),3).ToString();
        x2 = x2.Replace(',','.');
        shower.text = x2;

        if (x2 == "")
        {
            res.text = "Немає розрахунків";
        }
        else
        {
            res.text = x2;
        }
    }

    public void Delete()
    {
       shower.text= shower.text.Remove(shower.text.Length-1,1);
    }

     void Start()
    {
        if (x2 == "")
        {
            res.text = "Немає розрахунків";
        }
        else
        {
            res.text = x2;
        }
    }
}
