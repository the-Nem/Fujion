using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesForWater : MonoBehaviour
{
    public List<GameObject> ObstaclesWater = new List<GameObject>();

    public GameObject ObstacleForBouth;
    public GameObject WaterObstacle1;
    private int _quantituObstacles = 37;



    private void Awake()
    {
        AssingObjToList();
        CreateObstaclesForFire();
    }

    public void AssingObjToList()
    {
        ObstaclesWater.Add(ObstacleForBouth);
        ObstaclesWater.Add(WaterObstacle1);
        ObstaclesWater.Add(ObstacleForBouth);
        ObstaclesWater.Add(ObstacleForBouth);
    }
    public void CreateObstaclesForFire()
    {
        for (float i = 0; i < _quantituObstacles; i++)
        {
            float RandPos = Random.Range(8f * i, 9f * i);
            int RandomObj = Random.Range(0, ObstaclesWater.Count);
            Instantiate(ObstaclesWater[RandomObj], new Vector3(RandPos, -1f, 0), Quaternion.identity);
        }
    }
}
