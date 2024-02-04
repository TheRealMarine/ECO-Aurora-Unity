using System.Collections;
using UnityEngine;

namespace Utils
{
    public class CoroutineWithData<T>
    {
        private IEnumerator target;
        public  T           Result    { get; private set; }
        public  Coroutine   Coroutine { get; private set; }

        public CoroutineWithData(MonoBehaviour owner, IEnumerator target)
        {
            this.target   = target;
            Coroutine = owner.StartCoroutine(Run());
        }

        private IEnumerator Run()
        {
            while (this.target.MoveNext())
            {
                Result = (T)this.target.Current;
                yield return Result;
            }
        }
    }
}