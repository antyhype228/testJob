using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delaying : MonoBehaviour
{
    public  GameObject butt ;
    public GameObject myMm;
    // Start is called before the first frame update
  public  void Le_Activation()
    {
     // Invoke("act",.1f);
      
     StartCoroutine(del());
     StopCoroutine(del());
    }

  void act()
  {
    myMm.SetActive(false);
    butt.SetActive(true);
  }

  IEnumerator del()
  {
    yield return new WaitForSeconds(.5f);
    myMm.SetActive(false);
    butt.SetActive(true);
  }
}
