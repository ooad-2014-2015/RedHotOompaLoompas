using UnityEngine;
using System.Collections;

public class CreateCoin : MonoBehaviour {
	public GameObject coinPrefab;
	public GameObject kanisterPrefab;
	public GameObject bombaPrefab;

	public Transform gornjiZid;
	public Transform donjiZid;
	public Transform desniZid;
	public Transform lijeviZid;

	// Use this for initialization
	void Start () {
		//kreirajCoin ();
		InvokeRepeating ("kreirajCoin", 5, 4);//pocinje nakon 5s i poziva se svakih 4 sekunde
		InvokeRepeating ("kreirajKanister", 30, 7);
		InvokeRepeating ("kreirajBombu", 40, 20);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void kreirajCoin()
	{//postavlja random koordinate x i y i instancira coin na tim koordinatama
		int x = (int)Random.Range (lijeviZid.position.x, desniZid.position.x);
		int y = (int)Random.Range (donjiZid.position.y, gornjiZid.position.y);
		Instantiate (coinPrefab, new Vector2 (x, y), Quaternion.identity);//quaternion.identity default rotacija
	}

	public void kreirajKanister()
	{//postavlja random koordinate x i y i instancira kanister na tim koordinatama
		int x = (int)Random.Range (lijeviZid.position.x, desniZid.position.x);
		int y = (int)Random.Range (donjiZid.position.y, gornjiZid.position.y);
		Instantiate (kanisterPrefab, new Vector2 (x, y), Quaternion.identity);//quaternion.identity default rotacija
	}

	public void kreirajBombu()
	{//postavlja random koordinate x i y i instancira kanister na tim koordinatama
		int x = (int)Random.Range (lijeviZid.position.x, desniZid.position.x);
		int y = (int)Random.Range (donjiZid.position.y, gornjiZid.position.y);
		Instantiate (bombaPrefab, new Vector2 (x, y), Quaternion.identity);//quaternion.identity default rotacija
	}
}
