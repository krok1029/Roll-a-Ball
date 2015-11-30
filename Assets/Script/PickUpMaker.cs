using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickUpMaker : MonoBehaviour {

    public Text countText;
    public GameObject PickUp;
    public float spawnTime = 6f; 
    public Transform Tran_CreatPoint;
    public Vector3 V3_Random;

    void Start() {
    }
    // Update is called once per frame
    void Update () {
            V3_Random = new Vector3(Random.Range(-9.5f, 9.5f),0.5f, Random.Range(-9.5f, 9.5f));
            
            if (spawnTime > 0) {
                spawnTime -= Time.deltaTime;
            }
            else {
                if (GameObject.FindGameObjectsWithTag("Pick Up").Length == 0)
                {
                    CancelInvoke();
                }
                else
                {
                    GameObject PickUp_Clone = Instantiate(PickUp, V3_Random, Quaternion.identity) as GameObject;
                    spawnTime = 6.0f;
                }
        }

    }
}
