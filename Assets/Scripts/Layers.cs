using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layers : MonoBehaviour
{

    public GameObject[] boxes;
    [SerializeField] private Starting _starting;
    public int curr_index;
    private int x;
    private int y;
    private int index;


    void Start()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
           
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            curr_index = x;
            x = Random.Range(0, boxes.Length);
            boxes[x].gameObject.SetActive(true);

        }*/
    }

    bool CheckClick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}