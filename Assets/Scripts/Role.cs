using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Role : MonoBehaviour {

	private Button mBtn;

	private int mRoleType = 1;

	// Use this for initialization
	void Start () {
		mBtn = this.transform.GetComponent<Button> ();
		mBtn.onClick.AddListener (OnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnClick ()
	{	
		this.transform.parent.BroadcastMessage ("SetRole", mRoleType);
	}

	public void SetRoleType (int num) {
		this.mRoleType= num;
	}
}
