using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GorivoBar : MonoBehaviour {
	public KretanjeAutomobila sg;
	public float gorivoBar=1;
	public int scoreGui;


	public Text rezultatIspis;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {;
		gorivoBar = sg.gorivo;
		scoreGui = sg.score;

		//za regulisanje bara
		Image image = GetComponent<Image>();
		//image.fillAmount = Mathf.MoveTowards(image.fillAmount, 1f, Time.deltaTime*0.1f);
		image.fillAmount = gorivoBar;

		//za regulisanje score-a
		rezultatIspis.text = scoreGui.ToString();
	}
}
