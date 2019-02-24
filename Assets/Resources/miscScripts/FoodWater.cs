using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodWater : MonoBehaviour
{
    //public ParticleSystem particleType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.up.y < 0)
        {
            Debug.Log("aaaaaaaaaa");
            //you're upside down
        }
        //particleType.Pause();
    }
}
