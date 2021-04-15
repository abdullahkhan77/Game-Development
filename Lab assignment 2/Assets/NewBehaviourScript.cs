using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 3;
    public int js = 10;
    public Animator animator;

    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent < Rigidbody2D >();

    }

    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", mov * speed);
        float movVer = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3(mov * speed, movVer * speed, 0);
        float jumsp = Input.GetAxis("Jump");
        Debug.Log(jumsp);
        if(jumsp>0)
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, js, 0);
        }
        else if (jumsp < 0)
        {

        }
    }
}
