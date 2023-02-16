
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;
    [SerializeField]
    private float _fireRate =0.12f;
    [SerializeField]
    private float _canFire =-1f;


 
    void Start()
    {
    transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
    PlayerMoveMent();

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _canFire)

        {
            FireLaser();

        }

    }
    


    
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

    void FireLaser()

    {
        
            _canFire = Time.time + _fireRate;
            Instantiate(_laserPrefab, transform.position + new Vector3(0, 1f, 0), Quaternion.identity);
        

    }
        
}

