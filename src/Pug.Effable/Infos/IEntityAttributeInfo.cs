using System.Runtime.Serialization;

namespace Pug.Effable
{
    public interface IEntityAttributeInfo<TKey, TValue> : INamed<TKey>
    {
        [DataMember(IsRequired = true)]
        TValue Value { get; set; }
    }
}