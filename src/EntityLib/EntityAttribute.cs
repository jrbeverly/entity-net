using System;

namespace EntityLib
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EntityAttribute : Attribute
    {
        public Type UnderlyingType;

        public EntityAttribute(Type keyType)
        {
            UnderlyingType = keyType;
        }
    }
}
