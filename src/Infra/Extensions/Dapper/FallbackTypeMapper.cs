using System.Reflection;
using Dapper;

namespace AnnotationApp.Infra.Extensions.Dapper;

public class FallbackTypeMapper : SqlMapper.ITypeMap
{
    private readonly IEnumerable<SqlMapper.ITypeMap> _mappers;

    public FallbackTypeMapper(IEnumerable<SqlMapper.ITypeMap> mappers)
    {
        _mappers = mappers;
    }

    public ConstructorInfo FindConstructor(string[] names, Type[] types)
    {
        return _mappers
            .Select(mapper => mapper.FindConstructor(names, types))
            .First(result => result != null);
    }

    public ConstructorInfo FindExplicitConstructor()
    {
        return _mappers
            .Select(mapper => mapper.FindExplicitConstructor())
            .First(result => result != null);
    }

    public SqlMapper.IMemberMap GetConstructorParameter(ConstructorInfo constructor, string columnName)
    {
        return _mappers
            .Select(mapper => mapper.GetConstructorParameter(constructor, columnName))
            .First(result => result != null);
    }

    public SqlMapper.IMemberMap GetMember(string columnName)
    {
        foreach (var mapper in _mappers)
        {
            try
            {
                var result = mapper.GetMember(columnName);
                if(result != null) return result;
            }
            catch (NotImplementedException)
            {
                
            }
        }
        return null;
    }
}