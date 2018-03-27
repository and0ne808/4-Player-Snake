using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour {

	private bool player1Selected = false;
	private bool player2Selected = false;
	private bool player3Selected = false;
	private bool player4Selected = false;

	public Text player1Text;
	public Text player2Text;
	public Text player3Text;
	public Text player4Text;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("joystick 1 button 7")) {
			player1Selected = true;
			player1Text.text = "Player 1 Selected";
		}
		if (Input.GetKeyDown("joystick 2 button 7")) {
			player2Selected = true;
			player2Text.text = "Player 2 Selected";
		}
		if (Input.GetKeyDown("joystick 3 button 7")) {
			player3Selected = true;
			player3Text.text = "Player 3 Selected";
		}
		if (Input.GetKeyDown("joystick 4 button 7")) {
			player4Selected = true;
			player4Text.text = "Player 4 Selected";
		}
	}
}
