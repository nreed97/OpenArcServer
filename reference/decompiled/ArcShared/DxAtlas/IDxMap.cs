using System.Runtime.InteropServices;

namespace DxAtlas;

[ComImport]
[Guid("B5ED89B0-6104-4A46-B509-97D716514E9F")]
[TypeIdentifier]
public interface IDxMap
{
	void _VtblGap1_4();

	[DispId(4)]
	void BeginUpdate();

	[DispId(5)]
	void EndUpdate();

	EnumProjection Projection
	{
		[DispId(6)]
		get;
		[DispId(6)]
		[param: In]
		set;
	}

	void _VtblGap2_6();

	float HomeLatitude
	{
		[DispId(12)]
		get;
		[DispId(12)]
		[param: In]
		set;
	}

	float HomeLongitude
	{
		[DispId(13)]
		get;
		[DispId(13)]
		[param: In]
		set;
	}

	bool PrefixesVisible
	{
		[DispId(14)]
		get;
		[DispId(14)]
		[param: In]
		set;
	}

	void _VtblGap3_15();

	CustomLayers CustomLayers
	{
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
