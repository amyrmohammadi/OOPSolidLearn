namespace LearnOOP
{
    public interface IAddPoint<T> where T :Point
    {
          T AddPoint(T t1);
    }
}