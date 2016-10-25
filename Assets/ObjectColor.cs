using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class ObjectColor : MonoBehaviour {

	void Update(){
		
	}
	public void OnPointerEnter(PointerEventData eventData)
	{
		//theText.color = Color.red;
		StartCoroutine ("objectFader");
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		StopCoroutine ("objectFader");
	}

	public IEnumerator textFader()
	{
		for(int k = 0; k <100; k++){
			this.gameObject.GetComponent<Renderer> ().material.color = Color.clear;
			for (int i=0; i<2; i++) 
			{
				this.gameObject.GetComponent<Renderer> ().material.color = Color.Lerp(Color.white, Color.red, (float)(i/(2f)));
				yield return new WaitForSeconds (0.001f);
			}
			this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			yield return new WaitForSeconds (.001f);
			for (int j=0; j<2; j++) 
			{
				this.gameObject.GetComponent<Renderer> ().material.color = Color.Lerp(Color.red, Color.yellow, (float)(j/(2f)));
				yield return new WaitForSeconds (0.001f);
			}
			this.gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
			yield return new WaitForSeconds (.001f);
			for (int j=0; j<2; j++) 
			{
				this.gameObject.GetComponent<Renderer> ().material.color = Color.Lerp(Color.yellow, Color.blue, (float)(j/(2f)));
				yield return new WaitForSeconds (0.001f);
			}
			this.gameObject.GetComponent<Renderer> ().material.color = Color.blue;
			yield return new WaitForSeconds (.001f);
			for (int j=0; j<2; j++) 
			{
				this.gameObject.GetComponent<Renderer> ().material.color = Color.Lerp(Color.blue, Color.magenta, (float)(j/(2f)));
				yield return new WaitForSeconds (0.001f);
			}
		}

	}
}
