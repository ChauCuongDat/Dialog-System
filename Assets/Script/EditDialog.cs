using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditDialog : MonoBehaviour
{
    public List<string> dialogString;
    public GameObject dialogBox;
    public GameObject Content;
    private GameObject currentDialog;

    public void createDialog(){
        foreach(var i in dialogString){
            if (i[0] == '/'){
                currentDialog = Instantiate(dialogBox,Content.transform);
            }
            else{
            }
        }
    }
}
