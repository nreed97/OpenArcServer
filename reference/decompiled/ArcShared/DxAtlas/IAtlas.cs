using System.Runtime.InteropServices;

namespace DxAtlas;

[ComImport]
[TypeIdentifier]
[Guid("9805614B-F01A-4904-AD4F-81F99E52082C")]
public interface IAtlas
{
	void _VtblGap1_4();

	int Width
	{
		[DispId(3)]
		get;
		[DispId(3)]
		[param: In]
		set;
	}

	int Height
	{
		[DispId(4)]
		get;
		[DispId(4)]
		[param: In]
		set;
	}

	bool Visible
	{
		[DispId(7)]
		get;
		[DispId(7)]
		[param: In]
		set;
	}

	[DispId(8)]
	void BringToFront();

	void _VtblGap2_6();

	DxMap Map
	{
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
