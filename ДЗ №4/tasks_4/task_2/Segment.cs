namespace task_2
{
    public sealed class Segment
    {
        private int Left { get; } // я использовать автосвойства, чтобы не определять лишних свойств
        private int Right { get; }
        public int Length { get => Right - Left; }

        public Segment(int left, int right)
        {
            if (left > right)
            {
                left ^= right; // меняем значения местами без использования дополнительных переменных
                right ^= left;
                left ^= right;
            }
            Left = left;
            Right = right;
        }

        public override bool Equals(object obj) => obj is Segment e && Length == e.Length;

        public override int GetHashCode() => Length;

        public override string ToString() => "( " + Left + " : " + Right + " )";

        public static Segment operator +(Segment s1, Segment s2)
        {
            if (s1 == null || s2 == null)
            {
                throw new System.ArgumentNullException(nameof(s1) + " " + nameof(s2));
            }
                return new Segment(s1.Left + s2.Left, s1.Right + s2.Right);
        }

        public static explicit operator uint(Segment s1)
        {
            if(s1 == null)
            {
                throw new System.ArgumentNullException(nameof(s1));
            }
            return (uint)s1.Length;
        }

        public static implicit operator Segment((int a, int b) tuple) => new Segment(tuple.a, tuple.b);
    }
}
