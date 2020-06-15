using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("jogado");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Player Pos " + player.transform.position.z + " / Objs Pos " + gameObject.transform.position.z);
        if (gameObject.transform.position.z < player.transform.position.z - 15)
        {
           // Debug.Log("destroy");
            Destroy(gameObject);
        }
    }
}
