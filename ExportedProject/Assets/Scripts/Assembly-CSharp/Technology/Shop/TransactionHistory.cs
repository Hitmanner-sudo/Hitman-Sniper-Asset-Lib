using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Technology.Shop
{
	[Token(Token = "0x2000B41")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x5980E8", Offset = "0x5980E8")]
	public class TransactionHistory
	{
		[Token(Token = "0x2000B42")]
		internal class TransactionHistoryEntry
		{
			[Token(Token = "0x4003958")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD06C", Offset = "0x5BD06C")]
			private string _003CId_003Ek__BackingField;

			[Token(Token = "0x4003959")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD07C", Offset = "0x5BD07C")]
			private Transaction _003CTransaction_003Ek__BackingField;

			[Token(Token = "0x400395A")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD08C", Offset = "0x5BD08C")]
			private long _003CDatetimestamp_003Ek__BackingField;

			[Token(Token = "0x17000906")]
			internal string Id
			{
				[Token(Token = "0x600472D")]
				[Address(RVA = "0xA382E8", Offset = "0xA382E8", VA = "0xA382E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626E98", Offset = "0x626E98")]
				get
				{
					return null;
				}
				[Token(Token = "0x600472E")]
				[Address(RVA = "0xA382F0", Offset = "0xA382F0", VA = "0xA382F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626EA8", Offset = "0x626EA8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000907")]
			internal Transaction Transaction
			{
				[Token(Token = "0x600472F")]
				[Address(RVA = "0xA382F8", Offset = "0xA382F8", VA = "0xA382F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626EB8", Offset = "0x626EB8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004730")]
				[Address(RVA = "0xA38300", Offset = "0xA38300", VA = "0xA38300")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626EC8", Offset = "0x626EC8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000908")]
			internal long Datetimestamp
			{
				[Token(Token = "0x6004731")]
				[Address(RVA = "0xA38308", Offset = "0xA38308", VA = "0xA38308")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626ED8", Offset = "0x626ED8")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6004732")]
				[Address(RVA = "0xA38310", Offset = "0xA38310", VA = "0xA38310")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626EE8", Offset = "0x626EE8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000909")]
			private string FirstPartyTransactionIdSerializationKey
			{
				[Token(Token = "0x6004737")]
				[Address(RVA = "0xA38744", Offset = "0xA38744", VA = "0xA38744")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700090A")]
			private string FirstPartyReceiptDataSerializationKey
			{
				[Token(Token = "0x6004738")]
				[Address(RVA = "0xA387DC", Offset = "0xA387DC", VA = "0xA387DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700090B")]
			private string TransactionStateSerializationKey
			{
				[Token(Token = "0x6004739")]
				[Address(RVA = "0xA38874", Offset = "0xA38874", VA = "0xA38874")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700090C")]
			private string TimestampSerializationKey
			{
				[Token(Token = "0x600473A")]
				[Address(RVA = "0xA3890C", Offset = "0xA3890C", VA = "0xA3890C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6004733")]
			[Address(RVA = "0xA38318", Offset = "0xA38318", VA = "0xA38318")]
			internal TransactionHistoryEntry(string id)
			{
			}

			[Token(Token = "0x6004734")]
			[Address(RVA = "0xA38508", Offset = "0xA38508", VA = "0xA38508")]
			internal TransactionHistoryEntry(Transaction transaction)
			{
			}

			[Token(Token = "0x6004735")]
			[Address(RVA = "0xA385F0", Offset = "0xA385F0", VA = "0xA385F0")]
			public void Serialize()
			{
			}

			[Token(Token = "0x6004736")]
			[Address(RVA = "0xA38394", Offset = "0xA38394", VA = "0xA38394")]
			public void Deserialize()
			{
			}
		}

		[Token(Token = "0x2000B43")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598120", Offset = "0x598120")]
		private sealed class _003CGetTransactionEntries_003Ed__11 : IEnumerable<KeyValuePair<string, TransactionHistoryEntry>>, IEnumerable, IEnumerator<KeyValuePair<string, TransactionHistoryEntry>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400395B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400395C")]
			[FieldOffset(Offset = "0x18")]
			private KeyValuePair<string, TransactionHistoryEntry> _003C_003E2__current;

			[Token(Token = "0x400395D")]
			[FieldOffset(Offset = "0x28")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x400395E")]
			[FieldOffset(Offset = "0x30")]
			public TransactionHistory _003C_003E4__this;

			[Token(Token = "0x400395F")]
			[FieldOffset(Offset = "0x38")]
			private Dictionary<string, TransactionHistoryEntry>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x1700090D")]
			private KeyValuePair<string, TransactionHistoryEntry> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CTechnology_002EShop_002ETransactionHistory_002ETransactionHistoryEntry_003E_003E_002ECurrent
			{
				[Token(Token = "0x600473F")]
				[Address(RVA = "0xA38190", Offset = "0xA38190", VA = "0xA38190", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, TransactionHistoryEntry>);
				}
			}

			[Token(Token = "0x1700090E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004741")]
				[Address(RVA = "0xA381DC", Offset = "0xA381DC", VA = "0xA381DC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600473B")]
			[Address(RVA = "0xA37F68", Offset = "0xA37F68", VA = "0xA37F68")]
			[DebuggerHidden]
			public _003CGetTransactionEntries_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600473C")]
			[Address(RVA = "0xA37FA0", Offset = "0xA37FA0", VA = "0xA37FA0", Slot = "7")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600473D")]
			[Address(RVA = "0xA38010", Offset = "0xA38010", VA = "0xA38010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600473E")]
			[Address(RVA = "0xA37FBC", Offset = "0xA37FBC", VA = "0xA37FBC")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6004740")]
			[Address(RVA = "0xA3819C", Offset = "0xA3819C", VA = "0xA3819C", Slot = "10")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004742")]
			[Address(RVA = "0xA3823C", Offset = "0xA3823C", VA = "0xA3823C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, TransactionHistoryEntry>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CTechnology_002EShop_002ETransactionHistory_002ETransactionHistoryEntry_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6004743")]
			[Address(RVA = "0xA382E4", Offset = "0xA382E4", VA = "0xA382E4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4003956")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, TransactionHistoryEntry> _history;

		[Token(Token = "0x4003957")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD05C", Offset = "0x5BD05C")]
		private Transaction _003CLast_003Ek__BackingField;

		[Token(Token = "0x17000903")]
		public Transaction Last
		{
			[Token(Token = "0x6004724")]
			[Address(RVA = "0xC96A14", Offset = "0xC96A14", VA = "0xC96A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626E18", Offset = "0x626E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004725")]
			[Address(RVA = "0xC96A1C", Offset = "0xC96A1C", VA = "0xC96A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x626E28", Offset = "0x626E28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000904")]
		internal int Count
		{
			[Token(Token = "0x6004726")]
			[Address(RVA = "0xC96A24", Offset = "0xC96A24", VA = "0xC96A24")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000905")]
		internal TransactionHistoryEntry Item
		{
			[Token(Token = "0x600472C")]
			[Address(RVA = "0xC96F84", Offset = "0xC96F84", VA = "0xC96F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004727")]
		[Address(RVA = "0xC96A78", Offset = "0xC96A78", VA = "0xC96A78")]
		internal TransactionHistory()
		{
		}

		[Token(Token = "0x6004728")]
		[Address(RVA = "0xC96B30", Offset = "0xC96B30", VA = "0xC96B30")]
		internal void Add(Transaction transaction)
		{
		}

		[Token(Token = "0x6004729")]
		[Address(RVA = "0xC96C4C", Offset = "0xC96C4C", VA = "0xC96C4C")]
		internal bool Contains(Transaction transaction)
		{
			return default(bool);
		}

		[Token(Token = "0x600472A")]
		[Address(RVA = "0xC96DAC", Offset = "0xC96DAC", VA = "0xC96DAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x626E38", Offset = "0x626E38")]
		internal IEnumerable<KeyValuePair<string, TransactionHistoryEntry>> GetTransactionEntries()
		{
			return null;
		}

		[Token(Token = "0x600472B")]
		[Address(RVA = "0xC96E18", Offset = "0xC96E18", VA = "0xC96E18")]
		private TransactionHistoryEntry GetEntry(string firstpartytransactionid)
		{
			return null;
		}
	}
}
