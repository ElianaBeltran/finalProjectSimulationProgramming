using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public PlayerFeatures life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            LowerLevelLife();
        }
    }

    private void LowerLevelLife()
    {
        if (life.playerLife > 0)
        {
            life.playerLife -= 5.0f;

        }
        if (life.playerLife < 0)
        {
            life.playerLife = 0;
        }

    }
}
