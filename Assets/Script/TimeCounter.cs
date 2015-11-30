using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {
    public static int time;
    int timer_i = 0;
    Text text;

	void Start()
    {
        InvokeRepeating("timer", 1f, 1f);
        text = GetComponent<Text> ();
        time = 0;
    }
    void timer()
    {
        timer_i += 1;
     
    }
	
	void Update () {
        text.text = "TIME: "+ timer_i;
        if (GameObject.FindGameObjectsWithTag("Pick Up").Length == 0)
        {
            CancelInvoke();
        }
    }
}
