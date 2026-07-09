using System;
using DeltaDNA.Android;
using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x200132E")]
	public class AndroidNotifications : MonoBehaviour
	{
		[Token(Token = "0x4005C08")]
		[FieldOffset(Offset = "0x18")]
		private DDNANotifications ddnaNotifications;

		[Token(Token = "0x4005C0D")]
		[FieldOffset(Offset = "0x40")]
		private bool? notificationsPresent;

		[Token(Token = "0x140001A2")]
		public event Action<string> OnDidLaunchWithPushNotification
		{
			[Token(Token = "0x60070E5")]
			[Address(RVA = "0xD73300", Offset = "0xD73300", VA = "0xD73300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D5C0", Offset = "0x62D5C0")]
			add
			{
			}
			[Token(Token = "0x60070E6")]
			[Address(RVA = "0xD733A0", Offset = "0xD733A0", VA = "0xD733A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D5D0", Offset = "0x62D5D0")]
			remove
			{
			}
		}

		[Token(Token = "0x140001A3")]
		public event Action<string> OnDidReceivePushNotification
		{
			[Token(Token = "0x60070E7")]
			[Address(RVA = "0xD73440", Offset = "0xD73440", VA = "0xD73440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D5E0", Offset = "0x62D5E0")]
			add
			{
			}
			[Token(Token = "0x60070E8")]
			[Address(RVA = "0xD734E0", Offset = "0xD734E0", VA = "0xD734E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D5F0", Offset = "0x62D5F0")]
			remove
			{
			}
		}

		[Token(Token = "0x140001A4")]
		public event Action<string> OnDidRegisterForPushNotifications
		{
			[Token(Token = "0x60070E9")]
			[Address(RVA = "0xD73580", Offset = "0xD73580", VA = "0xD73580")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D600", Offset = "0x62D600")]
			add
			{
			}
			[Token(Token = "0x60070EA")]
			[Address(RVA = "0xD73620", Offset = "0xD73620", VA = "0xD73620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D610", Offset = "0x62D610")]
			remove
			{
			}
		}

		[Token(Token = "0x140001A5")]
		public event Action<string> OnDidFailToRegisterForPushNotifications
		{
			[Token(Token = "0x60070EB")]
			[Address(RVA = "0xD736C0", Offset = "0xD736C0", VA = "0xD736C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D620", Offset = "0x62D620")]
			add
			{
			}
			[Token(Token = "0x60070EC")]
			[Address(RVA = "0xD73760", Offset = "0xD73760", VA = "0xD73760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D630", Offset = "0x62D630")]
			remove
			{
			}
		}

		[Token(Token = "0x60070ED")]
		[Address(RVA = "0xD73800", Offset = "0xD73800", VA = "0xD73800")]
		private void Awake()
		{
		}

		[Token(Token = "0x60070EE")]
		[Address(RVA = "0xD73A74", Offset = "0xD73A74", VA = "0xD73A74")]
		public void RegisterForPushNotifications(bool secondary = false)
		{
		}

		[Token(Token = "0x60070EF")]
		[Address(RVA = "0xD73C6C", Offset = "0xD73C6C", VA = "0xD73C6C")]
		public void UnregisterForPushNotifications()
		{
		}

		[Token(Token = "0x60070F0")]
		[Address(RVA = "0xD738FC", Offset = "0xD738FC", VA = "0xD738FC")]
		private bool AreNotificationsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x60070F1")]
		[Address(RVA = "0xD73D1C", Offset = "0xD73D1C", VA = "0xD73D1C")]
		public void DidReceivePushNotification(string notification)
		{
		}

		[Token(Token = "0x60070F2")]
		[Address(RVA = "0xD73FF8", Offset = "0xD73FF8", VA = "0xD73FF8")]
		public void DidRegisterForPushNotifications(string registrationId)
		{
		}

		[Token(Token = "0x60070F3")]
		[Address(RVA = "0xD74128", Offset = "0xD74128", VA = "0xD74128")]
		public void DidFailToRegisterForPushNotifications(string error)
		{
		}

		[Token(Token = "0x60070F4")]
		[Address(RVA = "0xD741FC", Offset = "0xD741FC", VA = "0xD741FC")]
		public AndroidNotifications()
		{
		}
	}
}
