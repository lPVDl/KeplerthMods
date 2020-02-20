using UnityEngine;

namespace Common
{
    public static class ScanUtil
    {
        public static void ScanHierarchyUpwardsWithComponents(Component component)
        {
            var parent = component.transform.parent;
            if (parent != null)
                ScanHierarchyUpwardsWithComponents(parent);

            var deeph = ComputeDeeph(component.transform);
            var tab = new string(' ', deeph);
            Log.Message(tab + component.gameObject.name + ":");

            var comps = component.GetComponents<Component>();
            foreach (var com in comps)
                Log.Message(tab + com.GetType());
        }

        private static int ComputeDeeph(Transform transform)
        {
            int deeph = -1;
            while (transform != null)
            {
                transform = transform.parent;
                deeph++;
            };

            return deeph;
        }
    }
}
