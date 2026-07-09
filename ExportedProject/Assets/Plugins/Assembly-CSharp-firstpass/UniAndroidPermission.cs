using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000011")]
public class UniAndroidPermission : MonoBehaviour
{
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F8E88", Offset = "0x6F8E88")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x20")]
		public string buttonText;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x18BCC78", Offset = "0x18BCC78", VA = "0x18BCC78")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x18C1110", Offset = "0x18C1110", VA = "0x18C1110")]
		internal void _003CShowAlertPopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x18")]
	public List<CustomLocalization> RequestPermissionLoc;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x20")]
	public List<CustomLocalization> NeedPermissionLoc;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x28")]
	public List<CustomLocalization> QualityRestartLoc;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x0")]
	public static UniAndroidPermission Instance;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x8")]
	private static Action _permitCallBack;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x10")]
	private static Action _notPermitCallBack;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x18")]
	private static Action _showAlertClicked;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x20")]
	private static Action _onGoToSettingsDoneCallBack;

	[Token(Token = "0x400007A")]
	private const string PACKAGE_CLASS_NAME = "com.squareenixmontreal.armory.PermissionManager";

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x18BC500", Offset = "0x18BC500", VA = "0x18BC500")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x18BC5B0", Offset = "0x18BC5B0", VA = "0x18BC5B0")]
	public static bool HasPermission(AndroidPermission permission)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x18BC7B0", Offset = "0x18BC7B0", VA = "0x18BC7B0")]
	public static void RequestPermission(AndroidPermission permission, Action onPermit, Action notPermit)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x18BC90C", Offset = "0x18BC90C", VA = "0x18BC90C")]
	public static bool ShouldShowRequestPermissionRationale(AndroidPermission permission)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x18BCA64", Offset = "0x18BCA64", VA = "0x18BCA64")]
	public static void ShowAlertPopup(string title, string message, string buttonText, Action showAlertClicked)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x18BCC80", Offset = "0x18BCC80", VA = "0x18BCC80")]
	public static void OpenApplicationSettings(Action onGoToSettingsDoneCallBack)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x18BC708", Offset = "0x18BC708", VA = "0x18BC708")]
	private static string GetPermittionStr(AndroidPermission permittion)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x18BCDF0", Offset = "0x18BCDF0", VA = "0x18BCDF0")]
	private void OnRequestPermissions(string message)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x18BCFB8", Offset = "0x18BCFB8", VA = "0x18BCFB8")]
	private void ShowAlertClicked()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x18BD078", Offset = "0x18BD078", VA = "0x18BD078")]
	private void OnGoToSettingsDone()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x18BD138", Offset = "0x18BD138", VA = "0x18BD138")]
	public static CustomLocalization GetLocalizationStrings(List<CustomLocalization> localizationList)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x18BD264", Offset = "0x18BD264", VA = "0x18BD264")]
	public UniAndroidPermission()
	{
	}
}
