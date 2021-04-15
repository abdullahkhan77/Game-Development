using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplescript : MonoBehaviour
{
    public int speed = 8;
public Rigidbody2D rigidbody1;
    // Start is called before the first frame update
    void Start()
    {
    rigidbody1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        Debug.Log("mov");
    rigidbody1.velocity = new Vector3(mov * speed,rigidbody1.velocity.y,0);
    if(Input.GetKeyDown(KeyCode.Space))
    {
        rigidbody1.velocity = new Vector3(rigidbody1.velocity.y, 3* speed);
    }
    
    }
}
