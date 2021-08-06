using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRotateOther : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
         transform.RotateAround(transform.position, Vector3.down, speedRotateOther * Time.deltaTime);
         transform.RotateAround(transform.position, Vector3.left, speedRotateOtherLeft * Time.deltaTime);
    }

    public int speedRotateOther;
    public int speedRotateOtherLeft;
}
