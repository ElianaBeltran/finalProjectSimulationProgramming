using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public Energy energy;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("Hey!");
            //energy = other.GetComponent<Energy>();
            //energy.energyLevel -= 10f;
            /*if (energy.energyLevel > 0) {
                Debug.Log("Hey!");
                do { energy.energyLevel-=10;} 
                while (energy.energyLevel < 0);               
                    
            }*/

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            /* Debug.Log("Hey!");
             energy = other.GetComponent<Energy>();
             energy.energyLevel -= 15f;
             StartCoroutine(Waiting());*/

            RestEnergy();

        }

    }

    public void RestEnergy()
    {
        if (energy.energyLevel > 0)
        {
        
                energy.energyLevel -= 0.05f;
                StartCoroutine(Waiting());
        }
            
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1000.0f);
    }
}
