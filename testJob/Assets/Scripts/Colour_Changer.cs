using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colour_Changer : MonoBehaviour
{
    public Image myImage;
   public Dropdown m_DropDown;

   public void Colour_Change()
   {
     if(m_DropDown.value == 1 )
       myImage.color = Color.red;
     else if(m_DropDown.value == 2)
       myImage.color = Color.green;
     else if(m_DropDown.value == 0)
       myImage.color = new Color(229/255.0f,188/255.0f,161/255.0f);
   }
   
}
