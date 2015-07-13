using UnityEngine;
using System.Collections;

public class snake : MonoBehaviour {

    public KeyCode left = KeyCode.LeftArrow;
    public int moves = 0;
    public GameObject head;
    public float time = 0.5f;
    public Vector3 v3;


	// Use this for initialization
	void Start () {
        Invoke("move", time);
        getTail();
	}

    void move()
    {
        moves++;
        v3 = head.transform.position;
        head.transform.position += head.transform.forward;
        //sendMove = true;
        Invoke("move", time);
        GameObject tail = getTail();
        //Debug.Log();
        tail.transform.position = v3;

        tail.GetComponent<snakeObject>().next = head.GetComponent<snakeObject>().next;

        head.GetComponent<snakeObject>().next.GetComponent<snakeObject>().previous = tail;

        tail.GetComponent<snakeObject>().previous.GetComponent<snakeObject>().next = null;
        tail.GetComponent<snakeObject>().previous = head;
        head.GetComponent<snakeObject>().next = tail;
        
    }

    GameObject getTail (){
        GameObject current = head;
        while (current.GetComponent<snakeObject>().next != null)
        {
            current = current.GetComponent<snakeObject>().next;
        }
        Debug.Log(current);
        return current;
        
    }

	void FixedUpdate () {
        if (Input.GetKeyDown(left))
        {
            head.transform.Rotate(0, -90, 0, Space.World);
            //Debug.Log("Turning left");
        }
	}
}
