using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PERSISTENCE_DATA : MonoBehaviour
{
    //NOMBRE DE LA POSICION DEL PLAYER
    public Vector3 PLAYER_POSITION;

    // NO SE DESTRUYE EL "GAME OBJECT MANAGER"
    public static PERSISTENCE_DATA sharedInstance;

    //EL GAMEOBJECT NO SE DESTRUYE AL CAMBIAR DE ESCENA
    void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(this);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
