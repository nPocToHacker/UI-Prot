using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopUnitContainer : MonoBehaviour
{
    public float cost;
    public string unitName;

    public TextMeshProUGUI costOutput;
    public TextMeshProUGUI nameOutput;

    void Awake()
    {
        nameOutput.SetText(unitName);

        costOutput.SetText("{0} $", cost);
    }
}
