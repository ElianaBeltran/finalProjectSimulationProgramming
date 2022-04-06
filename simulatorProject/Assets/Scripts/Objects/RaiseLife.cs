using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseLife : MonoBehaviour
{
    public PlayerFeatures life;
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

                RaiseLevelLife();
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
    private void RaiseLevelLife()
    {
        if (life.playerLife > 0 && life.playerLife < 100)
        {
            life.playerLife += 5.0f;

        }
        if(life.playerLife > 100)
        {
            life.playerLife = 100;
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
