using UnityEngine;
using System.Collections;

public class snakemovement : MonoBehaviour{
	public float speed;
	private Transform t;
	private float prev;
	private float newX;
	private GameObject g;
	private Rigidbody2D rb;
	private BoxCollider2D bc;
	private Enemy e;
	public int health;
	private Vector3 speedvec;
	private SpriteRenderer sr;
	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer> ();
		t = gameObject.GetComponent<Transform> ();
		bc = gameObject.GetComponent<BoxCollider2D> ();
		newX = t.position.x;
		e = gameObject.GetComponent<Enemy>();
		print (health);
		e.setHealth (health);
		speedvec = new Vector3 (speed,0,0);
		prev = t.position.x;
	}

	// Update is called once per frame
	void Update () {
		
		t.Translate (speedvec);
		if (Mathf.Abs(prev - t.position.x) < speed/2) {
			if (sr.flipX == true)
				sr.flipX = false;
			else
				sr.flipX = true;
			speedvec = speedvec * -1;
		}
		prev = t.position.x;
	}
}
