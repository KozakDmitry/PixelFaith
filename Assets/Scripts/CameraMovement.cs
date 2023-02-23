using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS
{

    public class CameraMovement : MonoBehaviour
    {
        public Camera gameCamera;
 

        private void Start()
        {
            gameCamera = GetComponent<Camera>();
        }
       
    }
}