using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objectivescore : MonoBehaviour
{
    public GameObject Textbox;
    public static int KeysFound;
    private int MaxKeys = 10;

    void Update(){
        Textbox.GetComponent<Text>().text = "Keys found: " + KeysFound + "/" +  MaxKeys;
    }
}
