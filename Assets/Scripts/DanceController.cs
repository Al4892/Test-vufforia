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
}
