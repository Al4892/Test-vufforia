using System;
using System.Collections.Generic;
using UnityEngine;



    [Serializable]
    public class NoteData
    {
        public float time;
        public int lane;
    }

    [Serializable]
    public class NoteChart
    {
        public List<NoteData> notes;
    }

