using UnityEngine;

namespace Extentions.Local {
  public static class GetCirclePosExt {
    public static Vector2 GetCirclePos(
      this Vector2 pos,
      Vector2      center,
      float        angle,
      float        radius   = 1,
      float        maxRange = 360
    ) {
      float ang = angle * maxRange / 360;
      pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
      pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
      return pos;
    }
  }
}