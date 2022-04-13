using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorObject : MonoBehaviour
{
    public PlayerFeatures life;
    MeshRenderer meshRenderer;
    BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;
        boxCollider = GetComponent<BoxCollider>();
        boxCollider.enabled = true;
    }


    bool touched = true;
    private void OnTriggerEnter(Collider other)
    {
        if (touched == true)
        {
            if (other.gameObject.tag == "Player")
            {

                LowerLevelLife();
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
    private void LowerLevelLife()
    {
        if (life.playerLife > 0)
        {
            life.playerLife -= 10.0f;

        }
        if (life.playerLife < 0)
        {
            life.playerLife = 0;
        }

    }
    private void HideMesh()
    {
        meshRenderer.enabled = false;
        boxCollider.enabled = false;


    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1.0f);
    }

    private void AppearMesh()
    {
        meshRenderer.enabled = true;
        boxCollider.enabled = true;

    }
}
