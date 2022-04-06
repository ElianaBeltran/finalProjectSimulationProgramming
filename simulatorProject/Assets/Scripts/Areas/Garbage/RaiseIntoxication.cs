using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseIntoxication : MonoBehaviour
{
    public PlayerFeatures intoxication;
    public PlayerFeatures life;
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            RaiseLevelIntoxication();

        }

    }

    public void RaiseLevelIntoxication()
    {
        if (intoxication.intoxicationLevel >= 0)
        {
            Debug.Log("Hey!");
            intoxication.intoxicationLevel += 0.05f;

        }
        if (intoxication.intoxicationLevel > 50)
        {
            Debug.Log("Hey!");
            if (life.playerLife > 0)
            {
                life.playerLife -= 0.05f;
            }

        }

    }
}
