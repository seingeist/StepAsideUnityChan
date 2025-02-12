﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {

	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//Unityちゃんとカメラの距離
	private float difference;

	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {

		//Unityちゃんとオブジェクトの位置（z座標）の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;

		//Unityちゃんとオブジェクトの距離が一定以上になるとオブジェクトを破壊
		if (difference > 10)
		{
			Destroy(this.gameObject);
		}
	}
}
