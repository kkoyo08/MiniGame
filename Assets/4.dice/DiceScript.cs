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
        // �����̽��ٸ� ���� ��
        if (Input.GetKeyDown (KeyCode.Space))
        {
            // �ֻ��� ȸ��
            DiceNumberTextScript.diceNumber1 = 0;
            DiceNumberTextScript.diceNumber2 = 0;
            DiceNumberTextScript.diceNumber3 = 0;
            DiceNumberTextScript.diceNumber4 = 0;
            DiceNumberTextScript.diceNumber5 = 0;
            float dirX = Random.Range(78, 494);
            float dirY = Random.Range(34, 476);
            float dirZ = Random.Range(7, 478);
            // �ֻ��� ��ġ
            transform.position = new Vector3(Random.Range(-7, 7),8,Random.Range(-7, 7));
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 500);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }
}
