using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	private int health;
	private bool dead;
	// Use this for initialization
	void Start () {
		dead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			dead = true;
		}
	}
		
	public bool isDead(){
		return dead;
	}
	public void setHealth(int h){
		health = h;
		print (health);
	}
	public void takeDamage(){
		health--;
		print (health);
	}

	public void takeDamage(int d){
		health = health - d;
	}


}
