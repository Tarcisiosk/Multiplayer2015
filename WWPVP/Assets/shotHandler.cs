using UnityEngine;
using System.Collections;

public class shotHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "projectile")
		{
			Physics.IgnoreLayerCollision(8, 8, true);
		}
		GameObject.Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
