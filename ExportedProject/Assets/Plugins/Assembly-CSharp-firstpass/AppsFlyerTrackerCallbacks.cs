using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000006")]
public class AppsFlyerTrackerCallbacks : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	public class ConversionDataEventArgs : EventArgs
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9198", Offset = "0x6F9198")]
		private string _003CConversionData_003Ek__BackingField;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F91A8", Offset = "0x6F91A8")]
		private string _003CError_003Ek__BackingField;

		[Token(Token = "0x17000001")]
		public string ConversionData
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x18BEEB8", Offset = "0x18BEEB8", VA = "0x18BEEB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9950", Offset = "0x6F9950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x18BEEC0", Offset = "0x18BEEC0", VA = "0x18BEEC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9960", Offset = "0x6F9960")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string Error
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x18BEEC8", Offset = "0x18BEEC8", VA = "0x18BEEC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9970", Offset = "0x6F9970")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x18BEED0", Offset = "0x18BEED0", VA = "0x18BEED0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9980", Offset = "0x6F9980")]
			private set
			{
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x18BEED8", Offset = "0x18BEED8", VA = "0x18BEED8")]
		internal ConversionDataEventArgs(string conversionData, string error)
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event EventHandler<ConversionDataEventArgs> OnDidReceiveConversionData
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x10DB4A8", Offset = "0x10DB4A8", VA = "0x10DB4A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9910", Offset = "0x6F9910")]
		add
		{
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x10DB548", Offset = "0x10DB548", VA = "0x10DB548")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9920", Offset = "0x6F9920")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventHandler<ConversionDataEventArgs> OnAppOpenAttribution
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x10DB5E8", Offset = "0x10DB5E8", VA = "0x10DB5E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9930", Offset = "0x6F9930")]
		add
		{
		}
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x10DB688", Offset = "0x10DB688", VA = "0x10DB688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9940", Offset = "0x6F9940")]
		remove
		{
		}
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x10DB728", Offset = "0x10DB728", VA = "0x10DB728")]
	public void didReceiveConversionData(string conversionData)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x10DB7D0", Offset = "0x10DB7D0", VA = "0x10DB7D0")]
	public void didReceiveConversionDataWithError(string error)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x10DB878", Offset = "0x10DB878", VA = "0x10DB878")]
	public void didFinishValidateReceipt(string validateResult)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x10DB8D0", Offset = "0x10DB8D0", VA = "0x10DB8D0")]
	public void didFinishValidateReceiptWithError(string error)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x10DB928", Offset = "0x10DB928", VA = "0x10DB928")]
	public void onAppOpenAttribution(string validateResult)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x10DB9D0", Offset = "0x10DB9D0", VA = "0x10DB9D0")]
	public void onAppOpenAttributionFailure(string error)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x10DBA78", Offset = "0x10DBA78", VA = "0x10DBA78")]
	public void onInAppBillingSuccess()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x10DBAC0", Offset = "0x10DBAC0", VA = "0x10DBAC0")]
	public void onInAppBillingFailure(string error)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x10DBB18", Offset = "0x10DBB18", VA = "0x10DBB18")]
	public AppsFlyerTrackerCallbacks()
	{
	}
}
