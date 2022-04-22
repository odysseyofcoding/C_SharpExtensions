using System;
using System.Numerics;

namespace MyProj
{
    public static class Vector2Extensions
    {
        public static Vector2 SetMag(this Vector2 vector2, float length)
        {
            vector2 = Vector2.Normalize(vector2);
            vector2 = Vector2.Multiply(vector2, length);
            if (float.IsNaN(vector2.X))
            {
                return new Vector2(0, 0);
            }

            return vector2;

        }
        public static Vector2 Limit(this Vector2 vector2, float max)
        {
            var mSq = vector2.MagSq();
            if (mSq > max * max)
            {
                vector2 = Vector2.Divide(vector2, (float)Math.Sqrt(mSq));
                vector2 = Vector2.Multiply(max, vector2);
            }
            return vector2;
        }
        public static Vector2 MyAdd(this Vector2 vector2, float x, float y)
        {
            return new Vector2(vector2.X += x, vector2.Y += y);
        }
        public static float Heading(this Vector2 vector2)
        {
            return MathF.Atan2(vector2.Y, vector2.X);
        }

        public static float MagSq(this Vector2 vector2)
        {
            return vector2.X * vector2.X + vector2.Y * vector2.Y;
        }
    }
}
