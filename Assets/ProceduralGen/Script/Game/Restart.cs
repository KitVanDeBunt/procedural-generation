using UnityEngine;
public class Restart:MonoBehaviour{
	[SerializeField]
	private KeyCode restartKey;

	void Update(){
		if(Input.GetKeyDown(restartKey)){
			Application.LoadLevel(Application.loadedLevelName);

		}
	}
}
