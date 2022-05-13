using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	public int speed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical")) * speed;
		
		rigidbody2D.position = new Vector2(
			Mathf.Clamp(rigidbody2D.position.x,-4,4),
			Mathf.Clamp(rigidbody2D.position.y,-3,3)
			);
	}
	
}