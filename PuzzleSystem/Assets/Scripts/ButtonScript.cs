using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
	
	public Image img;
	private bool isEnabled = false;
	
	public void ClickVewImage(){
		isEnabled = !isEnabled;
		if (isEnabled)
			img.gameObject.SetActive (true);
		else 
			img.gameObject.SetActive (false);
	}
	
	public void RestartLevel(){
		Application.LoadLevel (0);
	}
}
