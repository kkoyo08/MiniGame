using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public GameObject[] mapObjectPrefab = new GameObject[3];
    public MapObjectController mapObjectController;

    public void MapColliderOn()
    {
        int check = Random.Range(0, mapObjectPrefab.Length);
        GameObject mapPrefab = Instantiate(mapObjectPrefab[check]);
        mapPrefab.transform.position = new Vector3(40, 0, 0);
        mapPrefab.transform.parent = mapObjectController.gameObject.transform;
    }
}
