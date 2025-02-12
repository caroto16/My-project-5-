   using UnityEngine;

   public class RotateCube : MonoBehaviour
   {
       public float rotationSpeed = 50f;

       void Update()
       {
           if (Input.GetKey(KeyCode.A))
           {
               transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
           }
           if (Input.GetKey(KeyCode.D))
           {
               transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
           }
       }
   }
   