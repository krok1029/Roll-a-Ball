using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour {
    public static int count;
    int counter_i = 0;
    Text text;
    // Use this for initialization
    void Start () {

        InvokeRepeating("counter", 3f, 3f);
        text = GetComponent<Text>();
        count = 0;
    }
    void counter()
    {
        counter_i += 1;
        Debug.Log(counter_i);
    }
    // Update is called once per frame
    void Update () {
        text.text = "count: " + counter_i;
    }
}
