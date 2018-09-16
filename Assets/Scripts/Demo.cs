//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEditor;
//using UnityEditor.Callbacks;
//using UnityEngine;
//using UnityEngine.Assertions;
//using UnityEngine.Networking;
//
//// ReSharper disable CheckNamespace
//
//namespace DefaultNamespace
//{
//    public class Inspections : MonoBehaviour
//    {
//        // Incorrect method signature
//        private static int Start(int a, int b)
//        {
//            throw new NotImplementedException();
//        }
//
//        // Redundant event function - perf!
//        private void Update()
//        {
//        }
//
//        // Unused optional parameter
//        private void OnCollisionEnter(Collision other)
//        {
//            // System.Console.WriteLine(other);
//            throw new NotImplementedException();
//        }
//
//        // This function can be a coroutine
//        private void OnMouseEnter()
//        {
//            Debug.Log("OnMouseEnter");
////            StartCoroutine("OnMouseEnter");
//        }
//
//        // Use CompareTag - perf!
//        private void OnTriggerEnter(Collider other)
//        {
//            if (other.tag == "Boundary" || tag == "Enemy")
//            {
//                return;
//            }
//        }
//
//        private void MorePerformance(IEnumerable<Ball> balls, Ball key)
//        {
//            var isContained = balls.Any(x => x == key);
//            var otherBalls = balls.Where(x => x != key);
//            
//            // Postfix?
//        }
//
//        private void Formatting(float x, float y, float z)
//        {
//            var vector1 = new Vector3(x * x, y * 2, z * 2 + 10);
//            var vector2 = new Vector3(x * x * y * z, y, z * 2);
//            var vector3 = new Vector3(0, x, z * 2);
//        }
//
//        struct MyStruct
//        {
//            public Matrix4x4 Matrix;
//            public Vector2 SomeVector;
//            public Vector3 JustAnotherVector;
//            public Color32 AndSomeColor;
//            public Quaternion GimbalLockNotForMeRotation;
//        }
//
//        private void DoSomething(GameObject go)
//        {
//            var behaviour = new MonoBehaviourBasedClass();
//
//            var scriptableObject = new ScriptableObjectBasedClass();
//        }
//
//        private void NullAnalysis(object myObject, object myObject2)
//        {
//            // Code completion on message, too
//            Debug.Assert(myObject != null, "myObject != null");
//
//            if (myObject == null)
//            {
//                Debug.Log("Invalid value!");
//            }
//
//            // Code completion on message
//            Assert.IsNotNull(myObject2);
//
//            if (myObject2 != null)
//            {
//                Debug.Log("Invalid value!");
//            }
//        }
//
//        private void StringFormatting(int value, string name)
//        {
//            Debug.LogFormat("{0} has value: {1}", name, value);
//        }
//    }
//
//    public class MethodSignatureInspections
//    {
//        [InitializeOnLoadMethod]
//        public int DoInitializeOnLoadMethod(int value)
//        {
//            return 0;
//        }
//
//        [RuntimeInitializeOnLoadMethod]
//        public int DoRuntimeInitializeOnLoadMethod(int value)
//        {
//            return 0;
//        }
//
////        [OnOpenAsset]
////        public int DoOnOpenAsset(string filename)
////        {
////            return 1;
////        }
//
////        [DidReloadScripts]
////        public int DoDidReloadScripts(int value)
////        {
////            return 0;
////        }
//
//        [PostProcessScene]
//        public int DoPostProcessScene(int value, string value2)
//        {
//            return 0;
//        }
//    }
//
//    // Requires a static constructor
//    // Alt+Enter to fix
//    [InitializeOnLoad]
//    public class RedundantInitializeOnLoad
//    {
//    }
//
//    // Attribute requires base class
//    // Alt+Enter to fix
//    [CustomEditor(typeof(Ball))]
//    public class RequiresEditorBaseClass
//    {
//    }
//
//    // Attribute requires base class
//    // Alt+Enter to fix
//    [RequireComponent(typeof(Ball))]
//    public class RequiresComponentBaseClass
//    {
//    }
//
//    public class InvalidSyncVarUsage : NetworkBehaviour
//    {
//        // SyncVar can only be in a NetworkBehaviour
//        [SyncVar]
//        public string MyField;
//    }
//
//    #region Implementations
//
//    public class MonoBehaviourBasedClass : MonoBehaviour
//    {
//    }
//
//    public class ScriptableObjectBasedClass : ScriptableObject
//    {
//    }
//
//    #endregion
//}