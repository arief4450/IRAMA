using UnityEngine.Events;
using UnityEngine;
using System;

namespace RhythmGameStarter
{
    [Serializable]
    public class StringEvent : UnityEvent<string>
    {
        internal void Invoke()
        {
            throw new NotImplementedException();
        }
    }
    [Serializable] public class BoolEvent : UnityEvent<bool> { }
    [Serializable] public class FloatEvent : UnityEvent<float> { }
    [Serializable] public class TouchEvent : UnityEvent<Touch> { }
}
