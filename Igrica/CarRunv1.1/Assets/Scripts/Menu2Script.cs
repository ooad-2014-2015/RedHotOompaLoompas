using UnityEngine;
using System.Collections;

public class Menu2Script : MonoBehaviour {
	//public GameObject menuPanel;

	// Use this for initialization
	void Start () {
		//hideMenu ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*public void displayMenu()
	{
		menuPanel.GetComponent<CanvasGroup> ().interactable = true;
		menuPanel.GetComponent<CanvasGroup> ().alpha = 1;
	}
	public void hideMenu()
	{
		//sakrij meni i onemoguci interakciju
		menuPanel.GetComponent<CanvasGroup> ().interactable = false;
		menuPanel.GetComponent<CanvasGroup> ().alpha = 0;
	}*/
	public void ponovi()
	{
		Application.LoadLevel ("Igra");
	}
	public void idiNaGlavniMeni()
	{
		Application.LoadLevel ("MainMenu");
	}
	public void exit()
	{
		Application.Quit ();
	}
}
