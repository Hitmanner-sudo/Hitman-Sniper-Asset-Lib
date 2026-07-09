using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.ServiceOperations;

namespace Technology.Shop
{
	[Token(Token = "0x2000B3C")]
	public class Transaction
	{
		[Token(Token = "0x2000B3D")]
		internal enum State
		{
			[Token(Token = "0x4003949")]
			InProgress = 0,
			[Token(Token = "0x400394A")]
			Success = 1,
			[Token(Token = "0x400394B")]
			Failure = 2,
			[Token(Token = "0x400394C")]
			Deferred = 3
		}

		[Token(Token = "0x2000B3E")]
		public enum TransactionSecurityStatus
		{
			[Token(Token = "0x400394E")]
			Unknown = 0,
			[Token(Token = "0x400394F")]
			PendingVerification = 1,
			[Token(Token = "0x4003950")]
			Verified = 2,
			[Token(Token = "0x4003951")]
			UnableToValidate = 3,
			[Token(Token = "0x4003952")]
			Invalid = 4
		}

		[Token(Token = "0x2000B3F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5980A0", Offset = "0x5980A0")]
		private sealed class _003C_003Ec__DisplayClass46_0
		{
			[Token(Token = "0x4003953")]
			[FieldOffset(Offset = "0x10")]
			public SvcOpGooglePlay_ValidateTransaction svcOp;

			[Token(Token = "0x4003954")]
			[FieldOffset(Offset = "0x18")]
			public Transaction _003C_003E4__this;

			[Token(Token = "0x600471B")]
			[Address(RVA = "0xA37F34", Offset = "0xA37F34", VA = "0xA37F34")]
			public _003C_003Ec__DisplayClass46_0()
			{
			}

			[Token(Token = "0x600471C")]
			[Address(RVA = "0xA37F3C", Offset = "0xA37F3C", VA = "0xA37F3C")]
			internal void _003CValidate_003Eb__0()
			{
			}
		}

		[Token(Token = "0x400393F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Transaction ErrorTransaction;

		[Token(Token = "0x4003940")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCFDC", Offset = "0x5BCFDC")]
		private string _003CFirstPartyTransactionId_003Ek__BackingField;

		[Token(Token = "0x4003941")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCFEC", Offset = "0x5BCFEC")]
		private string _003CFirstPartyReceiptData_003Ek__BackingField;

		[Token(Token = "0x4003942")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BCFFC", Offset = "0x5BCFFC")]
		private TransactionSecurityStatus _003CSecurityStatus_003Ek__BackingField;

		[Token(Token = "0x4003943")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD00C", Offset = "0x5BD00C")]
		private string _003CErrorMessage_003Ek__BackingField;

		[Token(Token = "0x4003944")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD01C", Offset = "0x5BD01C")]
		private Offer _003COffer_003Ek__BackingField;

		[Token(Token = "0x4003945")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD02C", Offset = "0x5BD02C")]
		private State _003CTransactionState_003Ek__BackingField;

		[Token(Token = "0x4003946")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD03C", Offset = "0x5BD03C")]
		private long _003CTimeStamp_003Ek__BackingField;

		[Token(Token = "0x4003947")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD04C", Offset = "0x5BD04C")]
		private bool _003CIsRestore_003Ek__BackingField;

		[Token(Token = "0x170008F8")]
		internal string FirstPartyTransactionId
		{
			[Token(Token = "0x60046F8")]
			[Address(RVA = "0xAD91F0", Offset = "0xAD91F0", VA = "0xAD91F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D18", Offset = "0x626D18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046F9")]
			[Address(RVA = "0xAD91F8", Offset = "0xAD91F8", VA = "0xAD91F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D28", Offset = "0x626D28")]
			set
			{
			}
		}

		[Token(Token = "0x170008F9")]
		internal string FirstPartyReceiptData
		{
			[Token(Token = "0x60046FA")]
			[Address(RVA = "0xAD9200", Offset = "0xAD9200", VA = "0xAD9200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D38", Offset = "0x626D38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046FB")]
			[Address(RVA = "0xAD9208", Offset = "0xAD9208", VA = "0xAD9208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D48", Offset = "0x626D48")]
			set
			{
			}
		}

		[Token(Token = "0x170008FA")]
		internal TransactionSecurityStatus SecurityStatus
		{
			[Token(Token = "0x60046FC")]
			[Address(RVA = "0xAD9210", Offset = "0xAD9210", VA = "0xAD9210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D58", Offset = "0x626D58")]
			get
			{
				return default(TransactionSecurityStatus);
			}
			[Token(Token = "0x60046FD")]
			[Address(RVA = "0xAD9218", Offset = "0xAD9218", VA = "0xAD9218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D68", Offset = "0x626D68")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FB")]
		internal string ErrorMessage
		{
			[Token(Token = "0x60046FE")]
			[Address(RVA = "0xAD9220", Offset = "0xAD9220", VA = "0xAD9220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D78", Offset = "0x626D78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046FF")]
			[Address(RVA = "0xAD9228", Offset = "0xAD9228", VA = "0xAD9228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D88", Offset = "0x626D88")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FC")]
		internal Offer Offer
		{
			[Token(Token = "0x6004700")]
			[Address(RVA = "0xAD9230", Offset = "0xAD9230", VA = "0xAD9230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D98", Offset = "0x626D98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004701")]
			[Address(RVA = "0xAD9238", Offset = "0xAD9238", VA = "0xAD9238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626DA8", Offset = "0x626DA8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FD")]
		internal State TransactionState
		{
			[Token(Token = "0x6004702")]
			[Address(RVA = "0xAD9240", Offset = "0xAD9240", VA = "0xAD9240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626DB8", Offset = "0x626DB8")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6004703")]
			[Address(RVA = "0xAD9248", Offset = "0xAD9248", VA = "0xAD9248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626DC8", Offset = "0x626DC8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FE")]
		internal long TimeStamp
		{
			[Token(Token = "0x6004704")]
			[Address(RVA = "0xAD9250", Offset = "0xAD9250", VA = "0xAD9250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626DD8", Offset = "0x626DD8")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004705")]
			[Address(RVA = "0xAD9258", Offset = "0xAD9258", VA = "0xAD9258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626DE8", Offset = "0x626DE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170008FF")]
		internal bool IsRestore
		{
			[Token(Token = "0x6004706")]
			[Address(RVA = "0xAD9260", Offset = "0xAD9260", VA = "0xAD9260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626DF8", Offset = "0x626DF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004707")]
			[Address(RVA = "0xAD9268", Offset = "0xAD9268", VA = "0xAD9268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626E08", Offset = "0x626E08")]
			set
			{
			}
		}

		[Token(Token = "0x140000E7")]
		internal event EventHandler<TransactionValidateEvent> OnReceiptValidationComplete
		{
			[Token(Token = "0x60046F5")]
			[Address(RVA = "0xAD9028", Offset = "0xAD9028", VA = "0xAD9028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626CF8", Offset = "0x626CF8")]
			add
			{
			}
			[Token(Token = "0x60046F6")]
			[Address(RVA = "0xAD90C8", Offset = "0xAD90C8", VA = "0xAD90C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626D08", Offset = "0x626D08")]
			remove
			{
			}
		}

		[Token(Token = "0x60046F7")]
		[Address(RVA = "0xAD9168", Offset = "0xAD9168", VA = "0xAD9168")]
		internal static bool IsNullOrError(Transaction transaction)
		{
			return default(bool);
		}

		[Token(Token = "0x6004708")]
		[Address(RVA = "0xAD9274", Offset = "0xAD9274", VA = "0xAD9274")]
		private Transaction(State state)
		{
		}

		[Token(Token = "0x6004709")]
		[Address(RVA = "0xAD93E8", Offset = "0xAD93E8", VA = "0xAD93E8")]
		internal Transaction(Offer offer)
		{
		}

		[Token(Token = "0x600470A")]
		[Address(RVA = "0xAD94B4", Offset = "0xAD94B4", VA = "0xAD94B4")]
		public Transaction()
		{
		}

		[Token(Token = "0x600470B")]
		[Address(RVA = "0xAD9544", Offset = "0xAD9544", VA = "0xAD9544")]
		internal Transaction Start(Action<Transaction> startingAction)
		{
			return null;
		}

		[Token(Token = "0x600470C")]
		[Address(RVA = "0xAD9340", Offset = "0xAD9340", VA = "0xAD9340")]
		internal void SetTransactionState(State state)
		{
		}

		[Token(Token = "0x600470D")]
		[Address(RVA = "0xAD95FC", Offset = "0xAD95FC", VA = "0xAD95FC")]
		internal void SetSecurityState(TransactionSecurityStatus state)
		{
		}

		[Token(Token = "0x600470E")]
		[Address(RVA = "0xAD9688", Offset = "0xAD9688", VA = "0xAD9688")]
		internal void SetErrorMessage(string errorMessage)
		{
		}

		[Token(Token = "0x600470F")]
		[Address(RVA = "0xAD9714", Offset = "0xAD9714", VA = "0xAD9714")]
		internal void Validate()
		{
		}

		[Token(Token = "0x6004710")]
		[Address(RVA = "0xAD9980", Offset = "0xAD9980", VA = "0xAD9980")]
		private void HandleAppleReceiptValidationResult(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> additionalRequestMeta)
		{
		}

		[Token(Token = "0x6004711")]
		[Address(RVA = "0xAD9CFC", Offset = "0xAD9CFC", VA = "0xAD9CFC")]
		private void HandleGoogleReceiptValidationResult(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> additionalRequestMeta)
		{
		}

		[Token(Token = "0x6004712")]
		[Address(RVA = "0xAD9D60", Offset = "0xAD9D60", VA = "0xAD9D60")]
		private string ValidateAppleReceiptResult(JSONNode inputNode)
		{
			return null;
		}

		[Token(Token = "0x6004713")]
		[Address(RVA = "0xAD9F6C", Offset = "0xAD9F6C", VA = "0xAD9F6C")]
		private string ValidateGeneralReceiptResult(string root, JSONNode inputNode)
		{
			return null;
		}

		[Token(Token = "0x6004714")]
		[Address(RVA = "0xAD99E4", Offset = "0xAD99E4", VA = "0xAD99E4")]
		private void HandleReceiptValidationResult(IResponseContext response, OSRequestState state, string jsonRootNode)
		{
		}

		[Token(Token = "0x6004715")]
		[Address(RVA = "0xADA0D8", Offset = "0xADA0D8", VA = "0xADA0D8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6004716")]
		[Address(RVA = "0xADA1F0", Offset = "0xADA1F0", VA = "0xADA1F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6004717")]
		[Address(RVA = "0xADA1F8", Offset = "0xADA1F8", VA = "0xADA1F8")]
		public void Serialize()
		{
		}

		[Token(Token = "0x6004718")]
		[Address(RVA = "0xADA350", Offset = "0xADA350", VA = "0xADA350")]
		public static Transaction Deserialize(string id, OfferController offerController)
		{
			return null;
		}

		[Token(Token = "0x6004719")]
		[Address(RVA = "0xADA4FC", Offset = "0xADA4FC", VA = "0xADA4FC")]
		public string Print()
		{
			return null;
		}
	}
}
