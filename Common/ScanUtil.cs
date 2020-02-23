using UnityEngine;

namespace Common
{
    public static class ScanTool
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

        public static void ScanHiearchy(Component component, string name)
        {
            var transform = component.transform;
            while (transform.parent != null)
                transform = transform.parent;

            ScanChildren(transform, 0, name);
        }

        private static void ScanChildren(Transform transform, int deeph, string name)
        {
            var tab = new string(' ', deeph);
            if (transform.gameObject.name.Contains(name))
            {
                Log.Message(tab + transform.gameObject.name);
                var parent = transform.parent;
                while (parent != null)
                {
                    Log.Message(tab + "+" + parent.name);
                    parent = parent.parent;
                }
            }
                
            for (var i = 0; i < transform.childCount; i++)
                ScanChildren(transform.GetChild(i), deeph + 1, name);
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
