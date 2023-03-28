using UnityEngine;
using Zenject;
public class WebCumController : MonoBehaviour
{
    [Inject] private ButtonsView buttonsView;
    [Inject] private DefaultConfig defaultConfig;

    WebViewObject webViewObject;
    void Awake()
    {
        webViewObject = GetComponent<WebViewObject>();
        webViewObject.Init();
        webViewObject.SetMargins(Screen.width / 2, 30, 30, 30);
        webViewObject.SetVisibility(false);
        webViewObject.LoadURL(defaultConfig.URLWebCum.Replace(" ", "%20"));
        buttonsView.webcamButtonClik += ActivWedView;

    }

    public void ActivWedView()
    {
        webViewObject.SetVisibility(!webViewObject.GetVisibility());
    }
}
