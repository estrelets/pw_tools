namespace Pw.Proxy
{
    public enum Direction
    {
        Target,
        Source
    }

    public static class DirectionExtensions
    {
        public static Direction Revert(this Direction d)
        {
            return d == Direction.Source
                ? Direction.Target
                : Direction.Source;
        }
    }
}
