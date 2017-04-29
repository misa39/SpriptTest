using UnityEngine;
using System.Collections;

public class Boss {
		private int MP = 53;
		private int Magic = 5;

		public void Attack() {
		Debug.Log (this.Magic + "魔法攻撃をした。残りMPは");
		}

		public void Defence(int damage) {
				Debug.Log (damage + "のダメージを受けた");
				this.MP -= damage;
		}
		
}

public class Test : MonoBehaviour {
	

		void Start () {
				Boss lastboss = new Boss ();

				lastboss.Attack ();
				lastboss.Defence (3);
		}

		void Update () {
		
		}
}
