﻿using UnityEngine;

namespace Extentions.Local {
  public static class DrawBoxCastExt {
    public static RaycastHit2D BoxCastDebug(
      Vector2   origin,
      Vector2   size,
      float     angle,
      Vector2   direction,
      float     distance,
      LayerMask mask
    ) {
      RaycastHit2D hit = Physics2D.BoxCast(
        origin,
        size,
        angle,
        direction,
        distance,
        mask
      );


      #region UpdateDebugView

      //Setting up the points to draw the cast
      float w  = size.x * 0.5f;
      float h  = size.y * 0.5f;
      var   p1 = new Vector2(-w, h);
      var   p2 = new Vector2(w,  h);
      var   p3 = new Vector2(w,  -h);
      var   p4 = new Vector2(-w, -h);

      var q = Quaternion.AngleAxis(angle, new Vector3(0, 0, 1));
      p1 = q * p1;
      p2 = q * p2;
      p3 = q * p3;
      p4 = q * p4;

      p1 += origin;
      p2 += origin;
      p3 += origin;
      p4 += origin;

      Vector2 realDistance = direction.normalized * distance;
      Vector2 p5           = p1 + realDistance;
      Vector2 p6           = p2 + realDistance;
      Vector2 p7           = p3 + realDistance;
      Vector2 p8           = p4 + realDistance;


      //Drawing the cast
      Color castColor = hit ? Color.red : Color.green;
      Debug.DrawLine(p1, p2, castColor);
      Debug.DrawLine(p2, p3, castColor);
      Debug.DrawLine(p3, p4, castColor);
      Debug.DrawLine(p4, p1, castColor);

      Debug.DrawLine(p5, p6, castColor);
      Debug.DrawLine(p6, p7, castColor);
      Debug.DrawLine(p7, p8, castColor);
      Debug.DrawLine(p8, p5, castColor);

      Debug.DrawLine(p1, p5, Color.grey);
      Debug.DrawLine(p2, p6, Color.grey);
      Debug.DrawLine(p3, p7, Color.grey);
      Debug.DrawLine(p4, p8, Color.grey);

      if (hit)
        Debug.DrawLine(hit.point, hit.point + hit.normal.normalized * 0.2f, Color.yellow);

      #endregion


      return hit;
    }
  }
}