using UnityEngine;
using System.Collections;

public class ShipShooter : MonoBehaviour {

	public GameObject shot1;
	public GameObject shot2;

	public int shotLv;

	public GameObject shotPos;

	public bool isP1;
	public bool canShoot;

	public float shotCd = 0.2f;
	public float shotVelocity = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(shotCd < 0)
		{
			canShoot = true;
			shotCd = 0.2f;
		}
		else
		{
			shotCd -= Time.deltaTime;
			canShoot = false;
		}

		if(isP1)
		{
			if(Input.GetKey(KeyCode.LeftShift) && canShoot)
			{
				for(int i = 0; i < shotLv; i ++)
				{
					GameObject shot = (GameObject)Instantiate(shot1, shotPos.transform.position, Quaternion.identity);
					shot.GetComponent<Rigidbody2D>().velocity = new Vector3(shotVelocity * Mathf.Cos(30 * i), Mathf.Sin(30 * i) * 3, 0);
				}
			}
		}
		else
		{
			if(Input.GetKey(KeyCode.RightShift) && canShoot )
			{
				for(int i = 0; i < shotLv; i ++)
				{
					GameObject shot = (GameObject)Instantiate(shot1, shotPos.transform.position, Quaternion.identity);
					shot.GetComponent<Rigidbody2D>().velocity = new Vector3(shotVelocity * Mathf.Cos((shotLv/360) * i), Mathf.Cos((shotLv/360) * i), 0);
				}
			}
		}
	}
}
