using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveSystemExample : MonoBehaviour
{

    public TMP_InputField textBox;

    public void Savedata()
    {
        Playerprefs.Setstring("InputField", textBox.text);
        
    }

    public void LoadData()
    {
        textBox.text = Playerprefs.GetString("InputField");
    }

    public void DeleteData()
    {
        Playerprefs.DeleteKey("InputField");
    }
}
