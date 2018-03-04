using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	//	OnTriggerEnter   ： 判定のみのTriggerとの接触判定
	//	OnCollisionEnter ： 物理的な反射を持つColliderとの接触判定

	// Trigger接触時に呼ばれるコールバック
	void OnTriggerEnter(Collider hit) {
		if(hit.CompareTag("Player")) {
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
