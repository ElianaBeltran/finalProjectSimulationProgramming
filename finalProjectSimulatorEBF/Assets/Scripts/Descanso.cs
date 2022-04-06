using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descanso : MonoBehaviour
{
    public Energy energy;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            /* Debug.Log("Hey!");
             energy = other.GetComponent<Energy>();
             energy.energyLevel -= 15f;
             StartCoroutine(Waiting());*/

            AddEnergy();

        }

    }

    public void AddEnergy()
    {
        if (energy.energyLevel < 100)
        {

            energy.energyLevel += 0.05f;
            StartCoroutine(Waiting());
        }

    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1000.0f);
    }

}
