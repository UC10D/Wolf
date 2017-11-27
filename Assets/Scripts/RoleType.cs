using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleType : MonoBehaviour {


	private Button mBtn;


	// Use this for initialization
	void Start () {
		mBtn = this.transform.GetComponent<Button> ();
		mBtn.onClick.AddListener (ChooseBtn);
	}

	void ChooseBtn () {

		GameObject obj = GameObject.Find("Players");

		Debug.Log ("sendmessage  我是预言家");
//		obj.BroadcastMessage ("ReceiveChooseRole", "我是预言家");
//		obj.SendMessageUpwards("ReceiveChooseRole", "我是预言家");
	}


	// 广播用intent，或者bundle包装
	void ReceiveChooseRole(string name){

		Debug.Log ("我是自己------------ReceiveChooseRole" );

	}
}
