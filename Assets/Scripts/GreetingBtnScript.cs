using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GreetingBtnScript : MonoBehaviour
{
	private Button btn;
	public GameObject greetingMenu;
	public GameObject mainMenu;

	void Start()
	{
		btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		GlobalGamaData.ShowGreetMessage = false;
		greetingMenu.SetActive(false);
		mainMenu.SetActive(true);
	}
}