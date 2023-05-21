using UnityEngine;

namespace Extentions.Local {
  public static class Look2DExt {
    public static void LookAt2D(this Transform transform, Vector3 target, Vector3? eye = null) {
      float signedAngle = Vector2.SignedAngle(eye ?? transform.up, target - transform.position);

      if (Mathf.Abs(signedAngle) < 1e-3f)
        return;

      Vector3 angles = transform.eulerAngles;
      angles.z              += signedAngle;
      transform.eulerAngles =  angles;
    }

    public static void LookAt2D(this Transform transform, Transform target, Vector3? eye = null) {
      LookAt2D(transform, target.position, eye);
    }
  }
}