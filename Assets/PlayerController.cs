using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown Obtiene la tecla cada vez que se presiona, pero no sirve para mantener la tecla 
        //(osea es para un unico presionado que se puede repetir
        // GetKey sirve para presionar y mantener una tecla
        if (Input.GetKey(KeyCode.W))
        {
            //no sirve tanto porque afecta al eje global y no al del objeto
            //transform.position += new Vector3(0,0,MovementSpeed);
            transform.Translate(0, 0, MovementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -MovementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0,RotationSpeed,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,-RotationSpeed,0);
        }
    }
}
