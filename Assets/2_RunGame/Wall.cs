using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wall : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject[] Ground = new GameObject[2];
    

    public static bool isGame = true;

    void Update()
    {
        if (isGame)
        {
            speed += 0.1f * Time.deltaTime;

            for(int i=0; i<2; i++)
            {
                Move(Ground[i]);
                if (Ground[i].transform.position.x <= -2)
                {
                    Ground[i].transform.position = new Vector3(2, Ground[i].transform.position.y, 0);
                }
            }

        }    
    }
    void Move(GameObject obj)
    {
        obj.transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isGame = false;
        }
    }
}
