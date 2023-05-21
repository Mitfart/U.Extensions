using UnityEngine;

namespace Extentions.Local {
  public static class EqualExt {
    public static bool Equal(this LayerMask mask, LayerMask layerMask) => (layerMask.value & (1 << mask)) > 0;
  }
}