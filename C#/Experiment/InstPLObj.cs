using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstPLObj : MonoBehaviour
{
    private GameObject PapaResFire1;



    private void Awake()
    {
        var plGobj = Resources.Load("PapaResFire1");
        PapaResFire1 = plGobj as GameObject;

    }


    // Start is called before the first frame update
    void Start()
    {
        SpawnResource();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) { MoveLittleBit(); }
    }

    public void SpawnResource()
    {
        Instantiate(PapaResFire1, new Vector3(-2, 3f, 0), Quaternion.identity);
    }
    public void MoveLittleBit()
    {
        PapaResFire1.transform.position = new Vector3(PapaResFire1.transform.position.x + 2f, 4f,0);
    }
}
