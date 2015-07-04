using UnityEngine;
using System.Collections;

public class MoveSnake : MonoBehaviour {

    public float time = 0.5f;
    public int moves = 0;
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public Vector3 spawnPos;
    public GameObject gm;
    public GameObject cloneGm = null;
    public bool aPressed = false;
    public bool sendMove = false;
    public GameObject body;
    public Component bodyComponent;
    public bool recivedMove = false;

	// Use this for initialization
	void Start () {
        cloneGm = Instantiate(Resources.Load("Cube1")) as GameObject;
        //Debug.Log("Startet");
        Invoke("move", time);
	}

    void move() {
        moves++;
        transform.position += transform.forward;
        sendMove = true;
        Invoke("move", time);
    }

    // Dont delete!!!
    // cloneGm = Instantiate(Resources.Load("Cube")) as GameObject;
    // Dont delete!!!

    void FixedUpdate () {

        if(aPressed) {

        }

        if (Input.GetKeyDown(KeyCode.A) && transform.rotation.eulerAngles.y == 0)
        {
            //spawnPos = new Vector3(0, 0, transform.position.z - 1);
            cloneGm = Instantiate(Resources.Load("Cube1")) as GameObject;
            //aPressed = true;
            //body = GameObject.Find("Cube");
            //bodyComponent = body.GetComponent<followHead>();
        }

        if (recivedMove == true)
        {
            sendMove = false;
        }

        if (Input.GetKeyDown(left))
        {
            transform.Rotate(0, -1, 0, Space.World);
            //Debug.Log("Turning left");
        }
        else if (Input.GetKeyDown(right))
        {
            transform.Rotate(0, 90, 0, Space.World);
            //Debug.Log("Turning Right");
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }
	}
}
