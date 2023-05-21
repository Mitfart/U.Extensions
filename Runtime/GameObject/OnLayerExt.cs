using UnityEngine;

namespace Extentions.Local {
  public static partial class OnLayerExt {
    public static bool IsInLayerMask(this GameObject g, LayerMask layerMask) => layerMask.Equal(g.layer);
  }
}