using UnityEngine;

namespace Extentions.Local {
  public static partial class GetParentWithExt {
    private static T GetFirstParentWith<T>(this GameObject obj)
      where T : Component
      => obj.transform.GetFirstParentWith<T>();
  }
}