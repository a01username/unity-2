using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingTarget : MonoBehaviour
{
    private float randX;
    private float randY;
    private float randZ;
    // Start is called before the first frame update
    void Start()
    {
        //WRITE CODE HERE
        
        //END OF CODE

        transform.position = new Vector3(randX, randY, randZ);

    }

}
