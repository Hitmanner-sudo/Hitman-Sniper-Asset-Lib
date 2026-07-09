using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000726")]
public class PopupDDNAMessage : PopupOverlayView
{
	[Token(Token = "0x2000727")]
	public struct OkButtonText
	{
		[Token(Token = "0x4002871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string DefaultText;

		[Token(Token = "0x4002872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string StrikethroughText;

		[Token(Token = "0x4002873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string SaleText;
	}

	[Token(Token = "0x2000728")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595EC8", Offset = "0x595EC8")]
	private sealed class _003CLoadImageCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x4002877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x4002878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<string> callback;

		[Token(Token = "0x4002879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WWW _003Cwww_003E5__2;

		[Token(Token = "0x17000626")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002FB8")]
			[Address(RVA = "0x8AE918", Offset = "0x8AE918", VA = "0x8AE918", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000627")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002FBA")]
			[Address(RVA = "0x8AE960", Offset = "0x8AE960", VA = "0x8AE960", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x8AE740", Offset = "0x8AE740", VA = "0x8AE740")]
		[DebuggerHidden]
		public _003CLoadImageCoroutine_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x8AE76C", Offset = "0x8AE76C", VA = "0x8AE76C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x8AE770", Offset = "0x8AE770", VA = "0x8AE770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x8AE920", Offset = "0x8AE920", VA = "0x8AE920", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400286C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	private GameObject _okButtonDefault;

	[Token(Token = "0x400286D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private UILabel _okLabelDefault;

	[Token(Token = "0x400286E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	private GameObject _okButtonSale;

	[Token(Token = "0x400286F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private UILabel _okLabelStrikethrough;

	[Token(Token = "0x4002870")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private UILabel _okLabelSale;

	[Token(Token = "0x6002FAD")]
	[Address(RVA = "0x930A6C", Offset = "0x930A6C", VA = "0x930A6C")]
	public void ShowPopup()
	{
	}

	[Token(Token = "0x6002FAE")]
	[Address(RVA = "0x930B84", Offset = "0x930B84", VA = "0x930B84")]
	public void MessageSetupPopupOverlay(string title, string message, Action okCallback, OkButtonText okText, [Optional] Action cancelCallback, bool showDismiss = false)
	{
	}

	[Token(Token = "0x6002FAF")]
	[Address(RVA = "0x930D74", Offset = "0x930D74", VA = "0x930D74")]
	public void ImageSetupPopupOverlay(string title, string message, Action okCallback, OkButtonText okText, Action cancelCallback, bool showCancel, Texture texture, int width, int height)
	{
	}

	[Token(Token = "0x6002FB0")]
	[Address(RVA = "0x931200", Offset = "0x931200", VA = "0x931200")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6218C0", Offset = "0x6218C0")]
	public static IEnumerator LoadImageCoroutine(string url, Texture2D texture, Action<string> callback)
	{
		return null;
	}

	[Token(Token = "0x6002FB1")]
	[Address(RVA = "0x931280", Offset = "0x931280", VA = "0x931280", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002FB2")]
	[Address(RVA = "0x930CB8", Offset = "0x930CB8", VA = "0x930CB8")]
	private void SetupOkButton(OkButtonText okText)
	{
	}

	[Token(Token = "0x6002FB3")]
	[Address(RVA = "0x93142C", Offset = "0x93142C", VA = "0x93142C")]
	public PopupDDNAMessage()
	{
	}

	[Token(Token = "0x6002FB4")]
	[Address(RVA = "0x931430", Offset = "0x931430", VA = "0x931430")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621920", Offset = "0x621920")]
	private void _003CShowPopup_003Eb__6_0()
	{
	}
}
