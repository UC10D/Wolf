using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RolesSelectDlg : MonoBehaviour {

	private GridLayoutGroup mGroup;

	private GameObject mRole;

	private int mNum = 7;

	private int mPlayerNum = 1;

	// Use this for initialization
	void Start () {
		mGroup = (GridLayoutGroup)this.GetComponent ("GridLayoutGroup");
		InitRoles ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InitRoles(){
		for(int i = 1; i <= mNum; i ++){
			mRole = (GameObject)Resources.Load ("Prefabs/Role");
			mRole = Instantiate (mRole);    
			mRole.transform.parent = mGroup.transform;
			mRole.transform.localScale = new Vector3(1, 1, 1);
			Image image = (Image)mRole.GetComponent ("Image");
			image.sprite = Resources.Load("Sprites/common_img_" + i, typeof(Sprite)) as Sprite;
			mRole.GetComponent<Role> ().SetRoleType (i);
		}
	}

	public void SetPlayNum (int num) {
		this.mPlayerNum = num;
	}

	// 返回playNum ， roleType
	void SetRole() {
		GameObject.Destroy (gameObject);
	}
}
