using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

	// Use this for initialization
	public static float bottomY = -20f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY) {
			Destroy (this.gameObject);
			// Get a reference to the ApplePicker component of Main Camera
			ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
			// Callthe public AppleDestroyed() method of apScript
			apScript.AppleDestroyed();
		}
	}
}
