using UnityEngine;
using Zenject;

public class UIInstaller : MonoInstaller
{
    [SerializeField] private ButtonsView _buttonsView;
    [SerializeField] private VideoPlayerView _videoPlayerView;
    [SerializeField] private WebViewController _webViewController;
    [SerializeField] private WeatherView _weatherView;
    [SerializeField] private WebCumController _webCumController;
    [SerializeField] private DataReading _dataReading;
    public override void InstallBindings()
    {
        Container.Bind<ButtonsView>().FromComponentInNewPrefab(_buttonsView).AsSingle();
        Container.InstantiatePrefabForComponent<VideoPlayerView>(
            _videoPlayerView, transform);
        Container.InstantiatePrefabForComponent<WebViewController>(
            _webViewController, transform);
        Container.InstantiatePrefabForComponent<WeatherView>(
            _weatherView, transform);
        Container.InstantiatePrefabForComponent<WebCumController>(
            _webCumController, transform);
        Container.InstantiatePrefabForComponent<DataReading>(
            _dataReading, transform);

    }
}
