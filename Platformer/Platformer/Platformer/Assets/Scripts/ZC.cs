using UnityEngine;
using System.Collections;

public class ZC : MonoBehaviour {
	private GameObject player;
	private Transform playerCheck;
	public float detectionRadius = 5f;
	public LayerMask whatIsPlayer;
	public float speed = 2f;
	bool playerDetected = false;
	private Vector2 target;	
	private float health = 16;

	
	
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Ship");
		playerCheck = GameObject.Find ("Ship").transform;
		whatIsPlayer = GameObject.Find ("Ship").layer;
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Bullet(clone)");
						health--;
				
	}
	// Update is called once per frame
	void Update () {

		Vector2 myPos = new Vector2(transform.position.x,transform.position.y );
		
		playerDetected = Physics2D.OverlapCircle (myPos/*playerCheck.transform*/, detectionRadius, whatIsPlayer);
		
		target = transform.position;//player.transform.position;
		
		if (playerDetected)
		{
			transform.position = Vector2.MoveTowards(transform.position, target, speed  * Time.deltaTime);
		}
		if (health < 1) {
			Destroy(gameObject);
				}
		
		
	}
}