using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {

	public GameObject loading;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUpAsButton(){
		loading.SetActive (true);
		Application.LoadLevel (0);
	}
}
