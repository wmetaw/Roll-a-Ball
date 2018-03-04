using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform target; // targetへの参照
	private Vector3 offset;  // 相対座標

	void Start() {
		offset = GetComponent<Transform> ().position - target.position;
	}

	// Update is called once per frame
	void Update () {
		// 自分の座標にtarget属性を代入する
		GetComponent<Transform>().position = target.position + offset;
	}
}
