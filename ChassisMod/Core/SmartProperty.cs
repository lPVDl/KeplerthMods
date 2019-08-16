using System;

namespace ChassisMod.Core
{
    partial class DataWrapper<TConfig>
    {
        public class SmartProperty<TData>
        {         
            private readonly string _name;
            private readonly DataWrapper<TConfig> _owner;
            private readonly Func<TConfig, TData> _getData;
            private readonly Action<TConfig, TData> _setData;
            private readonly TData _rawData;
            private readonly Func<TData, bool> _validateData;

            public static implicit operator SmartProperty<TData>(TData data) => new SmartProperty<TData>(data);

            internal SmartProperty(string name, DataWrapper<TConfig> owner, Func<TConfig, TData> getData, Action<TConfig, TData> setData, Func<TData, bool> validateData)
            {
                _name = name;
                _owner = owner;
                _getData = getData;
                _setData = setData;
                _validateData = validateData;
            }

            private SmartProperty(TData data) => _rawData = data; 

            internal void Patch(SmartProperty<TData> source)
            {
                if (source == null) throw new ArgumentNullException($"{_owner}.{_name} = null");
                if (_owner == null) throw new InvalidOperationException("Property with raw data can not be patched");

                if (source._owner == null)
                {
                    if (!_validateData(source._rawData)) throw new ArgumentException($"{_owner}.{_name} = {source._rawData}");

                    Action patch = () =>
                    {
                        _setData(_owner.Config, source._rawData);
                    };

                    DataPatcher.Add(patch, $"{_owner}.{_name} = {source._rawData}");
                }
                else
                {
                    Action patch = () =>
                    {
                        var data = _getData(source._owner.Config);
                        _setData(_owner.Config, data);
                    };

                    DataPatcher.Add(patch, $"{_owner}.{_name} = {source}.{source._name}");
                }
            }
        }
    }
}
