using UnityEngine;

[CreateAssetMenu(fileName = "SoundData", menuName = "Scriptable Objects/SoundData")]
public class SoundData : ScriptableObject
{
    public string MusiName;
    public string AnimationName;
    public TextAsset notesConfig;
    public float Speed;
}
