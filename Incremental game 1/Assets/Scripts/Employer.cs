using UnityEngine;
using System.Collections;

public class Employer : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public float employerPower;
    public string employerName;
    private float _newCost;

    // Update is called once per frame
    void Update()
    {
        itemInfo.text = employerName + "\nCost:" + cost + "\nPower: +" + employerPower;

    }

    public void Employed()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            click.goldPerSecond += employerPower;
            cost = Mathf.Round(cost * 1.15f);
            _newCost = Mathf.Pow(cost, _newCost = cost);

        }
    }
}
