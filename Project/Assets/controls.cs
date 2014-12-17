using UnityEngine;
using System.Collections;

public class controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
						Vector3 position = this.transform.position;
						position.x--;
						this.transform.position = position;
				}
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 position = this.transform.position;
			position.z++;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 position = this.transform.position;
			position.z--;
			this.transform.position = position;
		}
	
	}
}
