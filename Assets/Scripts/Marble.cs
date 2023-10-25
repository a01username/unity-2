using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Marble : MonoBehaviour
{
    public float speed = 10f;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 curr_pos = this.transform.position;
            Vector3 target_pos = target.transform.position;
            float move_speed = speed * Time.deltaTime;
            
            //WRITE CODE HERE 
            this.transform.position = Vector3.MoveTowards(curr_pos, target_pos, move_speed);
            //END OF CODE
            if(Vector3.Distance(curr_pos, target_pos) < 0.1f)
            {
                this.transform.position = new Vector3(0, 0, -7.1f);
            }
        }
    }
}
