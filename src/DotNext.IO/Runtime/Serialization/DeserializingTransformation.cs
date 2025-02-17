using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace DotNext.Runtime.Serialization;

using IDataTransferObject = IO.IDataTransferObject;

[StructLayout(LayoutKind.Auto)]
internal readonly struct DeserializingTransformation<TOutput> : IDataTransferObject.ITransformation<TOutput>
    where TOutput : notnull, ISerializable<TOutput>
{
    [RequiresPreviewFeatures]
    ValueTask<TOutput> IDataTransferObject.ITransformation<TOutput>.TransformAsync<TReader>(TReader reader, CancellationToken token)
        => TOutput.ReadFromAsync(reader, token);
}