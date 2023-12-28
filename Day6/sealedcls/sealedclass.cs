namespace sealednamespace;

public sealed class Demo
{
    private int num;
    private Demo()
    {
        this.num = 7;
    }

    public static Demo _ref = null;

    public static Demo GetInstance()
    {
        if (_ref == null)
        {
            _ref = new Demo();
        }
        return _ref;
    }

    public int GetNum()
    {
        return this.num;
    }
}