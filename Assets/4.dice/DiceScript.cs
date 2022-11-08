using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        diceVelocity = rb.velocity;
        // 스페이스바를 누를 때
        if (Input.GetKeyDown (KeyCode.Space))
        {
            // 주사위 회전
            DiceNumberTextScript.diceNumber1 = 0;
            DiceNumberTextScript.diceNumber2 = 0;
            DiceNumberTextScript.diceNumber3 = 0;
            DiceNumberTextScript.diceNumber4 = 0;
            DiceNumberTextScript.diceNumber5 = 0;
            float dirX = Random.Range(78, 494);
            float dirY = Random.Range(34, 476);
            float dirZ = Random.Range(7, 478);
            // 주사위 위치
            transform.position = new Vector3(Random.Range(-7, 7),8,Random.Range(-7, 7));
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 500);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
