using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaysManager : MonoBehaviour {

	private GridLayoutGroup mGroup;

	private GameObject mPlayer;


	// Use this for initialization
	void Start () {
		mGroup = (GridLayoutGroup)this.GetComponent ("GridLayoutGroup");
		InitPlayers ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InitPlayers(){
		
		for(int i = 0; i < mGroup.transform.childCount; i ++){
			GameObject.Destroy (mGroup.transform.GetChild(i).gameObject);
		}

		int num = PlayerPrefs.GetInt("num", 12);

		for(int i = 0; i < num; i ++){
			mPlayer = (GameObject)Resources.Load ("Prefabs/Player");
			mPlayer = Instantiate (mPlayer);    
			mPlayer.transform.parent = mGroup.transform;
			mPlayer.transform.localScale = new Vector3(1, 1, 1);

			((Player)mPlayer.transform.GetComponent ("Player")).SetNumTag (i);
		}
	}
}
