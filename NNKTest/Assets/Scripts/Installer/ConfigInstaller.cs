using UnityEngine;
using Zenject;
public class ConfigInstaller : MonoInstaller
{
    [SerializeField] private DefaultConfig _defaultConfig;

    public override void InstallBindings()
    {
        Container.Bind<DefaultConfig>().FromInstance(_defaultConfig).AsSingle();
    }
}
