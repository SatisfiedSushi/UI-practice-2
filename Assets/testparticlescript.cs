using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testparticlescript : MonoBehaviour
{
    // Start is called before the first frame update
    public class Test : MonoBehaviour
    {
        protected bool letPlay = true;
        public ParticleSystem MuzzleFlashEffect;

        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("asdfsa");
                MuzzleFlashEffect.Play();
            }

            
        }
    }
}
