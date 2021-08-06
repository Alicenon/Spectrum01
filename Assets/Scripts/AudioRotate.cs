using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRotate : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.back, speedRotate* Time.deltaTime);
    }
    public int speedRotate;
    // poner un valor de 20 al entero de rotacion en el eje "Z" :3
    // sería lo más normal. Ni lento ni rapido xD
}
