using System;

namespace Extentions.Local {
  public static class WithExt {
    public static T With<T>(this T self, Action<T> apply) {
      apply.Invoke(self);
      return self;
    }

    public static T With<T>(this T self, Action<T> apply, bool       when) => when ? self.With(apply) : self;
    public static T With<T>(this T self, Action<T> apply, Func<bool> when) => self.With(apply, when());
  }
}