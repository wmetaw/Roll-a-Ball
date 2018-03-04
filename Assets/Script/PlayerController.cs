using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 10;

	void FixedUpdate() {
		// 入力をxとzに代入
		float x = Input.GetAxis("Horizontal"); // 水平
		float z = Input.GetAxis("Vertical");   // 垂直

		// 同一のgameobjectが持つRididbodyコンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.AddForce (x * speed, 0, z * speed);
	}
}
