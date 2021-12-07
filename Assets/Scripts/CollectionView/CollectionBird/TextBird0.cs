using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class TextBird0 : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text = GetComponent<Text>();
        SaveData saveData = DataManager.instance.Load();
        
        if(saveData.collection_bird[0]==0){
            text.enabled = false;
        }
        else{
            text.enabled = true;
        }
    }

}
