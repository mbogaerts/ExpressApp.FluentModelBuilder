using DevExpress.ExpressApp.DC;

namespace ExpressApp.FluentModelBuilder.XAF
{
    public static class PropertyBuilderFactory
    {
        public static PropertyBuilder<TPropertyType, TClassType> PropertyBuilderFactoryMethod<TPropertyType, TClassType>(IMemberInfo member)
        {
            return new PropertyBuilder<TPropertyType, TClassType>(member);
        }
    }
}