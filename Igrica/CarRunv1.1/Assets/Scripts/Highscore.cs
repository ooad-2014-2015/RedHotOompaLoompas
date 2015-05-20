using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Highscore : Observer {

	public List<int> highscoreLista= new List<int> ();
	public KretanjeAutomobila kretanjeAutica;
	public Text scoreovi;
	public int highscore;
	public string highScoreKey="HighScore";

	public void Start(){
		highscore = PlayerPrefs.GetInt(highScoreKey,0);
		ispisiHighscore ();
	}
	public Highscore() {
	}

	public Highscore(KretanjeAutomobila ka){
		this.kretanjeAutica = ka;
		this.kretanjeAutica.attach (this);
	}

	override public void update(){
		//kretanjeAutica = new KretanjeAutomobila ();
		//highscoreLista.Add (this.kretanjeAutica.vratiScore());
		highscore= PlayerPrefs.GetInt(highScoreKey);
	}
	void ispisiHighscore(){
		//highscoreLista.Sort ();
		//highscoreLista.Reverse ();
		scoreovi.text = highscore.ToString();
		//scoreovi.text = highscoreLista [0].ToString () + "\n";
		//highscoreLista[1].ToString() + "\n" +
		//highscoreLista[2].ToString() + "\n" +
		//highscoreLista[3].ToString() + "\n" +
		//highscoreLista[4].ToString() + "\n";
	}



}
