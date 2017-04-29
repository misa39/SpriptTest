using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTest : MonoBehaviour {

		void Start () {
				int MP = 53;
				if (MP >= 5) {
					Debug.Log("魔法攻撃をした。残りMPは〇〇");
				} else if( MP >=0) {
						Debug.Log("MPが足りないため魔法が使えない。");
		}
				



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
