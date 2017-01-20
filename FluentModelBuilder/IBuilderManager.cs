namespace ExpressApp.FluentModelBuilder.XAF
{
    public interface IBuilderManager : IBuilder
    {
        void AddBuilder(IBuilder builder);
    }
}