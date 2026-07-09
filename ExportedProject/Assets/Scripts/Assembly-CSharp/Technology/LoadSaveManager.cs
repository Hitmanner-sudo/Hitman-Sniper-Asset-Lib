using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AA6")]
	public static class LoadSaveManager
	{
		[Token(Token = "0x2000AA7")]
		public struct PostLoadArgs
		{
			[Token(Token = "0x40036DA")]
			[FieldOffset(Offset = "0x0")]
			public JSONNode Data;

			[Token(Token = "0x40036DB")]
			[FieldOffset(Offset = "0x8")]
			public byte Version;
		}

		[Serializable]
		[Token(Token = "0x2000AA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597C00", Offset = "0x597C00")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40036DC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40036DD")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, PersistenceId>, bool> _003C_003E9__23_0;

			[Token(Token = "0x40036DE")]
			[FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, PersistenceId>, GameObject> _003C_003E9__23_1;

			[Token(Token = "0x40036DF")]
			[FieldOffset(Offset = "0x18")]
			public static Func<GameObject, bool> _003C_003E9__23_2;

			[Token(Token = "0x40036E0")]
			[FieldOffset(Offset = "0x20")]
			public static Func<GameObject, IEnumerable<MonoBehaviour>> _003C_003E9__23_3;

			[Token(Token = "0x40036E1")]
			[FieldOffset(Offset = "0x28")]
			public static Func<MonoBehaviour, bool> _003C_003E9__23_4;

			[Token(Token = "0x40036E2")]
			[FieldOffset(Offset = "0x30")]
			public static Func<KeyValuePair<string, PersistenceId>, bool> _003C_003E9__24_0;

			[Token(Token = "0x40036E3")]
			[FieldOffset(Offset = "0x38")]
			public static Func<KeyValuePair<string, PersistenceId>, GameObject> _003C_003E9__24_1;

			[Token(Token = "0x40036E4")]
			[FieldOffset(Offset = "0x40")]
			public static Func<GameObject, bool> _003C_003E9__24_2;

			[Token(Token = "0x60042E4")]
			[Address(RVA = "0x8C19EC", Offset = "0x8C19EC", VA = "0x8C19EC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60042E5")]
			[Address(RVA = "0x8C19F4", Offset = "0x8C19F4", VA = "0x8C19F4")]
			internal bool _003CGetComponentsToBeSaved_003Eb__23_0(KeyValuePair<string, PersistenceId> id)
			{
				return default(bool);
			}

			[Token(Token = "0x60042E6")]
			[Address(RVA = "0x8C1A68", Offset = "0x8C1A68", VA = "0x8C1A68")]
			internal GameObject _003CGetComponentsToBeSaved_003Eb__23_1(KeyValuePair<string, PersistenceId> id)
			{
				return null;
			}

			[Token(Token = "0x60042E7")]
			[Address(RVA = "0x8C1AB4", Offset = "0x8C1AB4", VA = "0x8C1AB4")]
			internal bool _003CGetComponentsToBeSaved_003Eb__23_2(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x60042E8")]
			[Address(RVA = "0x8C1B1C", Offset = "0x8C1B1C", VA = "0x8C1B1C")]
			internal IEnumerable<MonoBehaviour> _003CGetComponentsToBeSaved_003Eb__23_3(GameObject go)
			{
				return null;
			}

			[Token(Token = "0x60042E9")]
			[Address(RVA = "0x8C1B70", Offset = "0x8C1B70", VA = "0x8C1B70")]
			internal bool _003CGetComponentsToBeSaved_003Eb__23_4(MonoBehaviour cp)
			{
				return default(bool);
			}

			[Token(Token = "0x60042EA")]
			[Address(RVA = "0x8C1BD8", Offset = "0x8C1BD8", VA = "0x8C1BD8")]
			internal bool _003CGetObjectsWithPersistenId_003Eb__24_0(KeyValuePair<string, PersistenceId> id)
			{
				return default(bool);
			}

			[Token(Token = "0x60042EB")]
			[Address(RVA = "0x8C1C4C", Offset = "0x8C1C4C", VA = "0x8C1C4C")]
			internal GameObject _003CGetObjectsWithPersistenId_003Eb__24_1(KeyValuePair<string, PersistenceId> id)
			{
				return null;
			}

			[Token(Token = "0x60042EC")]
			[Address(RVA = "0x8C1C98", Offset = "0x8C1C98", VA = "0x8C1C98")]
			internal bool _003CGetObjectsWithPersistenId_003Eb__24_2(GameObject go)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40036D2")]
		internal const byte VERSION_1 = 1;

		[Token(Token = "0x40036D3")]
		internal const byte VERSION_2 = 2;

		[Token(Token = "0x40036D4")]
		internal const byte VERSION_3 = 3;

		[Token(Token = "0x40036D5")]
		internal const byte VERSION_4 = 4;

		[Token(Token = "0x40036D6")]
		internal const byte VERSION_5 = 5;

		[Token(Token = "0x40036D7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly byte CURRENT_VERSION;

		[Token(Token = "0x40036D8")]
		[FieldOffset(Offset = "0x8")]
		private static string _referenceEmptySaveGame;

		[Token(Token = "0x40036D9")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, PersistenceId> _toPersist;

		[Token(Token = "0x60042D1")]
		[Address(RVA = "0x9CF484", Offset = "0x9CF484", VA = "0x9CF484")]
		public static bool AddObjectToPersist(PersistenceId id)
		{
			return default(bool);
		}

		[Token(Token = "0x60042D2")]
		[Address(RVA = "0x9CF574", Offset = "0x9CF574", VA = "0x9CF574")]
		public static void RemoveObjectToPersist(string id)
		{
		}

		[Token(Token = "0x60042D3")]
		[Address(RVA = "0x9CF658", Offset = "0x9CF658", VA = "0x9CF658")]
		public static void Save(string title)
		{
		}

		[Token(Token = "0x60042D4")]
		[Address(RVA = "0x9CF734", Offset = "0x9CF734", VA = "0x9CF734")]
		private static string SerializeGame()
		{
			return null;
		}

		[Token(Token = "0x60042D5")]
		[Address(RVA = "0x9CFF38", Offset = "0x9CFF38", VA = "0x9CFF38")]
		public static void PushLastSaveOnline()
		{
		}

		[Token(Token = "0x60042D6")]
		[Address(RVA = "0x9CFF44", Offset = "0x9CFF44", VA = "0x9CFF44")]
		public static void RecordEmptySave()
		{
		}

		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x9CFFDC", Offset = "0x9CFFDC", VA = "0x9CFFDC")]
		public static void Load(string title)
		{
		}

		[Token(Token = "0x60042D8")]
		[Address(RVA = "0x9D0878", Offset = "0x9D0878", VA = "0x9D0878")]
		private static void Clear(string title)
		{
		}

		[Token(Token = "0x60042D9")]
		[Address(RVA = "0x9D0930", Offset = "0x9D0930", VA = "0x9D0930")]
		public static void Reset(string title)
		{
		}

		[Token(Token = "0x60042DA")]
		[Address(RVA = "0x9D0A18", Offset = "0x9D0A18", VA = "0x9D0A18")]
		public static void Deserialize(string saveString, out JSONNode data, out byte version)
		{
		}

		[Token(Token = "0x60042DB")]
		[Address(RVA = "0x9D11E0", Offset = "0x9D11E0", VA = "0x9D11E0")]
		public static string GetFilepath(string title)
		{
			return null;
		}

		[Token(Token = "0x60042DC")]
		[Address(RVA = "0x9D1240", Offset = "0x9D1240", VA = "0x9D1240")]
		public static bool DoesSaveGameExist(string title)
		{
			return default(bool);
		}

		[Token(Token = "0x60042DD")]
		[Address(RVA = "0x9D005C", Offset = "0x9D005C", VA = "0x9D005C")]
		public static JSONNode DeserializeListOfStoredComponentsFromLocalPersistence(string title, out byte version)
		{
			return null;
		}

		[Token(Token = "0x60042DE")]
		[Address(RVA = "0x9D0A94", Offset = "0x9D0A94", VA = "0x9D0A94")]
		private static JSONNode DeserializeListOfStoredComponents(string saveString, out byte version)
		{
			return null;
		}

		[Token(Token = "0x60042DF")]
		[Address(RVA = "0x9CF9E8", Offset = "0x9CF9E8", VA = "0x9CF9E8")]
		private static MonoBehaviour[] GetComponentsToBeSaved()
		{
			return null;
		}

		[Token(Token = "0x60042E0")]
		[Address(RVA = "0x9D1394", Offset = "0x9D1394", VA = "0x9D1394")]
		private static IEnumerable<GameObject> GetObjectsWithPersistenId()
		{
			return null;
		}

		[Token(Token = "0x60042E1")]
		[Address(RVA = "0x9D0490", Offset = "0x9D0490", VA = "0x9D0490")]
		private static void InformObjectsWithPostLoadMessage(JSONNode data, byte version)
		{
		}
	}
}
