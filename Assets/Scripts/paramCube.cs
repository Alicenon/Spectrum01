using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paramCube : MonoBehaviour
{
    public int _banda;
    public float _comenzarAEscalar, _multiplicadorDeEscala;
    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x,(AudioIni._bandaFrecuencia[_banda]*_multiplicadorDeEscala)+_comenzarAEscalar,transform.localScale.z);
    }
}
