using UnityEngine;

namespace Extentions.Local {
  public static partial class OnLayerExt {
    public static bool IsInLayerMask(this Transform t, LayerMask layerMask) => layerMask.Equal(t.gameObject.layer);
  }
}