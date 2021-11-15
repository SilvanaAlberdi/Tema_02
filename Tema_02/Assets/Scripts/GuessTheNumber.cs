using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumber : MonoBehaviour
{
    private int randNum;
    private int playerNum;
    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(1, 11);
        
    }

    // RECUERDA QUE PARA VER SI DOS NÚMERO SON IGUALES TIENES QUE PONER ==, UN SOLO = ES PARA ASIGNACIÓN
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            playerNum = int.Parse (GetComponent<InputField>().text);
            if (playerNum < randNum)
            {
                Debug.Log("El número introducido es menor del que he pensado");
            }
            if (playerNum > randNum)
            {
                Debug.Log("El número introducido es mayor del que he pensado");
            }
            if (playerNum == randNum)
            {
                Debug.Log("¡Enhorabuena, has acertado!");
            }
        }

    }
}
