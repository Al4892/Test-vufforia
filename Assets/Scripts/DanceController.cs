using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
    [SerializeField]
    private Animator _characterAnimator;
    [SerializeField]
    private NotesManager _notesManager;
    [SerializeField]
    private UnityEvent _onSelectDance;
    [SerializeField]
    private UnityEvent _onDanceSelected;
    [SerializeField]
    private string _failAnimationName = "Fail";
    private Coroutine _resetDanceCoroutine;
    private SoundData _CurrentSoundData;

    public void ActiveSelectDance()
    {
        _onSelectDance?.Invoke();
    }
    public void onSelectedDance(SoundData soundData)
    {
        _CurrentSoundData = soundData;
        _onDanceSelected?.Invoke();
    }
    public void StartDance()
    {
        _characterAnimator.Play(_CurrentSoundData.AnimationName);
        SoundManager.instance.PlayMusic(_CurrentSoundData.MusiName);
        _notesManager.StartNoteChart(_CurrentSoundData.notesConfig, _CurrentSoundData.Speed);
    }
    public void FailedNote()
    {
        if (_resetDanceCoroutine != null)
        {
            StopCoroutine(_resetDanceCoroutine);
            
        }
        _resetDanceCoroutine=StartCoroutine(ResetDance());
    }
    public IEnumerator ResetDance()
    {
        _characterAnimator.Play(_failAnimationName,0,0f);
        float _failAnimationLenght = _characterAnimator.runtimeAnimatorController.animationClips.First(clip=>clip.name==_failAnimationName).length;
        yield return new WaitForSeconds(_failAnimationLenght);
        _characterAnimator.Play(_CurrentSoundData.AnimationName);
        _resetDanceCoroutine = null;
    }
     
}
