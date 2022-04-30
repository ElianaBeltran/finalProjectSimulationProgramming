using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplesCollisions : MonoBehaviour
{
    [SerializeField]
    private ScoreManager _ui;


    //public float lifeObject = 60;
    //public GameObject col;
    // Start is called before the first frame update


    // Update is called once per frame
    /*void Update()
    {
        if(lifeObject <= 0){
            var env = Instantiate(col, transform.position, transform.rotation);
			Destroy(env, 2.0f);
			Destroy(this.gameObject);
        }
    }*/

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            //lifeObject = lifeObject - 20;

            Destroy(this.gameObject);
            if (_ui != null)
            {
                _ui.GetPoint(2);
            }
            else
                Debug.Log("El enemigo no tiene UI asignado");
        }
    }
}
