using UnityEngine;

public class ToggleFullscreen : MonoBehaviour
{
	void Start(){
		Screen.fullScreen = false;
	}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            Screen.fullScreen = !Screen.fullScreen;
    }
}