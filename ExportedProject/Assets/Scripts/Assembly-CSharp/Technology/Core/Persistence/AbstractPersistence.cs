using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D24")]
	public abstract class AbstractPersistence
	{
		[Token(Token = "0x2000D25")]
		public delegate void SaveGameIsCorruptEvent();

		[Token(Token = "0x2000D26")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59886C", Offset = "0x59886C")]
		private sealed class _003Cget_IsReady_003Ed__29 : IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003EE0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003EE1")]
			[FieldOffset(Offset = "0x14")]
			private bool _003C_003E2__current;

			[Token(Token = "0x4003EE2")]
			[FieldOffset(Offset = "0x18")]
			public AbstractPersistence _003C_003E4__this;

			[Token(Token = "0x17000ABB")]
			private bool System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EBoolean_003E_002ECurrent
			{
				[Token(Token = "0x600512F")]
				[Address(RVA = "0x911940", Offset = "0x911940", VA = "0x911940", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000ABC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005131")]
				[Address(RVA = "0x911988", Offset = "0x911988", VA = "0x911988", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600512C")]
			[Address(RVA = "0x911890", Offset = "0x911890", VA = "0x911890")]
			[DebuggerHidden]
			public _003Cget_IsReady_003Ed__29(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600512D")]
			[Address(RVA = "0x9118BC", Offset = "0x9118BC", VA = "0x9118BC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600512E")]
			[Address(RVA = "0x9118C0", Offset = "0x9118C0", VA = "0x9118C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6005130")]
			[Address(RVA = "0x911948", Offset = "0x911948", VA = "0x911948", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4003ED6")]
		[FieldOffset(Offset = "0x10")]
		public bool IsAutoSaveEnabled;

		[Token(Token = "0x4003ED7")]
		[FieldOffset(Offset = "0x14")]
		public PersistorState State;

		[Token(Token = "0x4003ED8")]
		[FieldOffset(Offset = "0x18")]
		protected readonly IPersister _persister;

		[Token(Token = "0x4003ED9")]
		protected const string SAVE_DATA_PREFIX = "SaveData";

		[Token(Token = "0x4003EDA")]
		private const string _boolType = "System.Boolean";

		[Token(Token = "0x4003EDB")]
		private const string _floatType = "System.Single";

		[Token(Token = "0x4003EDC")]
		private const string _intType = "System.Int32";

		[Token(Token = "0x4003EDD")]
		private const string _longType = "System.Int64";

		[Token(Token = "0x4003EDE")]
		private const string _stringType = "System.String";

		[Token(Token = "0x4003EDF")]
		[FieldOffset(Offset = "0x20")]
		protected PersistenceCacheGroup Cache;

		[Token(Token = "0x17000AB3")]
		protected IPersistableCache<int> CacheInt
		{
			[Token(Token = "0x60050FB")]
			[Address(RVA = "0xAA0FB4", Offset = "0xAA0FB4", VA = "0xAA0FB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60050FC")]
			[Address(RVA = "0xAA0FD0", Offset = "0xAA0FD0", VA = "0xAA0FD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB4")]
		protected IPersistableCache<long> CacheLong
		{
			[Token(Token = "0x60050FD")]
			[Address(RVA = "0xAA0FEC", Offset = "0xAA0FEC", VA = "0xAA0FEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60050FE")]
			[Address(RVA = "0xAA1008", Offset = "0xAA1008", VA = "0xAA1008")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB5")]
		protected IPersistableCache<float> CacheFloat
		{
			[Token(Token = "0x60050FF")]
			[Address(RVA = "0xAA1024", Offset = "0xAA1024", VA = "0xAA1024")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005100")]
			[Address(RVA = "0xAA1040", Offset = "0xAA1040", VA = "0xAA1040")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB6")]
		protected IPersistableCache<string> CacheString
		{
			[Token(Token = "0x6005101")]
			[Address(RVA = "0xAA105C", Offset = "0xAA105C", VA = "0xAA105C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005102")]
			[Address(RVA = "0xAA1078", Offset = "0xAA1078", VA = "0xAA1078")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB7")]
		protected IPersistableCache<bool> CacheBool
		{
			[Token(Token = "0x6005103")]
			[Address(RVA = "0xAA1094", Offset = "0xAA1094", VA = "0xAA1094")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005104")]
			[Address(RVA = "0xAA10B0", Offset = "0xAA10B0", VA = "0xAA10B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB8")]
		public DateTime TimeStamp
		{
			[Token(Token = "0x6005105")]
			[Address(RVA = "0xAA10CC", Offset = "0xAA10CC", VA = "0xAA10CC")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000AB9")]
		public IEnumerator<bool> IsReady
		{
			[Token(Token = "0x6005106")]
			[Address(RVA = "0xAA124C", Offset = "0xAA124C", VA = "0xAA124C")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6295E0", Offset = "0x6295E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ABA")]
		public bool SkipCollisionCheck
		{
			[Token(Token = "0x6005107")]
			[Address(RVA = "0xAA12B8", Offset = "0xAA12B8", VA = "0xAA12B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005108")]
			[Address(RVA = "0xAA15B0", Offset = "0xAA15B0", VA = "0xAA15B0")]
			set
			{
			}
		}

		[Token(Token = "0x6005109")]
		public bool ContainsKey<T>(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600510A")]
		[Address(RVA = "0xAA18A8", Offset = "0xAA18A8", VA = "0xAA18A8")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600510B")]
		[Address(RVA = "0xA9DD2C", Offset = "0xA9DD2C", VA = "0xA9DD2C")]
		public void ExcludeKey(string key)
		{
		}

		[Token(Token = "0x600510C")]
		[Address(RVA = "0xAA1BC4", Offset = "0xAA1BC4", VA = "0xAA1BC4")]
		public void IncludeKey(string key)
		{
		}

		[Token(Token = "0x600510D")]
		public void Set<T>(string key, T value)
		{
		}

		[Token(Token = "0x600510E")]
		public object Get<T>(string key, T defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600510F")]
		[Address(RVA = "0xAA1EBC", Offset = "0xAA1EBC", VA = "0xAA1EBC")]
		public bool GetBool(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6005110")]
		[Address(RVA = "0xAA1F60", Offset = "0xAA1F60", VA = "0xAA1F60")]
		public float GetFloat(string key, float defaultValue = -1f)
		{
			return default(float);
		}

		[Token(Token = "0x6005111")]
		[Address(RVA = "0xAA200C", Offset = "0xAA200C", VA = "0xAA200C")]
		public int GetInt(string key, int defaultValue = -1)
		{
			return default(int);
		}

		[Token(Token = "0x6005112")]
		[Address(RVA = "0xAA11A8", Offset = "0xAA11A8", VA = "0xAA11A8")]
		public long GetLong(string key, long defaultValue = -1L)
		{
			return default(long);
		}

		[Token(Token = "0x6005113")]
		[Address(RVA = "0xAA20B0", Offset = "0xAA20B0", VA = "0xAA20B0")]
		public string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		[Token(Token = "0x6005114")]
		[Address(RVA = "0xAA2154", Offset = "0xAA2154", VA = "0xAA2154")]
		public void Save()
		{
		}

		[Token(Token = "0x6005115")]
		[Address(RVA = "0xAA2528", Offset = "0xAA2528", VA = "0xAA2528")]
		public void Load()
		{
		}

		[Token(Token = "0x6005116")]
		[Address(RVA = "0xAA2838", Offset = "0xAA2838", VA = "0xAA2838")]
		public void Load(Dictionary<string, object> dictionary)
		{
		}

		[Token(Token = "0x6005117")]
		protected abstract void PostLoadFromDictionary();

		[Token(Token = "0x6005118")]
		[Address(RVA = "0xAA2FFC", Offset = "0xAA2FFC", VA = "0xAA2FFC")]
		public Dictionary<string, bool> CopyInDictionaryBool()
		{
			return null;
		}

		[Token(Token = "0x6005119")]
		[Address(RVA = "0xAA30B0", Offset = "0xAA30B0", VA = "0xAA30B0")]
		public Dictionary<string, float> CopyInDictionaryFloat()
		{
			return null;
		}

		[Token(Token = "0x600511A")]
		[Address(RVA = "0xAA3164", Offset = "0xAA3164", VA = "0xAA3164")]
		public Dictionary<string, int> CopyInDictionaryInt()
		{
			return null;
		}

		[Token(Token = "0x600511B")]
		[Address(RVA = "0xAA3218", Offset = "0xAA3218", VA = "0xAA3218")]
		public Dictionary<string, long> CopyInDictionaryLong()
		{
			return null;
		}

		[Token(Token = "0x600511C")]
		[Address(RVA = "0xAA32CC", Offset = "0xAA32CC", VA = "0xAA32CC")]
		public Dictionary<string, string> CopyInDictionaryString()
		{
			return null;
		}

		[Token(Token = "0x600511D")]
		[Address(RVA = "0xAA3380", Offset = "0xAA3380", VA = "0xAA3380")]
		public void Merge(AbstractPersistence other)
		{
		}

		[Token(Token = "0x600511E")]
		[Address(RVA = "0xAA2D24", Offset = "0xAA2D24", VA = "0xAA2D24")]
		public void Clear()
		{
		}

		[Token(Token = "0x600511F")]
		[Address(RVA = "0xAA34D8", Offset = "0xAA34D8", VA = "0xAA34D8")]
		public void ResetDeviceId()
		{
		}

		[Token(Token = "0x6005120")]
		[Address(RVA = "0xAA35C4", Offset = "0xAA35C4", VA = "0xAA35C4")]
		protected AbstractPersistence(IPersister persister, bool autoload)
		{
		}

		[Token(Token = "0x6005121")]
		protected abstract void Write();

		[Token(Token = "0x6005122")]
		protected abstract void Read();

		[Token(Token = "0x6005123")]
		private void Merge<T>(IPersistableCache<T> destination, IPersistableCache<T> source)
		{
		}

		[Token(Token = "0x6005124")]
		private void SetInternal<T>(string key, T value)
		{
		}

		[Token(Token = "0x6005125")]
		private void Add<T>(string key, T value)
		{
		}

		[Token(Token = "0x6005126")]
		[Address(RVA = "0xAA246C", Offset = "0xAA246C", VA = "0xAA246C")]
		private void SetTimeStamp()
		{
		}

		[Token(Token = "0x6005127")]
		[Address(RVA = "0xAA365C", Offset = "0xAA365C", VA = "0xAA365C")]
		private void AutoSave()
		{
		}
	}
	[Token(Token = "0x2000D3D")]
	public abstract class AbstractPersistence<T>
	{
		[Token(Token = "0x4003F38")]
		[FieldOffset(Offset = "0x0")]
		protected readonly string _key;

		[Token(Token = "0x4003F39")]
		[FieldOffset(Offset = "0x0")]
		protected T _value;

		[Token(Token = "0x4003F3A")]
		[FieldOffset(Offset = "0x0")]
		protected T _defaultValue;

		[Token(Token = "0x4003F3B")]
		[FieldOffset(Offset = "0x0")]
		private bool _loaded;

		[Token(Token = "0x17000ACE")]
		public string Key
		{
			[Token(Token = "0x60051AE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ACF")]
		public T Value
		{
			[Token(Token = "0x60051AF")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60051B0")]
			set
			{
			}
		}

		[Token(Token = "0x60051AC")]
		protected abstract T Get();

		[Token(Token = "0x60051AD")]
		protected abstract void Set(T value);

		[Token(Token = "0x60051B1")]
		private AbstractPersistence()
		{
		}

		[Token(Token = "0x60051B2")]
		internal AbstractPersistence(string key, T defaultValue)
		{
		}
	}
}
