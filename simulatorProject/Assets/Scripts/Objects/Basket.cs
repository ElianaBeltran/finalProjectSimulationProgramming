using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public GameObject cabbage;


    private void onCollisionEnter(Collider other)
    {
        Debug.Log("Weyyy");
        if (other.tag.Equals("Lettuce"))
        {
            Destroy(cabbage);
        }
    }

    }

