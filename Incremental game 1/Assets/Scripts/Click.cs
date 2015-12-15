using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text goldDisplay;
    public float gold = 0.00f;
    public int goldperclick = 1;
    public UnityEngine.UI.Text gpc;
    public float goldPerSecond = 0.00f;

    void Update()
    {
        goldDisplay.text = "Gold: " + gold;
        gpc.text = "Gold per Click:" + goldperclick;
        gold += goldPerSecond;


    }

    public void Clicked()
    {
        gold += goldperclick;
    }
}
