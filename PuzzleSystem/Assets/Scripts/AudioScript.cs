using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour {
	public GameObject manager;
	public Sprite noSound, sound;
	private bool mute = false;
	
	public void Click(){
		mute = !mute;
		if (mute) {
			manager.GetComponent<AudioSource> ().enabled = false;
			GetComponent<Image> ().sprite = sound;
		} else {
			manager.GetComponent<AudioSource> ().enabled = true;
			GetComponent<Image> ().sprite = noSound;
		}
	}
}
