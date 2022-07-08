using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterRotation : MonoBehaviour
{
    public float seconds;
    public float rotationSpeed = -200;
    public bool isFast;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    /*public void Rotate(float rotationSpeed)
    {
        this.rotationSpeed = rotationSpeed;
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    }*/

    /*public void StopCircle()
    {
        transform.Rotate(new Vector3(0, 0, 0));
    }*/

    /*bool CheckClick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            return true;
        }

        else
        {
            return false;
        }
    }*/



    /*public IEnumerator waitforseconds(float x){
        yield return new WaitForSeconds(x);
    }


    public void countseconds(int x){
        StartCoroutine("waitforseconds");
    }*/
}
