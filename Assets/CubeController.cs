﻿using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start(){
	}

	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}
	}

//	//トリガーモードで他のオブジェクトと接触した場合の処理
//	void OnTriggerEnter(Collider other) {
//
//		//地面またはキューブに衝突した場合
//		if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag") {
//			GetComponent<AudioSource> ().volume = 1;
//		}
//		GetComponent<AudioSource> ().volume = 0;	          
//	}
}