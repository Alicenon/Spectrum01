using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{

    public float HorizontalMove;
    public float VerticalMove;
    public CharacterController player;

    public float prayerSpeedto;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        VerticalMove = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
       player.Move(new Vector3(HorizontalMove,0,VerticalMove)* prayerSpeedto);
    }
}
