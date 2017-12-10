using System.Collections;
using UnityEngine;

public class ScrollObjects : MonoBehaviour {

	public float spead = 3f, checkPos = 0f;
	private RectTransform rec;

	void Start (){
		rec = GetComponent <RectTransform> ();
		}

	void Update () {
		if (rec.offsetMin.y != checkPos) {
			rec.offsetMin += new Vector2 (rec.offsetMin.x, spead);
			rec.offsetMax += new Vector2 (rec.offsetMax.x, spead);
		}
	}
}
