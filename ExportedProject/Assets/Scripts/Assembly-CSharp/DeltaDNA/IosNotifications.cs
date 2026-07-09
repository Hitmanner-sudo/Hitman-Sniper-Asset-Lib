using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x200132F")]
	public class IosNotifications : MonoBehaviour
	{
		[Token(Token = "0x140001A6")]
		public event Action<string> OnDidLaunchWithPushNotification
		{
			[Token(Token = "0x60070F5")]
			[Address(RVA = "0x10BD760", Offset = "0x10BD760", VA = "0x10BD760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D640", Offset = "0x62D640")]
			add
			{
			}
			[Token(Token = "0x60070F6")]
			[Address(RVA = "0x10BD800", Offset = "0x10BD800", VA = "0x10BD800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D650", Offset = "0x62D650")]
			remove
			{
			}
		}

		[Token(Token = "0x140001A7")]
		public event Action<string> OnDidReceivePushNotification
		{
			[Token(Token = "0x60070F7")]
			[Address(RVA = "0x10BD8A0", Offset = "0x10BD8A0", VA = "0x10BD8A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D660", Offset = "0x62D660")]
			add
			{
			}
			[Token(Token = "0x60070F8")]
			[Address(RVA = "0x10BD940", Offset = "0x10BD940", VA = "0x10BD940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D670", Offset = "0x62D670")]
			remove
			{
			}
		}

		[Token(Token = "0x140001A8")]
		public event Action<string> OnDidRegisterForPushNotifications
		{
			[Token(Token = "0x60070F9")]
			[Address(RVA = "0x10BD9E0", Offset = "0x10BD9E0", VA = "0x10BD9E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D680", Offset = "0x62D680")]
			add
			{
			}
			[Token(Token = "0x60070FA")]
			[Address(RVA = "0x10BDA80", Offset = "0x10BDA80", VA = "0x10BDA80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D690", Offset = "0x62D690")]
			remove
			{
			}
		}

		[Token(Token = "0x140001A9")]
		public event Action<string> OnDidFailToRegisterForPushNotifications
		{
			[Token(Token = "0x60070FB")]
			[Address(RVA = "0x10BDB20", Offset = "0x10BDB20", VA = "0x10BDB20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D6A0", Offset = "0x62D6A0")]
			add
			{
			}
			[Token(Token = "0x60070FC")]
			[Address(RVA = "0x10BDBC0", Offset = "0x10BDBC0", VA = "0x10BDBC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62D6B0", Offset = "0x62D6B0")]
			remove
			{
			}
		}

		[Token(Token = "0x60070FD")]
		[Address(RVA = "0x10BDC60", Offset = "0x10BDC60", VA = "0x10BDC60")]
		private void Awake()
		{
		}

		[Token(Token = "0x60070FE")]
		[Address(RVA = "0x10BDD08", Offset = "0x10BDD08", VA = "0x10BDD08")]
		public void RegisterForPushNotifications()
		{
		}

		[Token(Token = "0x60070FF")]
		[Address(RVA = "0x10BDD10", Offset = "0x10BDD10", VA = "0x10BDD10")]
		public void UnregisterForPushNotifications()
		{
		}

		[Token(Token = "0x6007100")]
		[Address(RVA = "0x10BDD18", Offset = "0x10BDD18", VA = "0x10BDD18")]
		public void DidReceivePushNotification(string notification)
		{
		}

		[Token(Token = "0x6007101")]
		[Address(RVA = "0x10BDFD0", Offset = "0x10BDFD0", VA = "0x10BDFD0")]
		public void DidRegisterForPushNotifications(string deviceToken)
		{
		}

		[Token(Token = "0x6007102")]
		[Address(RVA = "0x10BE100", Offset = "0x10BE100", VA = "0x10BE100")]
		public void DidFailToRegisterForPushNotifications(string error)
		{
		}

		[Token(Token = "0x6007103")]
		[Address(RVA = "0x10BE1D4", Offset = "0x10BE1D4", VA = "0x10BE1D4")]
		public IosNotifications()
		{
		}
	}
}
