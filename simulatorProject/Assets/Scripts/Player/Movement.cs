using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    Animator animator;
   

    private bool animWalk = false;
    private bool animIdle = true;
    private bool animAttack = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // animator = GetComponent<Animator>();

        AnimationsCalls();
            
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            float jump = Input.GetAxis("Jump");


            Vector3 vector3 = transform.position;
            vector3.x += vertical * speed * Time.deltaTime;
            vector3.z += horizontal * speed * Time.deltaTime;
            vector3.y += jump * speed * Time.deltaTime;

            transform.position = vector3;

        /* if(vector3.x > 0 || vector3.x <0)
         {
             animWalk = true;
             animIdle = false;
             Debug.Log("1");

         }
         if (vector3.x == 0)
         {
             animWalk = false;
             animIdle = true;
             Debug.Log("4");

         }*/
       
        if (horizontal != 0 || vertical !=0)
        {

            animWalk = true;
            animIdle = false;
            //animAttack = false;
        }
        //if(vertical == 0 || horizontal == 0)
        else
        {
            animWalk = false;
            //animAttack= false;
            animIdle = true;
        }
        //Debug.Log(animAttack);
    }
    public void AnimationsCalls()
    {  // anim = GetComponent<Animator>();
        
        if (animIdle == true)
        {
            animator.Play("Idle");
           // animWalk = false;
            //animator.SetBool("Walk", false);
            // Debug.Log("2");
        }

        if (animWalk == true)
        {
            animator.Play("Walk");
            //animator.SetBool("Walk", true);
           // Debug.Log("3");
        }
        if (Input.GetMouseButtonDown(0) == true)
        {
            
            animAttack = true;
            //animIdle = false;
            //animWalk = false;
            if (animAttack == true)
            {
                //Debug.Log("hey");
                animator.Play("Attack");
                animAttack = false;
                
            }

        }


    }
}
