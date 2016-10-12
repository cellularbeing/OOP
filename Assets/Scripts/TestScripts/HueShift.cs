using UnityEngine;
using System.Collections;

public class HueShift : MonoBehaviour {

	public float Speed = 0.25f;
	private SpriteRenderer rend;

	void Start()
	{
		//gameObject.GetComponent<SpriteRenderer>().color=new Color(health/100f, health/100f, 1, 1);

		rend = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		rend.color = Color.HSVToRGB(Mathf.PingPong(Time.time * Speed, 1), 1, 1);
	}
}
