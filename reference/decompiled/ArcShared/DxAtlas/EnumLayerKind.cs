using System.Runtime.InteropServices;

namespace DxAtlas;

[TypeIdentifier("77b1cbfa-2d59-4c0c-bcd7-6a894b760112", "DxAtlas.EnumLayerKind")]
[Guid("B0164F53-7A6B-46B6-B416-2167440D0376")]
public enum EnumLayerKind
{
	LK_POINTS = 1,
	LK_LINES,
	LK_AREAS,
	LK_LABELS,
	LK_GLYPHS
}
