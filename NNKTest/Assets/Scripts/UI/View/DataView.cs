using UnityEngine;
using TMPro;
public class DataView : MonoBehaviour
{
    [SerializeField] private GameObject _bodyGameObject;
    [SerializeField] private TextMeshProUGUI _nameText;
    void Start()
    {
        GetComponent<DataReading>().getDataEnd += PresentData;
    }

    private void PresentData(string[] massData)
    {
        string oneElementData;
        _nameText.text = null;
        for (int i=0;i< massData.Length-1; i += 2)
        {
            oneElementData = string.Format("{0,20}  {1,10}", massData[i], massData[i+1]);
            _nameText.text += oneElementData + '\n';
        }
        _bodyGameObject.SetActive(!_bodyGameObject.activeSelf);
    }
}
