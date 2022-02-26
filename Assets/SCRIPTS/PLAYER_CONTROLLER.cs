using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_CONTROLLER : MonoBehaviour
{
    //VELOCIDAD DEL PLAYER
    private float SPEED = 5;

    //LA POSICION DEL PLAYER NO CAMBIARA ENTRE ESCENAS
    void Start()
    {
        transform.position = PERSISTENCE_DATA.sharedInstance.PLAYER_POSITION;
    }

    //VELOCIDAD CON LA QUE S EMOVERA EL PALAYER
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * SPEED);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * SPEED);
        }
    }
}
