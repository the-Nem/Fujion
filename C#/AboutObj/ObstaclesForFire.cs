using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesForFire : MonoBehaviour
{
    public List<GameObject> ObstaclesFire = new List<GameObject>();

    public GameObject ObstacleForBouth;
    public GameObject FireObstacle1;


    private void Awake()
    {
        AssingObjToList();
        CreateObstaclesForFire();
    }
    public void AssingObjToList()
    {
        ObstaclesFire.Add(ObstacleForBouth);
        ObstaclesFire.Add(FireObstacle1);
        ObstaclesFire.Add(ObstacleForBouth);
        ObstaclesFire.Add(ObstacleForBouth);
    }
    public void CreateObstaclesForFire()
    {
        for (float i = 0; i < 29; i++)
        {
            float RandPos = Random.Range(10f * i, 12f * i);
            int RandomObj = Random.Range(0, ObstaclesFire.Count);
            Instantiate(ObstaclesFire[RandomObj], new Vector3(RandPos, 1f, 0), Quaternion.identity);
        }
    }
}
