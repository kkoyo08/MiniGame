using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObjectController : MonoBehaviour
{
    IEnumerator Start()
    {
        while (true)
        {
            this.transform.position = new Vector3(this.transform.position.x - 0.05f, 0, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
