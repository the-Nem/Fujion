using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassBornObjs 
{

    //Delete this

    //public List<GameObject> Obstacles = new List<GameObject>();
    public List<GameObject> Obstacles ;

    public GameObject ObstacleForBouth;
    public GameObject ObstacleForBouth2;
 
    public GameObject FireObstacle1;



    private void Awake()
    {
        AssingObjToList();
        CreateObstaclesForFire();
    }

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) { CreateObstaclesForFire(); }
    }

    public void AssingObjToList()
    {
        Obstacles.Add( ObstacleForBouth);
        Obstacles.Add(FireObstacle1);
        Obstacles.Add(ObstacleForBouth);    
    }
    public void CreateObstaclesForFire()
    {
        for (float i = 9; i < 90f; i += 9f)
        {
            int RandomObj = Random.Range(0, Obstacles.Count);
            //Instantiate(Obstacles[RandomObj], new Vector3(i,1f,0), Quaternion.identity);
        }

    }
}
