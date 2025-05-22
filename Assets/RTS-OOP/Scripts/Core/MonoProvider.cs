using System.Collections.Generic;
using UnityEngine;

namespace RtsOop
{
    public class MonoProvider : MonoBehaviour, IMonoProvider
    {
        private List<IUpdatable> Updatables = new List<IUpdatable>();

        private void Update()
        {
            foreach (var updatable in Updatables)
            {
                updatable.Update(Time.deltaTime);
            }
        }

        public void Add(IUpdatable updatable)
        {
            Updatables.Add(updatable);
        }

        public void Remove(IUpdatable updatable)
        {
            Updatables.Remove(updatable);
        }
    }
}