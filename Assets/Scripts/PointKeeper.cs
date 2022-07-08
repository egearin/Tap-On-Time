using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointKeeper : MonoBehaviour
{
    [SerializeField] private CollisionHandler collHandler;
    [SerializeField] private TextMeshProUGUI Points;
    [SerializeField] private TextMeshProUGUI Target;
    [SerializeField] private TextMeshProUGUI Finish;
    [SerializeField] private TextMeshProUGUI Level;
    [SerializeField] private TextMeshProUGUI Stop;

    private int point;
    public int level = 1;
    public int targetP = 20;

    private string STOP_TEXT;
    private string LEVEL_TEXT;
    private string POINT_TEXT;
    private string TARGET_TEXT;
    private string FINISH_TEXT;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        point = collHandler.p;
        FINISH_TEXT = ("succesfully completed!");
        STOP_TEXT = ("GAME OVER!!!");

        if (point == targetP)
        {
            if (targetP == 100)
            {
                Finish.text = FINISH_TEXT;
                Finish.enabled = true;
                Points.enabled = false;
                Target.enabled = false;
                Level.enabled = false;
            }
            else
            {
                level++;
                targetP += 20;
            }

        }

        else if(collHandler.gameOver == true)
        {
            Stop.text = STOP_TEXT;
            Debug.Log("zort");
            Stop.enabled = true;
            Finish.enabled = false;
            Points.enabled = false;
            Target.enabled = false;
            Level.enabled = false;
        }

        else
        {
            POINT_TEXT = ("Points:" + point);
            Points.text = POINT_TEXT;
            TARGET_TEXT = ("Target:" + targetP);
            Target.text = TARGET_TEXT;
            LEVEL_TEXT = ("level " + level);
            Level.text = LEVEL_TEXT;
            Finish.enabled = false;
            //Points.enabled = true;
            //Target.enabled = true;
            //Level.enabled = true;
           
            
        }
    }
}
