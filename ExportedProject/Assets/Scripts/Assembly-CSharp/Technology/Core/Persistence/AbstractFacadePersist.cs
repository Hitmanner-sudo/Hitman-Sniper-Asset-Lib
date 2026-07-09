using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D3C")]
	public abstract class AbstractFacadePersist<T> where T : AbstractPersistence, new()
	{
		[Token(Token = "0x4003F37")]
		[FieldOffset(Offset = "0x0")]
		private static T _persistence;

		[Token(Token = "0x17000AC8")]
		public static bool IsAutoSaveEnabled
		{
			[Token(Token = "0x600518C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600518D")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC9")]
		public static bool SkipCollisionCheck
		{
			[Token(Token = "0x600518E")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600518F")]
			set
			{
			}
		}

		[Token(Token = "0x17000ACA")]
		public static DateTime Timestamp
		{
			[Token(Token = "0x6005190")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000ACB")]
		public static T Persistence
		{
			[Token(Token = "0x6005191")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ACC")]
		public static PersistorState State
		{
			[Token(Token = "0x6005192")]
			get
			{
				return default(PersistorState);
			}
		}

		[Token(Token = "0x17000ACD")]
		public static IEnumerator<bool> IsReady
		{
			[Token(Token = "0x6005193")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005194")]
		public static void Save()
		{
		}

		[Token(Token = "0x6005195")]
		public static void Load()
		{
		}

		[Token(Token = "0x6005196")]
		public static void Load(Dictionary<string, object> dictionary)
		{
		}

		[Token(Token = "0x6005197")]
		public static void Clear()
		{
		}

		[Token(Token = "0x6005198")]
		public static void Merge(AbstractPersistence other)
		{
		}

		[Token(Token = "0x6005199")]
		public static bool ContainsKey<TS>(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600519A")]
		public static bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600519B")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600519C")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600519D")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600519E")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x600519F")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60051A0")]
		public static bool GetBool(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60051A1")]
		public static float GetFloat(string key, float defaultValue = -1f)
		{
			return default(float);
		}

		[Token(Token = "0x60051A2")]
		public static int GetInt(string key, int defaultValue = -1)
		{
			return default(int);
		}

		[Token(Token = "0x60051A3")]
		public static long GetLong(string key, long defaultValue = -1L)
		{
			return default(long);
		}

		[Token(Token = "0x60051A4")]
		public static string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		[Token(Token = "0x60051A5")]
		public static Dictionary<string, bool> CopyInDictionaryBool()
		{
			return null;
		}

		[Token(Token = "0x60051A6")]
		public static Dictionary<string, float> CopyInDictionaryFloat()
		{
			return null;
		}

		[Token(Token = "0x60051A7")]
		public static Dictionary<string, int> CopyInDictionaryInt()
		{
			return null;
		}

		[Token(Token = "0x60051A8")]
		public static Dictionary<string, long> CopyInDictionaryLong()
		{
			return null;
		}

		[Token(Token = "0x60051A9")]
		public static Dictionary<string, string> CopyInDictionaryString()
		{
			return null;
		}

		[Token(Token = "0x60051AA")]
		protected AbstractFacadePersist()
		{
		}
	}
}
