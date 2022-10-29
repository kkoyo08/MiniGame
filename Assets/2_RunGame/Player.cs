using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float force;
    bool isGround = true;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Wall.isGame)
        {
            if(Input.GetKeyDown(KeyCode.Space) && isGround)
            {
                isGround = false;
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, force));
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
}
