using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClick : MonoBehaviour
{

    GameManager myManager;

    bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
        myManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (myManager.playerOneTurn == true && selected == false)
        {
            gameObject.GetComponent<Renderer>().material = myManager.playerOneMaterial;
            myManager.playerOneTurn = false;
            myManager.playerTwoTurn = true;
            selected = true;
        } else if (myManager.playerTwoTurn == true && selected == false)
        {
            gameObject.GetComponent<Renderer>().material = myManager.playerTwoMaterial;
            myManager.playerOneTurn = true;
            myManager.playerTwoTurn = false;
            selected = true;
        }

        Debug.Log(gameObject.name);
    }
}
