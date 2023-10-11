using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    private bool isPaused;
    public TMP_Text pausedText;
    public TMP_Text loadingText;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
                
            }
        }
        if(Input.GetKeyDown("space"))
        {
            //START COROUTINE HERE
            
            //END OF CODE
        }
    }

    void PauseGame()
    {
        //WRITE CODE HERE


        //END OF CODE
        pausedText.enabled = true;
        pausedText.gameObject.SetActive(true);
    }
    
    void ResumeGame()
    {
        //WRITE CODE HERE
        

        //END OF CODE
        pausedText.gameObject.SetActive(false);
        pausedText.enabled = false;
        
    }

    //CREATE COROUTINE HERE
    
    //END OF CODE
}
