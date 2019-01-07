using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	public Text text;
	public static GameObject currentPiece;
	public static int currentScore, scoreTotal;
	
	void Update(){
		if (currentScore == scoreTotal)
			text.gameObject.SetActive (true);
	}
}
