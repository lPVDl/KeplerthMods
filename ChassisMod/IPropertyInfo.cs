namespace ChassisMod
{
    interface IPropertyInfo
    {
        string Name { get; }

        string Value { get; }

        bool ValueIsDefault { get; }
    }
}
