using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DetectClics : MonoBehaviour {

	public Text playTxt, gameName;

	void OnMouseDown (){
		playTxt.gameObject.SetActive (false);
		gameName.text = "0";
	}
}
