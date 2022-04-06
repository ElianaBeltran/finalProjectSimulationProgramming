using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float j = Input.GetAxis("Jump");

        Vector3 vector3 = transform.position;
        vector3.x += v * speed * Time.deltaTime;
        vector3.z += h * speed * Time.deltaTime;
        vector3.y += j * speed * Time.deltaTime;

        transform.position = vector3;

    }
}
