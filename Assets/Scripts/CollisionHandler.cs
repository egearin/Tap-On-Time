using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    [SerializeField] private Layers _layers;
    [SerializeField] private CenterRotation _rotation;
    [SerializeField] private Starting _starting;
    [SerializeField] private PointKeeper _pointKeeper;
    public bool gameOver = false;
    private bool isColliding;
    private bool isInCircle;
    private GameObject rotation;
    private GameObject layers;
    private int index;
    private int checker;
    private int active;
    private int a = 0;
    public int p = 0;
    public int b;

    void Start()
    {
        //_rotation = rotation.GetComponent<CenterRotation>();
        //_layers = layers.GetComponent<Layers>();

        for (int i = 0; i < _layers.boxes.Length; i++)
        {
            _layers.boxes[i].SetActive(false);
        }

        Randomize();
        checker = active;
        _layers.boxes[active].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && isColliding)
        {
            p += 2;
            if (gameOver == false)
            {
                _rotation.rotationSpeed -= 10;
                _layers.boxes[active].SetActive(false);
                Randomize();
                while (checker == active)
                {
                    Randomize();
                }
                checker = active;
                _layers.boxes[active].SetActive(true);
            }
        }

        else if (Input.GetKeyDown(KeyCode.Mouse0) && !isColliding)
        {
            _rotation.rotationSpeed = 0;
            gameOver = true;
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        else
        {
            _rotation.transform.Rotate(new Vector3(0, 0, _rotation.rotationSpeed) * Time.deltaTime);
        }

        /*if(_starting.isReady == false)
        {
            _rotation.rotationSpeed = -50;
        }*/
    }

    /*if (Input.GetMouseButtonDown(0))
    {
        if (isColliding == true)
        {
            index = _layers.curr_index;
            _layers.boxes[index].SetActive(false);
            _rotation.rotationSpeed -= 30;
            p += 2;

        }
        else if (isColliding == false)
        {
            a++;
            if (a > 1)
            { 
                Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                _rotation.transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime, Space.World);
            }
        }
    }

    else if (Input.GetKeyDown(KeyCode.Escape))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    else
    {
        _rotation.transform.Rotate(new Vector3(0, 0, _rotation.rotationSpeed) * Time.deltaTime);
    }*/

private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
       
            isColliding = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "box")
        {

            isColliding = false;

        }
    }

    public void Randomize()
    {
        active = Random.Range(0, _layers.boxes.Length);
    }

    private static void CloseScene(Scene scene)
    {
        EditorSceneManager.CloseScene(scene, false);
    }

    IEnumerator waiter(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }

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
}

