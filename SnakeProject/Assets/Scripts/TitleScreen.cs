using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

	public void PlayGame() {
		SceneManager.LoadScene("PlayerSelect");
	}

	public void OptionsMenu() {
		SceneManager.LoadScene("OptionsMenu");
	}

	public void QuitGame() {
		Application.Quit();
	}

}
