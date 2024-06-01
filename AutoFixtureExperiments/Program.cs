// See https://aka.ms/new-console-template for more information
using AutoFixture;
using AutoFixture.Kernel;
using AutoFixtureExperiments;
using Xunit;

Console.WriteLine("Hello, World!");
var obj = new TestClass();

obj.CreateBase();


public class TestClass
{
    public void CreateBase()
    {

        var fixture = new Fixture().Customize(new BaseCustomization());

        var actual = fixture.CreateMany<BaseClass>(4).ToArray();

        Assert.IsAssignableFrom<BaseImplA>(actual[0]);
        Assert.NotEqual(default(string), actual[0].Text);
        Assert.NotEqual(default(int), actual[0].Value);

        Assert.IsAssignableFrom<BaseImplB>(actual[1]);
        Assert.NotEqual(default(string), actual[1].Text);
        Assert.Equal(1, actual[1].Value);

        Assert.IsAssignableFrom<BaseImplA>(actual[2]);
        Assert.NotEqual(default(string), actual[2].Text);
        Assert.NotEqual(default(int), actual[2].Value);

        Assert.IsAssignableFrom<BaseImplB>(actual[3]);
        Assert.NotEqual(default(string), actual[3].Text);
        Assert.Equal(1, actual[3].Value);
    }
}



public class BCustomization : ICustomization
{
    public void Customize(IFixture fixture)
    {
        fixture.Customize<BaseImplB>(c => c.Without(x => x.Value));
    }
}

public class AlternatingCustomization : ICustomization
{
    public void Customize(IFixture fixture)
    {
        fixture.Customizations.Add(new AlternatingBuilder());
    }

    private class AlternatingBuilder : ISpecimenBuilder
    {
        private Dictionary<Type, Type> createInstanceList;
        private Type createInstanceOf;

        public AlternatingBuilder()
        {
            createInstanceList = new Dictionary<Type, Type>()
            {
                { typeof(BaseImplA), typeof(BaseImplB) },
                { typeof(BaseImplB), typeof(BaseImplC) },
                { typeof(BaseImplC), typeof(BaseImplA) }
            };
            createInstanceOf = typeof(BaseImplA);
        }
        public object Create(object request, ISpecimenContext context)
        {
            var t = request as Type;
            if (t == null || t != typeof(BaseClass))
                return new NoSpecimen();

            switch (createInstanceOf.Name)
            {
                case nameof(BaseImplA):
                    createInstanceOf = createInstanceList.GetValueOrDefault(typeof(BaseImplA));
                    return context.Resolve(typeof(BaseImplA));
                case nameof(BaseImplB):
                    createInstanceOf = createInstanceList.GetValueOrDefault(typeof(BaseImplB));
                    return context.Resolve(typeof(BaseImplB));
                case nameof(BaseImplC):
                    createInstanceOf = createInstanceList.GetValueOrDefault(typeof(BaseImplC));
                    return context.Resolve(typeof(BaseImplC));
                default:
                    return new NoSpecimen();
            }

            return new NoSpecimen(); 
        }
    }
}

public class BaseCustomization : CompositeCustomization
{
    public BaseCustomization()
        : base(
            new BCustomization(),
            new AlternatingCustomization())
    {
    }
}