using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour {

	private Button mBtn;
	private GameObject mTip;
	private GameObject mUICanvas;

	// Use this for initialization
	void Start () {
		mBtn = this.transform.GetComponent<Button> ();
		mUICanvas = GameObject.Find ("Canvas");
		mBtn.onClick.AddListener (ShowSettingDlg);
	}

	void ShowSettingDlg ()
	{
		mTip = (GameObject)Resources.Load ("Prefabs/SettingDlg");
		mTip = Instantiate (mTip);    
		mTip.transform.parent = mUICanvas.transform;
		mTip.transform.localPosition = new Vector3 (0, 0, 0);
		mTip.transform.localScale = new Vector3(1, 1, 1);
	}
}
