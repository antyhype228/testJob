using UnityEngine.UI;
using UnityEngine;

public class scoreSystem : MonoBehaviour
{
    
    public GameObject scoreText;
    public static int score;

   
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
