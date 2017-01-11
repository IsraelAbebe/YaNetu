using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BreakButton : MonoBehaviour {
	public Button yourButton;
	public GameObject Box;

	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);


	
	}
	
	// Update is called once per frame
	void TaskOnClick(){
		Destroy(Box);	
	}
}
