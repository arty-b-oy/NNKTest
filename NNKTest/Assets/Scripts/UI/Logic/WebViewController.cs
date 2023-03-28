using UnityEngine;
using Zenject;

public class WebViewController : MonoBehaviour
{
    [Inject] private ButtonsView buttonsView;
    [Inject] private DefaultConfig defaultConfig;
    WebViewObject webViewObject;
    void Awake()
    {
        webViewObject = GetComponent<WebViewObject>();
        webViewObject.Init();
        webViewObject.SetMargins(Screen.width/2, 30, 30, 30);
        webViewObject.SetVisibility(false);
        webViewObject.LoadURL(defaultConfig.URLWebView.Replace(" ", "%20"));
        buttonsView.webpageButtonClik += ActivWedView;

    }

    public void ActivWedView()
    {
        webViewObject.SetVisibility(!webViewObject.GetVisibility());
    }
}
