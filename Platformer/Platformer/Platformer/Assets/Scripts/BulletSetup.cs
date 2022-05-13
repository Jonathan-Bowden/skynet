using UnityEngine;
using System.Collections;

public class BulletSetup : MonoBehaviour {
	
	private GameObject player;
	public float BulletSpeed;
	
	
	
	// Use this for initialization
	void Start () 
	{
		var mouse = Input.mousePosition;
		var screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
		var offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);
		var angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0, 0, angle);

		Vector2 target = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,  Input.mousePosition.y) );
		Vector2 myPos = new Vector2(transform.position.x,transform.position.y );
		Vector2 direction = target - myPos;
		//direction.Normalize();
		//Quaternion rotation = Quaternion.Euler( 0, 0, Mathf.Atan2 ( direction.y, direction.x ) * Mathf.Rad2Deg );
		rigidbody2D.velocity = direction * BulletSpeed;

		player = GameObject.Find ("Ship");
		//move forward
		
		//make sound
	}
	//create particles
	
	//warp the bullet to where player currently is
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D collider)
	{
		Destroy(gameObject);
		if(rigidbody2D.velocity.x < 5)
		{
			Destroy(gameObject);
		}
	}
	void Update () {
		
	}
}