using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<string> _onsecondPassed;
    [SerializeField]
    private UnityEvent _onTimerFinished;
    private Coroutine _timerCoroutine;

    public void StartTimer(float duration)
    {
        _timerCoroutine = StartCoroutine(RunTimer(duration));
    }

    private IEnumerator RunTimer(float duration)
    {
        _onsecondPassed?.Invoke("" + duration);
        yield return new WaitForSeconds(1);
        duration--;
        if (duration > 0)
        {
            _timerCoroutine = StartCoroutine(RunTimer(duration));

        }
        else
        {
            _timerCoroutine = null;
            _onTimerFinished?.Invoke();
        }
    }
    public void StopTimer()
    {
        if (_timerCoroutine != null)
        {
            StopCoroutine(_timerCoroutine);
            _timerCoroutine = null;
         }
    }

}
