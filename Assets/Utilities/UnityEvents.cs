using System;
using UnityEngine;
using UnityEngine.Events;

// Allows passing arguments dynamically through UnityEvents
// Add additional classes as needed.
[Serializable] public class IntEvent : UnityEvent<int> { }
[Serializable] public class FloatEvent : UnityEvent<float> { }
[Serializable] public class StringEvent : UnityEvent<String> { }
[Serializable] public class Vector2Event : UnityEvent<Vector2> { }
[Serializable] public class Vector3Event : UnityEvent<Vector3> { }
[Serializable] public class GameObjectEvent : UnityEvent<GameObject> { }
[Serializable] public class ScriptableObjectEvent : UnityEvent<ScriptableObjectEvent> { }
[Serializable] public class TransformEvent : UnityEvent<Transform> { }
[Serializable] public class BoolEvent : UnityEvent<bool> { }
[Serializable] public class ColliderEvent: UnityEvent<Collider> { }
