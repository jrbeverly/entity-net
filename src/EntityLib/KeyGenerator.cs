namespace EntityLib
{
    public interface IKeyGenerator<TKey>
    {
        TKey Generate();
    }
}