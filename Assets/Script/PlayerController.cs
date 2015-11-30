using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        if (GameObject.FindGameObjectsWithTag("Pick Up").Length > 0)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }
        else
        {

            float moveHorizontal = 0;
            float moveVertical = 0;

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.position.Set(rb.position.x, rb.position.y,rb.position.z);
            rb.AddForce(movement * speed);
        }

       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count +1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        Debug.Log(countText.text);
        Debug.Log(GameObject.FindGameObjectsWithTag("Pick Up").Length);
        if ( GameObject.FindGameObjectsWithTag("Pick Up").Length==0)
        {
           
            winText.text = "Win!!";
            CancelInvoke();


        }
    }
    
    }
