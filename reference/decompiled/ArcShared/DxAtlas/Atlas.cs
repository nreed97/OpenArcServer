using System.Runtime.InteropServices;

namespace DxAtlas;

[ComImport]
[Guid("9805614B-F01A-4904-AD4F-81F99E52082C")]
[TypeIdentifier]
[CoClass(typeof(object))]
public interface Atlas : IAtlas, IDxAtlasEvents_Event
{
}
