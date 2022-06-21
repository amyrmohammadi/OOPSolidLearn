namespace LearnOOP
{
    public interface IAddDot<T> where T :Dot
    {
         T AddDot(T t1 ,T t2);
    }
}