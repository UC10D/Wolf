using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

	private int mNumTag = 0;
	private Image mImage;
	private Button mBtn;
	private Text mNumTxv;
	private GameObject mTip;
	private GameObject mUICanvas;


	public void SetNumTag(int num)
	{	
		mNumTag = num;
		mNumTxv.text = "No." + (mNumTag + 1);
	}


	void Awake()
	{
		mNumTxv = (Text)this.transform.FindChild ("NumTxv").GetComponent<Text> ();
	}

	// Use this for initialization
	void Start ()
	{	
		mImage = (Image)this.transform.FindChild ("Image").GetComponent<Image> ();

		mBtn = this.transform.GetComponent<Button> ();
		mBtn.onClick.AddListener (OnClick);

		mUICanvas = GameObject.Find ("Canvas");
	}

	void OnClick ()
	{
		if (mTip == null) {
			mTip = (GameObject)Resources.Load ("Prefabs/RolesSelectDlg");
			mTip = Instantiate (mTip);    
			mTip.transform.parent = mUICanvas.transform;
			mTip.transform.localPosition = new Vector3 (0, 0, 0);
			mTip.transform.localScale = new Vector3(1, 1, 1);
			mTip.transform.GetComponent<RolesSelectDlg> ().SetPlayNum (mNumTag + 1);
		}
	}

	// 广播用intent，或者bundle包装
	void ReceiveChooseRole(string name){

		Debug.Log ("ReceiveChooseRole" );
		Debug.Log ("ReceiveChooseRole" + name);

	}


}
