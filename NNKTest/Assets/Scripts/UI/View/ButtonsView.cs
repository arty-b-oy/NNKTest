using UnityEngine;
using UnityEngine.UI;

public class ButtonsView : MonoBehaviour
{
    [SerializeField] private Button _videoButton;
    [SerializeField] private Button _webcamButton;
    [SerializeField] private Button _webpageButton;
    [SerializeField] private Button _weatherButton;
    [SerializeField] private Button _dataButton;
    private RectTransform rectTransform;

    public delegate void VideoButtonClik();
    public event VideoButtonClik videoButtonClik;

    public delegate void WebcamButtonClik();
    public event WebcamButtonClik webcamButtonClik;

    public delegate void WebpageButtonClik();
    public event WebpageButtonClik webpageButtonClik;

    public delegate void WeatherButtonClik();
    public event WeatherButtonClik weatherButtonClik;

    public delegate void DataButtonClik();
    public event DataButtonClik dataButtonClik;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        var localPosition = rectTransform.anchoredPosition;
        transform.SetParent(FindObjectOfType<CanvasTag>().transform);
        rectTransform.anchoredPosition = localPosition;
        _videoButton.onClick.AddListener(VideoButtonClikMethod);
        _webcamButton.onClick.AddListener(WebcamButtonClikMethod);
        _webpageButton.onClick.AddListener(WebpageButtonClikMethod);
        _weatherButton.onClick.AddListener(WeatherButtonClikMethod);
        _dataButton.onClick.AddListener(DataButtonClikMethod);
    }
    private void VideoButtonClikMethod()
    {
        videoButtonClik?.Invoke();
    }
    private void WebcamButtonClikMethod()
    {
        webcamButtonClik?.Invoke();
    }
    private void WebpageButtonClikMethod()
    {
        webpageButtonClik?.Invoke();
    }
    private void WeatherButtonClikMethod()
    {
        weatherButtonClik?.Invoke();
    }
    private void DataButtonClikMethod()
    {
        dataButtonClik?.Invoke();
    }
}
