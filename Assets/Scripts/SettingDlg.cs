using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingDlg : MonoBehaviour {


	private Button mBtn;
	private InputField mInput;


	// Use this for initialization
	void Start () {
		mBtn = this.transform.FindChild("StartGame").GetComponent<Button> ();
		mBtn.onClick.AddListener (SettingPlayersNum);
		mInput = this.transform.FindChild("InputField").GetComponent<InputField> ();
	}
	
	void SettingPlayersNum ()
	{	
		int input = int.Parse(mInput.text);
		if (input > 0) {
			PlayerPrefs.SetInt("num", input);
			GameObject.Find ("PlayersManager").BroadcastMessage ("InitPlayers");
			GameObject.Destroy (gameObject);
		}
	}
}
