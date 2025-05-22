using UnityEngine;

namespace RtsOop
{
    public class CompositionRoot : MonoBehaviour
    {
        private static ISpawner Spawner;
        private static IMonoProvider MonoProvider;
        private static IUnitRepository UnitRepository;
        private static IResourceManager ResourceManager;

        public static ISpawner GetSpawner()
        {
            if (Spawner == null)
            {
                var unitRepository = GetUnitRepository();
                var resourceManager = GetResourceManager();

                Spawner = new Spawner(unitRepository, resourceManager);
            }

            return Spawner;
        }

        public static IUnitRepository GetUnitRepository()
        {
            if (UnitRepository == null)
            {
                UnitRepository = new UnitRepository();
            }

            return UnitRepository;
        }

        public static IResourceManager GetResourceManager()
        {
            if (ResourceManager == null)
            {
                ResourceManager = new ResourceManager();
            }
            return ResourceManager;
        }

        public static IMonoProvider GetMonoProvider()
        {
            if (MonoProvider == null)
            {
                var gameObject = new GameObject("MonoProvider");
                MonoProvider = gameObject.AddComponent<MonoProvider>();
            }

            return MonoProvider;
        }
    }
}