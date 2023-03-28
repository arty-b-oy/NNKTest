using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using Zenject;

public class GetWeather : MonoBehaviour
{

    [Inject] private ButtonsView buttonsView;
    [Inject] private DefaultConfig defaultConfig;
    public delegate void GetWeatherEnd(Root root);
    public event GetWeatherEnd getWeatherEnd;

    void Start()
    {
        buttonsView.weatherButtonClik+= StartGet_Weather;
    }

    public void StartGet_Weather()
    {
        StartCoroutine(Get_Weather());
    }

    private IEnumerator Get_Weather()
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(defaultConfig.URLWeather);
        yield return webRequest.SendWebRequest();
        var myDeserializedClass = JsonUtility.FromJson<Root>(webRequest.downloadHandler.text);
        getWeatherEnd?.Invoke(myDeserializedClass);
    }

}
