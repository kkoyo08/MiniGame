using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator ani;
    Rigidbody rigid;
    bool isGround = true;

    private void Awake()
    {
        ani = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (isGround)
        {
            rigid.AddForce(Vector3.up * 110, ForceMode.Impulse);
            StartCoroutine(AniStopCoroutine());
        }
    }

    IEnumerator AniStopCoroutine()
    {
        ani.speed = 0;
        yield return new WaitForSeconds(2f);
        ani.speed = 1;
    }

}
