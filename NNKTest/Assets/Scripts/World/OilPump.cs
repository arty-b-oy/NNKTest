using UnityEngine;

public class OilPump : MonoBehaviour
{
    public delegate void OilPumpClik();
    public event OilPumpClik oilPumpClik;

    private void Start()
    {
        transform.SetParent(FindObjectOfType<WorldTag>().transform);
    }
    private void OnMouseDown()
    {
        oilPumpClik?.Invoke();
    }
}
