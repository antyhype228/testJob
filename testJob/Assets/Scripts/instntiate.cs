using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instntiate : MonoBehaviour
{
   public GameObject but;
   private GameObject clone;

   public void CreateButton()
   {
       Debug.Log("Hello there!");
     clone =  Instantiate(but,but.transform.position, Quaternion.identity);
     clone.SetActive(true);
   }
}
