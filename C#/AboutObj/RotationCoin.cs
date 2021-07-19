using UnityEngine;

public class RotationCoin : MonoBehaviour
{
    public float speedOfRotation = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speedOfRotation, 0,Space.World);
    }
}
