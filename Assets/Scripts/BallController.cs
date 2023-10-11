using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    public float updateCounter = 0;
    public float fixedUpdateCounter = 0;
    private MeshRenderer mr;
    public TMP_Text updateText;
    public TMP_Text fixedUpdateText;
    //Declare and intialize updateCounter and fixedUpdateCounter here
    
    //Declare mr here
    

    // Start is called before the first frame update
    void Start()
    {
        //Set mr to get MeshRenderer component here
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update(){
        updateCounter++;
        //disable MeshRenderer component below
        mr.enabled = false;
        //increment updateCounter by 1 below
        
        //END OF CODE
        
        //Uncomment line below when update function is completed
        updateText.text = "Update Counter: " + updateCounter.ToString();
        
    }
    
    //Create FixedUpdate function below
    void FixedUpdate()
    {
        //increment fixedUpdateCounter by 1 and update fixedUpdateText below
        fixedUpdateCounter++;
        fixedUpdateText.text = "Fixed Update Counter: " + fixedUpdateCounter.ToString();
        //END OF CODE
    }
}
