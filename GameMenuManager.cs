using UnityEngine;
namespace Chapter4Recipe4 {
public class GameMenuManager : MonoBehaviour {

		public GameObject gamePlay;
		public GameObject mainUI;

		void Start(){
			gamePlay.SetActive (false);
		}

		public void HandlePointerClick () {
			gamePlay.SetActive (true);
			mainUI.SetActive (false);
		}
	}
}
