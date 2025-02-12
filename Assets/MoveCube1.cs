   using UnityEngine;

   public class MoveCube1Controller : MonoBehaviour
   {
       public float speed = 8f;

       void Update()
       {
           if (Input.GetKey(KeyCode.W))
           {
               transform.Translate(Vector3.forward * speed * Time.deltaTime);
           }
       }
   }
