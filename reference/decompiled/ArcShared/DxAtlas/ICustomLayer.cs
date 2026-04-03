using System.Runtime.InteropServices;

namespace DxAtlas;

[ComImport]
[TypeIdentifier]
[Guid("7B7D8E22-FB6F-4669-B2E8-271D103F7C40")]
public interface ICustomLayer
{
	void _VtblGap1_1();

	EnumColor PenColor
	{
		[DispId(2)]
		get;
		[DispId(2)]
		[param: In]
		set;
	}

	EnumColor BrushColor
	{
		[DispId(3)]
		get;
		[DispId(3)]
		[param: In]
		set;
	}

	void _VtblGap2_2();

	bool LabelsTransparent
	{
		[DispId(7)]
		get;
		[DispId(7)]
		[param: In]
		set;
	}

	void _VtblGap3_4();

	[DispId(10)]
	void SetData([In][MarshalAs(UnmanagedType.Struct)] object AData);

	void _VtblGap4_2();

	int PointSize
	{
		[DispId(6)]
		get;
		[DispId(6)]
		[param: In]
		set;
	}
}
