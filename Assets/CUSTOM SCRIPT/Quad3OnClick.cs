using UnityEngine;
using System.Collections;

public class Quad3OnClick : MonoBehaviour {
	
	public GameObject sword;
	public GameObject enemy;
	public GameObject hidden;	
	public GameObject willBeShown; 		
	public GameObject willBeHidden;
	public GameObject nextMarkerButton;

	/*
	void OnDisable(){
		Debug.Log ("Disabled " + this);
	}

	void OnEnable(){
		Debug.Log ("Enabled " + this);
	}*/


	// Use this for initialization
	void Start () {
		enemy.SetActive (false);
		sword.SetActive (false);
		hidden.SetActive (false);
		willBeShown.SetActive (false);
		willBeHidden.SetActive (true);
		nextMarkerButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUpAsButton()
	{
		enemy.SetActive (true);
		sword.SetActive (true);
		willBeHidden.SetActive (false);
		willBeShown.SetActive (true);
		nextMarkerButton.SetActive (true);
	}

}
