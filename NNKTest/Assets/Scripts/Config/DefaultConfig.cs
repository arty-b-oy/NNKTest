using System;
using UnityEngine;

[CreateAssetMenu(order = 1, menuName = "Config/DefaultConfig")]
public class DefaultConfig : ScriptableObject
{
    public string URLWeather;
    public string URLWebView;
    public string URLWebCum;
}
