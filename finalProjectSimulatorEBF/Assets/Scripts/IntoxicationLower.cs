using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntoxicationLower : MonoBehaviour
{
    public Intoxicacion lowIntox;
    MeshRenderer meshRenderer;
    CapsuleCollider capsuleCollider;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;
        capsuleCollider = GetComponent<CapsuleCollider>();
        capsuleCollider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool touched = true;
    private void OnTriggerEnter(Collider other)
    {
        if (touched == true)
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

                LowIntoxication();
                HideMesh();
                touched = false;


            }
        }
        if (touched == false)
        {
            Invoke("AppearMesh", 5.0f);
            touched = true;
            //LowIntoxication();

        }
    }
    private void LowIntoxication()
    {
        if (lowIntox.intoxication.intoxicationLevel > 0)
        {
            lowIntox.intoxication.intoxicationLevel -= 5.0f;
            
        }
        if(lowIntox.intoxication.intoxicationLevel < 0)
        {
            lowIntox.intoxication.intoxicationLevel = 0;
            
        }
    }
    private void HideMesh()
    {
        meshRenderer.enabled = false;
        capsuleCollider.enabled = false;

        
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1.0f);
    }

    private void AppearMesh()
    {
        meshRenderer.enabled = true;
        capsuleCollider.enabled = true;
        //StartCoroutine(Timer());
    }
}
