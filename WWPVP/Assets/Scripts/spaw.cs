using UnityEngine;
using System.Collections;

public class spaw : MonoBehaviour {
	public GameObject inimigo; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			print(Input.mousePosition);
			Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,10.0f));
			print(p);
			print(p.x);
			print(p.y);
			
			Instantiate(inimigo,new Vector3(p.x,p.y, 0.0f),Quaternion.identity);
			//Instantiate(inimigo, Input.mousePosition, transform.rotation);
		}
	}
}
