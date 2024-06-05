using System.Collections.Generic;
using HotChocolate.Language;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;

#nullable enable

namespace HotChocolate.Types.Factories;

internal sealed class ObjectTypeFactory
    : ITypeFactory<ObjectTypeDefinitionNode, ObjectType>
    , ITypeFactory<ObjectTypeExtensionNode, ObjectTypeExtension>
{
    public ObjectType Create(IDescriptorContext context, ObjectTypeDefinitionNode node)
    {
        var path = context.GetOrCreateDefinitionStack();
        path.Clear();

        var typeDefinition = new ObjectTypeDefinition(
            node.Name.Value,
            node.Description?.Value)
        {
            BindTo = node.GetBindingValue(),
        };

        foreach (var typeNode in node.Interfaces)
        {
            typeDefinition.Interfaces.Add(TypeReference.Create(typeNode));
        }

        SdlToTypeSystemHelper.AddDirectives(context, typeDefinition, node, path);

        DeclareFields(context, typeDefinition, node.Fields, path);

        return ObjectType.CreateUnsafe(typeDefinition);
    }

    public ObjectTypeExtension Create(IDescriptorContext context, ObjectTypeExtensionNode node)
    {
        var path = context.GetOrCreateDefinitionStack();
        path.Clear();

        var typeDefinition = new ObjectTypeDefinition(node.Name.Value)
        {
            BindTo = node.GetBindingValue(),
        };

        foreach (var typeNode in node.Interfaces)
        {
            typeDefinition.Interfaces.Add(TypeReference.Create(typeNode));
        }

        SdlToTypeSystemHelper.AddDirectives(context, typeDefinition, node, path);

        DeclareFields(context, typeDefinition, node.Fields, path);

        return ObjectTypeExtension.CreateUnsafe(typeDefinition);
    }

    private static void DeclareFields(
        IDescriptorContext context,
        ObjectTypeDefinition parent,
        IReadOnlyCollection<FieldDefinitionNode> fields,
        Stack<IDefinition> path)
    {
        path.Push(parent);

        foreach (var field in fields)
        {
            var fieldDefinition = new ObjectFieldDefinition(
                field.Name.Value,
                field.Description?.Value,
                TypeReference.Create(field.Type))
            {
                BindTo = field.GetBindingValue(),
            };

            SdlToTypeSystemHelper.AddDirectives(context, fieldDefinition, field, path);

            if (field.DeprecationReason() is { Length: > 0, } reason)
            {
                fieldDefinition.DeprecationReason = reason;
            }

            DeclareFieldArguments(context, fieldDefinition, field, path);

            parent.Fields.Add(fieldDefinition);
        }

        path.Pop();
    }

    private static void DeclareFieldArguments(
        IDescriptorContext context,
        ObjectFieldDefinition parent,
        FieldDefinitionNode field,
        Stack<IDefinition> path)
    {
        path.Push(parent);

        foreach (var argument in field.Arguments)
        {
            var argumentDefinition = new ArgumentDefinition(
                argument.Name.Value,
                argument.Description?.Value,
                TypeReference.Create(argument.Type),
                argument.DefaultValue)
            {
                BindTo = argument.GetBindingValue(),
            };

            if (argument.DeprecationReason() is { Length: > 0, } reason)
            {
                argumentDefinition.DeprecationReason = reason;
            }

            SdlToTypeSystemHelper.AddDirectives(context, argumentDefinition, argument, path);

            parent.Arguments.Add(argumentDefinition);
        }

        path.Pop();
    }
}
