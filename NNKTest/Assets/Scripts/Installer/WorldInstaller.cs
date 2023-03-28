using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class WorldInstaller : MonoInstaller
{
    [SerializeField] private OilPump _oilPumpModel;
    public override void InstallBindings()
    {
        //var OilPump = Container.InstantiatePrefabForComponent<OilPump>(
          //  _oilPumpModel, transform);
        Container.Bind<OilPump>().FromComponentInNewPrefab(_oilPumpModel).AsSingle();
    }

}
