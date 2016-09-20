using UnityEngine;
using System.Collections;

public class ScriptMenu : MonoBehaviour {

	public GameObject loading;

	// Use this for initialization
	void Start () {
		loading.SetActive (false);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClick(int id)
	{
		loading.SetActive (true);
		Application.LoadLevel (id);
	}
}
