using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiate512Cubes : MonoBehaviour
{
    public GameObject _cuboPrefabricadoDeMuestra;
    GameObject[] _cuboDeMuestra = new GameObject[512];
    // Start is called before the first frame update
    public float _escalaMaxima;
    void Start()
    {   
        for (int i = 0; i < 512; i++)
        {
            GameObject _instanciasCuboDeMuestra = (GameObject)Instantiate (_cuboPrefabricadoDeMuestra);
            _instanciasCuboDeMuestra.transform.position = this.transform.position;
            _instanciasCuboDeMuestra.transform.parent = this.transform;
            _instanciasCuboDeMuestra.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3 (-0.7538f*i, _newvar * i,500);//en eje"x"  -0.7538f ?? vertutorial, 21 para esfera
            _instanciasCuboDeMuestra.transform.position = Vector3.forward* 100;//Vector3.forward("es el como doble S o infinito")//tamaño del spectro.separa el espaciado con el transform posicion 
            _cuboDeMuestra[i] = _instanciasCuboDeMuestra;                          // de cada instancia de los cubos :3
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if(_cuboDeMuestra != null)

            {      
                //(10,10,(AudioIni._muestraSampling[i] * _escalaMaxima) + 10);  con valor 10 en z esferas 
                //(10,10,(AudioIni._muestraSampling[i] * _escalaMaxima) + 2);
                //(10,(AudioIni._muestraSampling[i] * _escalaMaxima) + 10);  ej. quitar un valor de 10 en Y, entonces solo son lineas
                _cuboDeMuestra[i].transform.localScale = new Vector3(_ejeX,_ejeY,(AudioIni._muestraSampling[i] * _escalaMaxima) + _ejeZ);
            
             //this.transform.eulerAngles = new Vector3 (-0.7538f*i, _newvar * i,500);//en eje"x"  -0.7538f ?? vertutorial, 21 para esfera
          
            }
        }
    }
    //public float _formObject = -0.7538f;
    public int _ejeX;
    public int _ejeY;
    public int _ejeZ;

    public float _newvar;
}
