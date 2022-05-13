using UnityEngine;
using System.Collections;

public class PlayerFire : MonoBehaviour {
	public GameObject bolt;
	public bool spread=false;
	public float bulletSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			if(spread)
			{
				GameObject a = Instantiate(bolt, transform.position, transform.rotation) as GameObject;
				GameObject b = Instantiate(bolt, transform.position, transform.rotation) as GameObject;
				GameObject c = Instantiate(bolt, transform.position, transform.rotation) as GameObject;
				
				a.rigidbody2D.AddForce(new Vector2(0,0));
				b.rigidbody2D.AddForce(new Vector2(0,-100));
				c.rigidbody2D.AddForce(new Vector2(0,100));
			}
			else
			{
				Instantiate(bolt, transform.position, transform.rotation);
			}
			
		}
	}
}
