using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabbage : MonoBehaviour
{
    public bool isTook;

    public bool isCooking;
    public GameObject basket;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag.Equals("Player") && isTook == false)
        {
            isTook = true;
            // Destroy(gameObject);
            gameObject.transform.SetParent(other.gameObject.transform);
            //ScoreManager.instance.AddPointPedido();
        }
        if (other.tag == "Basket" && isTook == true)
        {
            basket.transform.SetParent(other.gameObject.transform);
            Destroy(this.gameObject);
            isTook=false;
        }
       

    }
}
