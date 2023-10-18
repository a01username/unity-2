using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            print("collided with [insert name here]");
        }
        else if(collision.collider.CompareTag("Floor"))
        {

        }
        else
        {
            print("?");
        }

    }
}
