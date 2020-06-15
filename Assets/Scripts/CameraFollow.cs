using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    


    void LateUpdate ()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0, player.transform.position.y + 4,player.transform.position.z - 12), Time.deltaTime * 1000);
    }
}
