using UnityEngine;
using System.Collections;

public class PieceScript : MonoBehaviour {
	
	public Vector3 startPosition, endPosition;
	public bool canMove = false, cancelPiece = false;

	private SpriteRenderer sprite;
	private float timeToLerp = 20;
	
	void Start(){
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	void Update(){
		if (canMove) {
			sprite.sortingOrder = 1;
			Vector3 mouseP = Input.mousePosition;
			mouseP.z = transform.position.z - Camera.main.transform.position.z;
			transform.position = Camera.main.ScreenToWorldPoint (mouseP);
		} 
		
		if (cancelPiece)
			CancelPiece ();
	}
	
	void CancelPiece(){
		GameManager.currentPiece = null;
		transform.position = Vector2.MoveTowards (transform.position, startPosition, Time.deltaTime * timeToLerp);
		canMove = false;
		if (transform.position == startPosition) {
			sprite.sortingOrder = 0;
			cancelPiece = false;
		}
	}
	
	
	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0) && !cancelPiece && GameManager.currentPiece == null) {
			GameManager.currentPiece = gameObject;
			canMove = true;
		}
		if (Input.GetMouseButtonDown (1) && !cancelPiece && canMove)
			cancelPiece = true;
	}
}
