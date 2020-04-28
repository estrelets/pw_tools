using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pw.Elements;
using Pw.Elements.v144;
using Pw.Serializer;
using Tests.Common;

namespace Pw.Tests.SerializerTests
{
    [TestClass]
    public class ElementsSerializeTest
    {
        private const int EquipmentAddonListOffset = 12;
        private const int EquipmentAddonLength = 84;
        private const int WeaponListOffset = 228036;
        private const int WeaponLength = 1420;
        private const int ArmorListOffset = 3325348;
        private const int ArmorLength = 1128;
        private const int TalkProcListOffset = 23930279;
        private const int TalkProcLength = 888;

        [TestMethod]
        public void DeserializeSimpleType()
        {
            var addon = Deserialize<EquipmentAddon>(EquipmentAddonListOffset);

            Assert.IsNotNull(addon);
            Assert.AreEqual(100, addon.Param2);
        }

        [TestMethod]
        public void DeserializeTypeWithArrayOfComplexProperties()
        {
            var weaponEssence = Deserialize<WeaponEssence>(WeaponListOffset);

            Assert.IsNotNull(weaponEssence);
            Assert.IsNotNull(weaponEssence.Addons);
            Assert.IsNotNull(weaponEssence.Addons.First());
        }

        [TestMethod]
        public void DeserializeTypeWithArrayOfTuples()
        {
            var armor = Deserialize<ArmorEssence>(ArmorListOffset);

            Assert.IsNotNull(armor);
            Assert.IsNotNull(armor.MagicDefences);
            Assert.IsNotNull(armor.MagicDefences.First());
        }

        [TestMethod]
        public void DeserializeTypeWithDynamicArrayAndString()
        {
            var talkProc = Deserialize<TalkProc>(TalkProcListOffset);

            Assert.IsNotNull(talkProc);
        }


        [TestMethod]
        public void SerializeSimpleType()
        {
            CompareOriginalAndSerializedBytes<EquipmentAddon>(EquipmentAddonListOffset, EquipmentAddonLength);
        }

        [TestMethod]
        public void SerializeTypeWithArrayOfComplexProperties()
        {
            CompareOriginalAndSerializedBytes<WeaponEssence>(WeaponListOffset, WeaponLength);
        }

        [TestMethod]
        public void SerializeTypeWithArrayOfTuples()
        {
            CompareOriginalAndSerializedBytes<ArmorEssence>(ArmorListOffset, ArmorLength);
        }

        [TestMethod]
        public void SerializeTypeWithDynamicArrayAndString()
        {
            CompareOriginalAndSerializedBytes<TalkProc>(TalkProcListOffset, TalkProcLength);
        }

        private void CompareOriginalAndSerializedBytes<T>(int offset, int length) where T : new()
        {
            var originalBytes = GetChunkFromSample(offset, length);
            var item = Deserialize<T>(offset);
            var serializer = new ElementsSerializer();

            var memoryStream = new MemoryStream();
            serializer.Serialize(item, memoryStream);
            var bytesSerialized = memoryStream.ToArray();

            CollectionAssert.AreEqual(originalBytes, bytesSerialized);
        }

        private T Deserialize<T>(int offset) where T : new()
        {
            using (var stream = GetSampleStream(offset))
            {
                var serializer = new ElementsSerializer();

                return serializer.DeSerialize<T>(stream);
            }
        }

        private byte[] GetChunkFromSample(int offset, int length)
        {
            using (var stream = GetSampleStream(offset))
            {
                var buffer = new byte[length];
                stream.Read(buffer, 0, length);
                return buffer;
            }
        }

        private Stream GetSampleStream(int offset)
        {
            var resourceName = Resources.SampleElementsData;
            var stream = EmbeddedResourceGetter.GetResourceStream(resourceName);

            stream.Seek(offset, SeekOrigin.Begin);

            return stream;
        }
    }
}
