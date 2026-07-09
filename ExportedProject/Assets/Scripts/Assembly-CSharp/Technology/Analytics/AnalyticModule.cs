using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E4C")]
	public class AnalyticModule
	{
		[Token(Token = "0x40043B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _flushQueued;

		[Token(Token = "0x40043B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IFlushPermissionProvider _flushPermissionProvider;

		[Token(Token = "0x40043B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFC94", Offset = "0x5BFC94")]
		private bool _003CIsInitialized_003Ek__BackingField;

		[Token(Token = "0x17000BD3")]
		public IFlushPermissionProvider FlushPermissionProvider
		{
			[Token(Token = "0x6005802")]
			[Address(RVA = "0xD5FFC8", Offset = "0xD5FFC8", VA = "0xD5FFC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005803")]
			[Address(RVA = "0xD5FFD0", Offset = "0xD5FFD0", VA = "0xD5FFD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000BD4")]
		public bool IsInitialized
		{
			[Token(Token = "0x6005804")]
			[Address(RVA = "0xD6019C", Offset = "0xD6019C", VA = "0xD6019C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B9E0", Offset = "0x62B9E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005805")]
			[Address(RVA = "0xD601A4", Offset = "0xD601A4", VA = "0xD601A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B9F0", Offset = "0x62B9F0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6005806")]
		[Address(RVA = "0xD601B0", Offset = "0xD601B0", VA = "0xD601B0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6005807")]
		[Address(RVA = "0xD601EC", Offset = "0xD601EC", VA = "0xD601EC")]
		public void SendEvent(EventKey eventKey, Dictionary<string, object> attributes)
		{
		}

		[Token(Token = "0x6005808")]
		[Address(RVA = "0xD601F8", Offset = "0xD601F8", VA = "0xD601F8")]
		public void Pause()
		{
		}

		[Token(Token = "0x6005809")]
		[Address(RVA = "0xD60204", Offset = "0xD60204", VA = "0xD60204")]
		public void Resume()
		{
		}

		[Token(Token = "0x600580A")]
		[Address(RVA = "0xD60210", Offset = "0xD60210", VA = "0xD60210")]
		public void Update()
		{
		}

		[Token(Token = "0x600580B")]
		[Address(RVA = "0xD6021C", Offset = "0xD6021C", VA = "0xD6021C")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600580C")]
		[Address(RVA = "0xD60388", Offset = "0xD60388", VA = "0xD60388")]
		public void Flush([Optional] Action<OSRequestState> response, bool isAsync = true)
		{
		}

		[Token(Token = "0x600580D")]
		[Address(RVA = "0xD6048C", Offset = "0xD6048C", VA = "0xD6048C")]
		public void ForceFlush(HashSet<string> eventNameFilter)
		{
		}

		[Token(Token = "0x600580E")]
		[Address(RVA = "0xD6049C", Offset = "0xD6049C", VA = "0xD6049C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600580F")]
		[Address(RVA = "0xD60504", Offset = "0xD60504", VA = "0xD60504", Slot = "4")]
		protected virtual bool OnInitialize()
		{
			return default(bool);
		}

		[Token(Token = "0x6005810")]
		[Address(RVA = "0xD6050C", Offset = "0xD6050C", VA = "0xD6050C", Slot = "5")]
		protected virtual bool OnReset()
		{
			return default(bool);
		}

		[Token(Token = "0x6005811")]
		[Address(RVA = "0xD60514", Offset = "0xD60514", VA = "0xD60514", Slot = "6")]
		protected virtual void OnSendEvent(EventKey eventKey, Dictionary<string, object> attributes)
		{
		}

		[Token(Token = "0x6005812")]
		[Address(RVA = "0xD60518", Offset = "0xD60518", VA = "0xD60518", Slot = "7")]
		protected virtual void OnPause()
		{
		}

		[Token(Token = "0x6005813")]
		[Address(RVA = "0xD6051C", Offset = "0xD6051C", VA = "0xD6051C", Slot = "8")]
		protected virtual void OnResume()
		{
		}

		[Token(Token = "0x6005814")]
		[Address(RVA = "0xD60520", Offset = "0xD60520", VA = "0xD60520", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6005815")]
		[Address(RVA = "0xD60580", Offset = "0xD60580", VA = "0xD60580", Slot = "10")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x6005816")]
		[Address(RVA = "0xD60584", Offset = "0xD60584", VA = "0xD60584", Slot = "11")]
		protected virtual void OnFlush(Action<OSRequestState> response, bool isAsync)
		{
		}

		[Token(Token = "0x6005817")]
		[Address(RVA = "0xD60588", Offset = "0xD60588", VA = "0xD60588", Slot = "12")]
		protected virtual void OnCannotFlush(Action<OSRequestState> response)
		{
		}

		[Token(Token = "0x6005818")]
		[Address(RVA = "0xD6058C", Offset = "0xD6058C", VA = "0xD6058C", Slot = "13")]
		protected virtual void OnForceFlush(HashSet<string> eventNameFilter)
		{
		}

		[Token(Token = "0x6005819")]
		[Address(RVA = "0xD60590", Offset = "0xD60590", VA = "0xD60590")]
		private void OnCanFlushStateChanged(bool canFlush)
		{
		}

		[Token(Token = "0x600581A")]
		[Address(RVA = "0xD605AC", Offset = "0xD605AC", VA = "0xD605AC")]
		public AnalyticModule()
		{
		}
	}
}
