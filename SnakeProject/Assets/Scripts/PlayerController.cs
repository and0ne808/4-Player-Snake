using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1;
	public string direction = "Right";
	public int playerNum = 1;
	private string moveHorizontal, moveVertical;

	// Use this for initialization
	void Start () {
		/*if (GameObject.Find("PlayerSelectCanvas").GetComponent<PlayerSelect>().player1Selected != true && playerNum == 1) {
			this.gameObject.SetActive(false);
		}
		if (GameObject.Find("PlayerSelectCanvas").GetComponent<PlayerSelect>().player2Selected != true && playerNum == 2) {
			this.gameObject.SetActive(false);
		}
		if (GameObject.Find("PlayerSelectCanvas").GetComponent<PlayerSelect>().player3Selected != true && playerNum == 3) {
			this.gameObject.SetActive(false);
		}
		if (GameObject.Find("PlayerSelectCanvas").GetComponent<PlayerSelect>().player4Selected != true && playerNum == 4) {
			this.gameObject.SetActive(false);
		}*/
		moveHorizontal = "Player" + playerNum + "Horizontal";
		moveVertical = "Player" + playerNum + "Vertical";
	}
	
	// Update is called once per frame
	void Update () {
		updateDirection();
		movePlayer();
	}

	void updateDirection() {
		if (Input.GetAxis(moveHorizontal) > 0 && direction != "Left") {
			direction = "Right";
		} else if (Input.GetAxis(moveHorizontal) < 0 && direction != "Right") {
			direction = "Left";
		} else if (Input.GetAxis(moveVertical) > 0 && direction != "Up") {
			direction = "Down";
		} else if (Input.GetAxis(moveVertical) < 0 && direction != "Down") {
			direction = "Up";
		}
	}

	void movePlayer() {
		Vector2 currentPosition = this.transform.position;
		if (direction == "Right") {
			setPosition(currentPosition.x + speed, currentPosition.y);
		} else if (direction == "Left") {
			setPosition(currentPosition.x - speed, currentPosition.y);
		} else if (direction == "Up") {
			setPosition(currentPosition.x, currentPosition.y + speed);
		} else if (direction == "Down") {
			setPosition(currentPosition.x, currentPosition.y - speed);
		}
	}

	void setPosition(float x, float y) {
		this.transform.position = new Vector2(x, y);
	}
}
