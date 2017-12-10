using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DetectClics : MonoBehaviour {

	public Text playTxt, gameName;
	public GameObject buttons, m_cube;
	private bool clicked;

	void OnMouseDown (){
		if (!clicked) {
			clicked = true;
			playTxt.gameObject.SetActive (false);
			gameName.text = "0\n ";
			buttons.GetComponent <ScrollObjects> ().speed = -10f;
			buttons.GetComponent <ScrollObjects> ().checkPos = -130f;
			m_cube.GetComponent<Animation> ().Play ("StartGameCube");
		}
	}
}
