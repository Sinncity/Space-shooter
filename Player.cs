using System;
using System.Threading;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.TextCore.Text;

public class Player : MonoBehaviour
{
      [SerializeField]
      private float _speed = 3.5f;
    private object Character;


    // Start is called before the first frame update
    void Start() => transform.position = new Vector3(0, 0, 0);

    private void GetV() => PlayerMoveMent();

    void Update(GetV) =>  GetV;
    void PlayerMoveMent()
      {


            float horizontalInput = Input.GetAxis("Horizontal");

            float verticalInput = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

            transform.Translate(direction * _speed * Time.deltaTime);
            // //////////////////////////////////////


            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 0, 5.0f), 0);

            /////////////////////////////////////////////////////////
            if (transform.position.x >= 11.3f)
            {
                  transform.position = new Vector3(-11.3f, transform.position.y, 0);
            }
            else if (transform.position.x <= -11.3f)
            {
                  transform.position = new Vector3(11.3f, transform.position.y, 0);

            }







      }




}

