
using UnityEngine;

namespace MyNamespace
{
   public static class SuperTool
   {

      public static Vector3 DifficultOperation(this Vector3 vec, int a)
      {
         Vector3 res = vec + new Vector3(a, a * 3, a*a);
         return res;
      }

   }
}
