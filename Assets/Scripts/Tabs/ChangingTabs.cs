using UnityEngine;
using UnityEngine.UI;

public class ChangingTabs : MonoBehaviour {
	private bool ZawodnicyTab = true;
	private bool KlubyTab = false;

	public GameObject ZawodnicyContent;
	public GameObject KlubyContent;
	

	public void ZawodnicyTabClicked(){
		if(!ZawodnicyTab){
			ZawodnicyTab = true;
			KlubyTab = false;
			ZawodnicyContent.SetActive(true);
			KlubyContent.SetActive(false);
			gameObject.GetComponent<SelectedTab>().ZawodnicySelected();
		}
	}

	public void KlubyTabClicked(){
		if(!KlubyTab){
			KlubyTab = true;
			ZawodnicyTab = false;
			KlubyContent.SetActive(true);
			ZawodnicyContent.SetActive(false);
			gameObject.GetComponent<SelectedTab>().KlubySelected();
		}
	}
}
