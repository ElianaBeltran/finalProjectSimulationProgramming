using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerIntoxication : MonoBehaviour
{
    public RaiseIntoxication lowIntox;
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


    bool touched = true;
    private void OnTriggerEnter(Collider other)
    {
        if (touched == true)
        {
            if (other.gameObject.tag == "Player")
            {

                LowIntoxication();
                HideMesh();
                touched = false;


            }
        }
        if (touched == false)
        {
            Invoke("AppearMesh", 5.0f);
            touched = true;

        }
    }
    private void LowIntoxication()
    {
        if (lowIntox.intoxication.intoxicationLevel > 0)
        {
            lowIntox.intoxication.intoxicationLevel -= 5.0f;

        }
        if (lowIntox.intoxication.intoxicationLevel < 0)
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

    }
}
