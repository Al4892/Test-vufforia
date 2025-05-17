using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onSelectDance;
    [SerializeField]
    private UnityEvent _onDanceSelected;

    public void ActiveSelectDance()
    {
        _onSelectDance?.Invoke();
    }
    public void onSelectedDance()
    {
        _onDanceSelected?.Invoke();
    }
}
