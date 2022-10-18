using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "MapObject")
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
    }
}
