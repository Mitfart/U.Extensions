﻿using UnityEngine;

public static class DontDestroyExt {
   public static TObj DontDestroy<TObj>(this TObj obj) where TObj : Object {
      Object.DontDestroyOnLoad(obj);
      return obj;
   }
}