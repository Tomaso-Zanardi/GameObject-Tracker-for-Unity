using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;

public class tracker : MonoBehaviour
{
    public GameObject tracked;
    
    void Start()
    {
        //CreateTextP();

    }

    // Update is called once per frame
    void Update()
    {
        CreateTextP();
    }


    void CreateTextP()
    {
        string path = Application.dataPath + "/tracked_object";
        if (!File.Exists(path))
        {
            File.WriteAllText(path,"Tracker \n\n");
        }
        string content = "position at time: " + System.DateTime.Now + tracked.transform.position.x + ","+ tracked.transform.position.y + ","+ tracked.transform.position.z + "," + "\n";
        File.AppendAllText(path,content);
    }
}
