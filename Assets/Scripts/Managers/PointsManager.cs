using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static TMPro.TextMeshPro;

public class PointsManager : MonoBehaviour
{
private int _leftPoints=0;
private int _rightPoints=0;
[SerializeField]
private TextMeshProUGUI leftText;
[SerializeField]
private TextMeshProUGUI rightText;


public void AddLeftPoint()
{
    _leftPoints++;
    leftText.text = _leftPoints.ToString();
}
public void AddRightPoint()
{
    _rightPoints++;
    rightText.text = _rightPoints.ToString();
}

public void Reset()
{
    _leftPoints = 0;
    _rightPoints = 0;
    leftText.text = "0";
    rightText.text = "0";
}

}
