using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DangerWall : MonoBehaviour {


	// オブジェクト接触した時に呼ばれるコールバック
	void OnCollisionEnter(Collision hit)
	{
		// 接触したオブジェクトのタグがplayerの場合
		if (hit.gameObject.CompareTag ("Player")) {
			
			// 現在のシーン番号を取得
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;

			// 現在のシーンを再読み込み
			SceneManager.LoadScene(sceneIndex);
		}
	}
}
