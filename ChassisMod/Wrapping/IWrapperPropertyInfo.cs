namespace ChassisMod.Wrapping
{
    interface IWrapperPropertyInfo
    {
        string Name { get; }

        string Value { get; }

        bool ValueIsDefault { get; }
    }
}
