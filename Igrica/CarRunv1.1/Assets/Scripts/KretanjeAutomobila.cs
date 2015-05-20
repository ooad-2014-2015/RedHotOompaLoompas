using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class KretanjeAutomobila : MonoBehaviour {
	private float brzina=0.05f;

	public GameObject donjiZid;
	public GameObject gornjiZid;
	public GameObject lijeviZid;
	public GameObject desniZid;

	public enum SmjerAutomobila {lijevo, desno, gore, dolje};
	public SmjerAutomobila smjer;

	public Vector2 vektor = -Vector2.right;
	public Vector2 vektorPomjeranja;

	public int highscore;
	public string highScoreKey="HighScore";
	public int score=0;

	public float gorivo=1;

	//realizacija observer patterna
	public Highscore hs;

	public int vratiScore(){
		return score;
	}

	public void attach(Observer o){
		hs=(Highscore)o;
	}

	public void notifyAllObservers(){
		if (score > highscore) {
			highscore = score;
			PlayerPrefs.SetInt (highScoreKey, score);
			PlayerPrefs.Save ();
		}
		hs = new Highscore ();
		hs.update ();
	}

	// Use this for initialization
	void Start () {
		score = 0;
		attach (hs);
		InvokeRepeating ("kretanje", 0.3f, brzina);//pocinje nakon 0.3s i poziva se svakih onoliko sekundi kolika je brzina
		highscore = PlayerPrefs.GetInt (highScoreKey,0);
	}
	
	// Update is called once per frame
	void Update () {
		//ispitivanje koja je tipka pritisnuta na tastaturi
		if (Input.GetKey (KeyCode.RightArrow)) {
			/*if(smjer==SmjerAutomobila.lijevo)
				rotirajZa180();
			else if(smjer==SmjerAutomobila.gore)
				rotirajZa90();
			else if(smjer==SmjerAutomobila.dolje)
				rotirajZa270();
			smjer=SmjerAutomobila.desno;*/
			vektor = Vector2.right;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			vektor = -Vector2.right;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			vektor = Vector2.up;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			vektor = -Vector2.up;
		}
		vektorPomjeranja = vektor / 2f;

		//if(gorivo!=0)
			//gorivo-=0.01f;
		//if(gorivo==0)
			//Application.LoadLevel ("Menu");
	}

	void onDisable(){
		if (score > highscore) {
			highscore=score;
			PlayerPrefs.SetInt (highScoreKey, score);
			PlayerPrefs.Save ();
		}
	}

	public void kretanje(){
		smjer = SmjerAutomobila.lijevo;
		transform.Translate (vektorPomjeranja);//pomjera se automobil za vektor pomjeranja
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.name.StartsWith ("CoinPrefab")) {
			Destroy (coll.gameObject); //unisti coin
			score++;
		} else if (coll.name.StartsWith ("KanisterPrefab")) {
			if (gorivo != 100)
				gorivo += 10;
			Destroy (coll.gameObject); //unisti kanister
		} else if (coll.name.StartsWith ("BombaPrefab")) {
			//kod za game over tj.. ona scena izgubili ste
			notifyAllObservers ();
			//score = 0;
			//GameObject.Find("Igra").GetComponent<Menu2Script>().displayMenu();//nesto ne stima
			Application.LoadLevel ("Menu");
		} else if (coll.name.StartsWith ("GornjiZid")) {
			notifyAllObservers ();
			Application.LoadLevel ("Menu");
		} else if (coll.name.StartsWith ("DonjiZid")) {
			notifyAllObservers ();
			Application.LoadLevel ("Menu");
		} else if (coll.name.StartsWith ("LijeviZid")) {
			notifyAllObservers ();
			Application.LoadLevel ("Menu");
		} else if (coll.name.StartsWith ("DesniZid")) {
			notifyAllObservers ();
			Application.LoadLevel ("Menu");
		}
	}

	//rotiranja pocinju s lijeve strane
	//(tako je objekat postavljen na pocetku)
	public void rotirajZa90(){
		transform.Rotate (Vector3.forward * -90);
	}
	public void rotirajZa180(){
		transform.Rotate (Vector3.forward * -180);
	}
	public void rotirajZa270(){
		transform.Rotate (Vector3.forward * -270);
	}
}
