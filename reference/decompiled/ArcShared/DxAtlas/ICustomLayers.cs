using System.Reflection;
using System.Runtime.InteropServices;

namespace DxAtlas;

[ComImport]
[TypeIdentifier]
[Guid("CD699E4E-B1EF-4734-97F7-F7A502C1FD25")]
[DefaultMember("Layer")]
public interface ICustomLayers
{
	void _VtblGap1_2();

	[DispId(3)]
	[return: MarshalAs(UnmanagedType.Interface)]
	CustomLayer Add([In] EnumLayerKind Kind);
}
