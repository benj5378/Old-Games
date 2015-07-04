using UnityEngine;
using System.Collections;

public class followHead : MonoBehaviour
{

    //public GameObject follow;
    //public float time = 0.5f;
    //public Vector3 savePos;
    //public bool movingHead = false;
    //public Component HeadMoveSnakeComponent;
    //public bool getMove = false;
    int i = 0;
    bool objectFinder = false;

    // Update is called once per frame
    void Start()
    {
        //follow = GameObject.Find("Cube");
        //StartCoroutine(moving());
        while (objectFinder == false)
        {
            i++;
            if (GameObject.Find("Cube" + i) != null)
            {
                objectFinder = true;
            }
            Debug.Log("This is number: " + i++);
        }

    }

    //IEnumerator moving()
    //{
    //    while ("Unity" != "Dårlig")
    //    {
    //        //Debug.Log("Venter" + " " + time + " " + "sek!");
    //        //movingHead = follow.GetComponent<MoveSnake>().sendMove;
    //        //Debug.Log(savePos);
    //        //if (movingHead == true)
    //        //{
    //        //    getMove = true;
    //        //    Debug.Log(movingHead);
    //        //    savePos = follow.transform.position;
    //        //    transform.position = savePos;
    //        //}
    //        //Debug.Log("Har ventet" + " " + time + " " + "sek!");
    //    }
    //}
}
