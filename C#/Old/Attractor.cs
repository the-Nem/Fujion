using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
	//const float G = 667.4f;
	//private float G = 667.4f;
	[SerializeField] private float G = 700f;


	private bool boolG;

	public static List<Attractor> Attractors;

	public Rigidbody2D rb;
    private void Update()
    {
		if (GameManager.gameStatus == false) { return; }
		ChangeG();
        if (JumpForFire.instance.IsItOKtoJumpFire) { boolG=true; }
    }


    void FixedUpdate()
	{
		foreach (Attractor attractor in Attractors)
		{
			if (attractor != this)
				Attract(attractor);
		}
	}

	void OnEnable()
	{
		if (Attractors == null)
			Attractors = new List<Attractor>();

		Attractors.Add(this);
	}

	void OnDisable()
	{
		Attractors.Remove(this);
	}

	void Attract(Attractor objToAttract)
	{
		Rigidbody2D rbToAttract = objToAttract.rb;

		Vector3 direction = rb.position - rbToAttract.position;
		float distance = direction.magnitude;

		if (distance == 0f)
			return;

		float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
		Vector3 force = direction.normalized * forceMagnitude;

		rbToAttract.AddForce(force);
	}
    private void ChangeG()
    {
        if (boolG) { G = 0; boolG = false; }
        else if (boolG==false){ G = 700f; }
    }
}
