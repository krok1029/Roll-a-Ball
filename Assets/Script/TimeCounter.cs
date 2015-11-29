using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {
    public static int time;

    Text text;

	void Awake ()
    {
        text = GetComponent<Text> ();
        time = 0;
    }
    		
	
	void Update () {
        text.text = "Time: " + time;
	}
}
