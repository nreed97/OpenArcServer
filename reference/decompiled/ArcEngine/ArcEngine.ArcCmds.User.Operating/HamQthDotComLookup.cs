using System;
using System.Runtime.CompilerServices;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Operating;

[Serializable]
public class HamQthDotComLookup
{
	private string _003CCallsign_003Ek__BackingField;

	private string _003CNick_003Ek__BackingField;

	private string _003CQth_003Ek__BackingField;

	private string _003CCountry_003Ek__BackingField;

	private string _003CAdif_003Ek__BackingField;

	private string _003CItuZone_003Ek__BackingField;

	private string _003CCqZone_003Ek__BackingField;

	private string _003CGrid_003Ek__BackingField;

	private string _003CAddressName_003Ek__BackingField;

	private string _003CAddressCity_003Ek__BackingField;

	private string _003CAddressZip_003Ek__BackingField;

	private string _003CAddressCountry_003Ek__BackingField;

	private string _003CAddressAdif_003Ek__BackingField;

	private string _003CUsState_003Ek__BackingField;

	private string _003CUsCounty_003Ek__BackingField;

	private string _003CLotw_003Ek__BackingField;

	private string _003CQsl_003Ek__BackingField;

	private string _003CEqsl_003Ek__BackingField;

	private string _003CLatitude_003Ek__BackingField;

	private string _003CLongitude_003Ek__BackingField;

	private string _003CContinent_003Ek__BackingField;

	private string _003CUtcOffset_003Ek__BackingField;

	private string _003CLookups_003Ek__BackingField;

	[SpecialName]
	internal string Ⴍ()
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		string result = _003CCallsign_003Ek__BackingField;
		BandModeCacheCfg.ႠႳ[245] = (char)((BandModeCacheCfg.ႠႳ[245] - SetTalkCountHelp.Ⴅ[89]) & 0x11);
		return result;
	}

	[SpecialName]
	internal void Ⴀ(string P_0)
	{
		_003CCallsign_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴀ()
	{
		string result = _003CNick_003Ek__BackingField;
		SetWxOutput.ႣႰ[18] = (char)((SetWxOutput.ႣႰ[18] + SetWxOutput.ႣႰ[39]) & 0x1E);
		return result;
	}

	[SpecialName]
	internal void Ⴅ(string P_0)
	{
		_003CNick_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴓ()
	{
		string result = _003CQth_003Ek__BackingField;
		ShowQrzHelp.ႤႤ[72] = SetAnnMode.ႤႭ[489];
		return result;
	}

	[SpecialName]
	internal void Ⴈ(string P_0)
	{
		_003CQth_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴅ()
	{
		return _003CCountry_003Ek__BackingField;
	}

	[SpecialName]
	internal void Ⴓ(string P_0)
	{
		_003CCountry_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴃ()
	{
		byte[] ⴐ = ႨႣ.Ⴐ;
		return _003CAdif_003Ek__BackingField;
	}

	[SpecialName]
	internal void Ⴗ(string P_0)
	{
		_003CAdif_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴐ()
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		return _003CItuZone_003Ek__BackingField;
	}

	[SpecialName]
	internal void Ⴄ(string P_0)
	{
		_003CItuZone_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴗ()
	{
		return _003CCqZone_003Ek__BackingField;
	}

	[SpecialName]
	internal void Ⴐ(string P_0)
	{
		_003CCqZone_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴈ()
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		return _003CGrid_003Ek__BackingField;
	}

	[SpecialName]
	internal void Ⴍ(string P_0)
	{
		_003CGrid_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴄ()
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		return _003CAddressName_003Ek__BackingField;
	}

	[SpecialName]
	internal void Ⴃ(string P_0)
	{
		_003CAddressName_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string Ⴜ()
	{
		return _003CAddressCity_003Ek__BackingField;
	}

	[SpecialName]
	internal void Ⴜ(string P_0)
	{
		_003CAddressCity_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႭ()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		return _003CAddressZip_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႥႠ(string P_0)
	{
		_003CAddressZip_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႠ()
	{
		string result = _003CAddressCountry_003Ek__BackingField;
		AnnCacheCfg.ႠႼ[52] = (byte)((AnnCacheCfg.ႠႼ[52] * AnnCacheCfg.ႠႼ[115]) & 0x32);
		return result;
	}

	[SpecialName]
	internal void ႥႥ(string P_0)
	{
		_003CAddressCountry_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႳ()
	{
		return _003CAddressAdif_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႥႨ(string P_0)
	{
		_003CAddressAdif_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႥ()
	{
		return _003CUsState_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႥႳ(string P_0)
	{
		_003CUsState_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႣ()
	{
		return _003CUsCounty_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႥႷ(string P_0)
	{
		_003CUsCounty_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႰ()
	{
		string result = _003CLotw_003Ek__BackingField;
		Arc4ServerClient.ႠႣ[417] = (char)((Arc4ServerClient.ႠႣ[417] ^ Arc4ServerClient.ႠႣ[328]) & 0x57);
		return result;
	}

	[SpecialName]
	internal void ႥႤ(string P_0)
	{
		_003CLotw_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႷ()
	{
		return _003CQsl_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႥႰ(string P_0)
	{
		_003CQsl_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႨ()
	{
		return _003CEqsl_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႥႭ(string P_0)
	{
		_003CEqsl_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႤ()
	{
		return _003CLatitude_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႥႣ(string P_0)
	{
		_003CLatitude_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႠႼ()
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		return _003CLongitude_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႥႼ(string P_0)
	{
		_003CLongitude_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႳႭ()
	{
		string result = _003CContinent_003Ek__BackingField;
		SetDxCountHelp.ႭႤ[68] = (SetDxCountHelp.ႭႤ[68] | SetDxCountHelp.ႭႤ[406]) & 0xA0;
		return result;
	}

	[SpecialName]
	internal void ႨႠ(string P_0)
	{
		_003CContinent_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႳႠ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		string result = _003CUtcOffset_003Ek__BackingField;
		IpLockoutCacheCfg.ႭႭ[346] = (char)(IpLockoutCacheCfg.ႭႭ[346] & IpLockoutCacheCfg.ႭႭ[89] & 0xD2);
		return result;
	}

	[SpecialName]
	internal void ႨႥ(string P_0)
	{
		_003CUtcOffset_003Ek__BackingField = P_0;
	}

	[SpecialName]
	internal string ႳႳ()
	{
		return _003CLookups_003Ek__BackingField;
	}

	[SpecialName]
	internal void ႨႨ(string P_0)
	{
		_003CLookups_003Ek__BackingField = P_0;
	}

	public HamQthDotComLookup()
	{
		Ⴀ(string.Empty);
		Ⴅ(string.Empty);
		Ⴈ(string.Empty);
		Ⴓ(string.Empty);
		Ⴗ(string.Empty);
		Ⴄ(string.Empty);
		Ⴐ(string.Empty);
		Ⴍ(string.Empty);
		Ⴃ(string.Empty);
		Ⴜ(string.Empty);
		ႥႠ(string.Empty);
		ႥႥ(string.Empty);
		ႥႨ(string.Empty);
		ႥႳ(string.Empty);
		ႥႷ(string.Empty);
		ႥႤ(string.Empty);
		ႥႰ(string.Empty);
		ႥႭ(string.Empty);
		ႥႣ(string.Empty);
		ႥႼ(string.Empty);
		ႨႠ(string.Empty);
		ႨႥ(string.Empty);
		ႨႨ(string.Empty);
	}
}
