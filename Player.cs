using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
public class Player : MonoBehaviour
{
      // Start is called before the first frame update
      void Start()
      {
            // take the current position = new position(0,0,0)
            //Vector3(0,0,0)
            transform.position = Vector3.zero;

      }

      // Update is called once per frame
      void Update()
      {
            transform.Translate(Vector3.right * 3 * Time.deltaTime, Camera.main.transform);


      }
}
