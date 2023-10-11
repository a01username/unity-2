using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    public TMP_Text scoreText;
    // DECLARE VARIABLES HERE
    private int currentNum;
    public int score = 0;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        // INITIALIZE CURRENTNUM HERE
        currentNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // INCREMENT AND PRINT CURRENTNUM HERE
        currentNum++;
        Debug.Log("CurrentNum: " + currentNum);

        // Uncomment the code below and complete 
        // the if statement to check if Mouse0 is clicked 
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}