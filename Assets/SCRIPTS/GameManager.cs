using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //NOMBRE DEL PLAYER
    public GameObject PLAYER;

    //NOMBRE DEL CONTADOR
    public TextMeshProUGUI TEXTO_CONTADOR;
    public int CONTADOR = 0;

    //CON EL BOTON "1" y "2" SE CAMBIA DE ESCENA
    void Update()
    {
        //CAMBIO A ESCENA_1 Y SUMA EL NUMERO DE VECES QUE SE HA CAMBIADO EN EL CONTADOR
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PERSISTENCE_DATA.sharedInstance.PLAYER_POSITION = new Vector3
                (0, transform.position.y, 0);
            SceneManager.LoadScene("ESCENA_1");
            CONTADOR++;
        }

        //CAMBIO A ESCENA_2 Y SUMA EL NUMERO DE VECES QUE SE HA CAMBIADO EN EL CONTADOR
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PERSISTENCE_DATA.sharedInstance.PLAYER_POSITION = new Vector3
                (0, transform.position.y, 0);
            SceneManager.LoadScene("ESCENA_2");
            CONTADOR++;
        }

        //EL NUMERO DE VECES QUE EL CONTADOR CUENTA
        TEXTO_CONTADOR.text = $"Cambio de escena = {CONTADOR}";
    }
}
