using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingTarget : MonoBehaviour
{
    private float randX;
    private float randY;
    private float randZ;
    public GameObject marble;
    // Start is called before the first frame update
    void Start()
    {
        //WRITE CODE HERE
        randX = Random.Range(-25, 25);
        randY = Random.Range(0, 13);
        randZ = Random.Range(4, 14);
        //END OF CODE

        transform.position = new Vector3(randX, randY, randZ);

    }
    void Update()
    {
        Vector3 curr_pos = this.transform.position;
        Vector3 target_pos = marble.transform.position;
        
        
        if (Input.GetMouseButtonDown(0))
        {
            randX = Random.Range(-25, 25);
            randY = Random.Range(0, 13);
            randZ = Random.Range(4, 14);
            //END OF CODE

            transform.position = new Vector3(randX, randY, randZ);
        }

        if (Vector3.Distance(curr_pos, target_pos) < 0.1f)
        {
            randX = Random.Range(-25, 25);
            randY = Random.Range(0, 13);
            randZ = Random.Range(4, 14);
            //END OF CODE

            transform.position = new Vector3(randX, randY, randZ);
        }
    }

}
