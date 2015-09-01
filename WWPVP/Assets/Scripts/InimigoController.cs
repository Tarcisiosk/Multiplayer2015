using UnityEngine;
using System.Collections;

public class InimigoController : MonoBehaviour {
	public float Cd = 0.2f;
	public float Velocity = 10;
	public int ocila = 9;
	private int iLv = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		iLv+=ocila;
		transform.GetComponent<Rigidbody2D>().velocity = new Vector3(Velocity, Mathf.Cos((iLv/360)), 0);
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		GameObject.Destroy (gameObject);
	}
}
