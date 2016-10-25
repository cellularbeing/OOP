using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Text theText;

	public void OnPointerEnter(PointerEventData eventData)
	{
		//theText.color = Color.red;
		StartCoroutine ("textFader",theText);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		StopCoroutine ("textFader");
		theText.color = Color.white;
	}

	public IEnumerator textFader(Text a)
	{
		for(int k = 0; k <100; k++){
			a.color = Color.clear;
			for (int i=0; i<2; i++) 
			{
				a.color = Color.Lerp(Color.white, Color.red, (float)(i/(2f)));
				yield return new WaitForSeconds (0.001f);
			}
			a.color = Color.red;
			yield return new WaitForSeconds (.001f);
			for (int j=0; j<2; j++) 
			{
				a.color = Color.Lerp(Color.red, Color.yellow, (float)(j/(2f)));
				yield return new WaitForSeconds (0.001f);
			}
			a.color = Color.yellow;
			yield return new WaitForSeconds (.001f);
			for (int j=0; j<2; j++) 
			{
				a.color = Color.Lerp(Color.yellow, Color.blue, (float)(j/(2f)));
				yield return new WaitForSeconds (0.001f);
			}
			a.color = Color.blue;
			yield return new WaitForSeconds (.001f);
			for (int j=0; j<2; j++) 
			{
				a.color = Color.Lerp(Color.blue, Color.magenta, (float)(j/(2f)));
				yield return new WaitForSeconds (0.001f);
			}
		}

	}

}