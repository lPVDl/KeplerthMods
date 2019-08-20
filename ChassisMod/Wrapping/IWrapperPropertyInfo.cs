namespace ChassisMod.Wrapping
{
    interface IWrapperPropertyInfo
    {
        string Value { get; }

        bool ValueIsDefault { get; }
    }
}
