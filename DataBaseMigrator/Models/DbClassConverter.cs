using System.Linq;
using System.Reflection;

namespace Models
{
    public static class DbClassConverter<T, TS> where T : new()
    {
        public static void Convert(T target, TS origin)
        {
            if (target == null || origin == null) return;


            target.GetType()
                .GetProperties(BindingFlags.Public
                             | BindingFlags.Instance
                             | BindingFlags.DeclaredOnly)
                .ToList()
                .ForEach(p =>
                {
                    // ReSharper disable once PossibleNullReferenceException
                    if(!origin.GetType().GetProperty(p.Name).Equals( null)
                 )
                    target.GetType()
                          .GetProperty(p.Name)?
                          .SetValue(target, System.Convert.ChangeType(origin
                                                                      .GetType()
                                                                      .GetProperty(p.Name)?
                                                                      .GetValue(origin), p.PropertyType));
                });
        }
    }
}
