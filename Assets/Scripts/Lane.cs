using UnityEngine;

public class Lane : MonoBehaviour
{
    [SerializeField]
    private Transform notesOrigin;
    public Transform NotesOrigin
    {
        get { return notesOrigin; }

    }
    [SerializeField]
    private GameObject _notePrefab;
    public GameObject NotePrefab
    {
        get{ return _notePrefab; }
    }
}
