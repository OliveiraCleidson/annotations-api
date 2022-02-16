using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AnnotationApp.Infra.Data;
using Dapper;

namespace AnnotationApp.Infra.Extensions.Dapper;

public class ColumnAttributeTypeMapper<T> :  FallbackTypeMapper
{
    public ColumnAttributeTypeMapper() : base(
        new List<SqlMapper.ITypeMap>()
        {
            new CustomPropertyTypeMap(
                typeof(AnnotationModel),
                (type, columnName) =>
                {
                    return type.GetProperties()
                        .FirstOrDefault(prop =>
                            prop
                                .GetCustomAttributes(false)
                                .OfType<ColumnAttribute>()
                                .Any(attr => attr.Name == columnName));
                }),
                new DefaultTypeMap(typeof(AnnotationModel))
        }
        )
    {
    }
}