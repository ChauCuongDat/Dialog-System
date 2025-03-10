using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;

public class ConvertText : MonoBehaviour
{
    public TextMeshProUGUI nameSlot;
    public string textFileName;
    public EditDialog dialogScreen;

    public bool checkPath(string Path){
        if(File.Exists(Path)){
            return true;
        }
        return false;
    }

    public void getData(){
        textFileName = nameSlot.text;
        string path = Path.Combine(Application.streamingAssetsPath, "Text", textFileName+".txt");
        if(checkPath(path)){
            dialogScreen.dialogString = File.ReadAllLines(path).ToList();
        }
        else{
            Debug.Log(path);
            Debug.Log("There are no file text name " + textFileName);
            File.WriteAllText(path, "Hello, this is a new text file created by Unity!");
        }
    }
}
