using UnityEngine;
using Zenject;
public class DataReading : MonoBehaviour
{
    [Inject] private ButtonsView buttonsView;
    [Inject] private OilPump oilPump;
    public delegate void GetDataEnd(string[] massData);
    public event GetDataEnd getDataEnd;

    void Start()
    {
        buttonsView.dataButtonClik += GetData;
        oilPump.oilPumpClik += GetData;
    }

    private void GetData()
    {
        TextAsset data = Resources.Load<TextAsset>("Oildata");
        string[] massData = data.ToString().Split(';', '\n');
        getDataEnd?.Invoke(massData);
    }
}
