using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public bool isP1;
	public float velocity = 20;
	public int health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(isP1)
		{
			if(Input.GetKey(KeyCode.W))
			{
				this.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, velocity));
			}
			if(Input.GetKey(KeyCode.S))
			{
				this.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, -velocity));

			}
			if(Input.GetKey(KeyCode.A))
			{
				this.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-velocity, 0));

			}
			if(Input.GetKey(KeyCode.D))
			{
				this.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(velocity, 0));

			}
		}
		else
		{
			if(Input.GetKey(KeyCode.UpArrow))
			{
				this.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, velocity));
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				this.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, -velocity));
				
			}
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				this.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-velocity, 0));
				
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				this.gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(velocity, 0));
				
			}
		}
	}
}
