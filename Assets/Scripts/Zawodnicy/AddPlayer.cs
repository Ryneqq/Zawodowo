using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayer : MonoBehaviour {

	public GameObject playerUI;
	private List<Player> players;
	private float y;
	private int index;

	void Start(){
		players = new List<Player>();
		y = gameObject.GetComponent<RectTransform>().rect.height/2 - 50f;
		index = 1;
		Screen.fullScreen = !Screen.fullScreen;
	}
	public void Clicked(){
		GameObject temp = Instantiate(playerUI, new Vector3(0f, y, 0f), Quaternion.identity);
		temp.GetComponent<SetText>().Set(index + ".");
		temp.transform.SetParent(this.gameObject.transform,false);


		Player player = new Player();
		players.Add(player);
		y -= 50f;
		index++;
	}
}
