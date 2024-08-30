using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5ADVCONSTEditor
{
    public class BattleField
    {
        public uint ID1, ID2;
        public string stageCCS = "", bgdataName = "";
        public static BattleField Read(byte[] Input) => new BattleField
        {
            ID1 = Input.ReadUInt(0x0, 32),
            ID2 = Input.ReadUInt(0x4, 32),
            stageCCS = Util.ReadStringFromBuffer(Input.ReadBytes(0x8, 0x20), 0x20, "UTF-8"),
            bgdataName = Util.ReadStringFromBuffer(Input.ReadBytes(0x28, 0x20), 0x20, "UTF-8")
        };

        public static byte[] Write(BattleField bfieldData)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(bfieldData.ID1)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToUInt32(bfieldData.ID2)), 0, 4);
            ms.Write(Util.WriteString(bfieldData.stageCCS, 0x20, "UTF-8"), 0, 0x20);
            ms.Write(Util.WriteString(bfieldData.bgdataName, 0x20, "UTF-8"), 0, 0x20);
            return ms.ToArray();
        }
    }
}
