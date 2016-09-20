using UnityEngine;
using System.Collections;


public class PedangScript : MonoBehaviour {
	public GameObject enemy = new GameObject();
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}

	void Update () {
	}
}