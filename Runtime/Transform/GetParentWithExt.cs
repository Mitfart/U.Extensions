using JetBrains.Annotations;
using UnityEngine;

namespace Extentions.Local {
  public static partial class GetParentWithExt {
    [CanBeNull]
    public static T GetFirstParentWith<T>(this Transform transform) where T : Component {
      const int MAX_I = 10000;

      var i = 0;

      while (transform != null && i < MAX_I) {
        i++;
        Transform parent = transform.parent;
        if (parent == null)
          return null;

        if (parent.TryGetComponent(out T component))
          return component;

        transform = parent;
      }

      return null;
    }
  }
}