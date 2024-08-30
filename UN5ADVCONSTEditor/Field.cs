using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UN5ADVCONSTEditor
{
    public class Field
    {
        public float iconsPosX, iconsPosY, iconsScaleX, iconsScaleY;
        public string Name = "", stageCCS = "", bgdataName = "", DMYName = "", mapName = "";
        public static Field Read(byte[] Input) => new Field
        {
            Name = Util.ReadStringFromBuffer(Input.ReadBytes(0x0, 0x20), 0x20, "shift-jis"),
            stageCCS = Util.ReadStringFromBuffer(Input.ReadBytes(0x20, 0x20), 0x20, "UTF-8"),
            bgdataName = Util.ReadStringFromBuffer(Input.ReadBytes(0x40, 0x20), 0x20, "UTF-8"),
            DMYName = Util.ReadStringFromBuffer(Input.ReadBytes(0x60, 0x20), 0x20, "UTF-8"),
            mapName = Util.ReadStringFromBuffer(Input.ReadBytes(0x80, 0x20), 0x20, "UTF-8"),
            iconsPosX = Input.ReadSingle(0xA0),
            iconsPosY = Input.ReadSingle(0xA4),
            iconsScaleX = Input.ReadSingle(0xA8),
            iconsScaleY = Input.ReadSingle(0xAC)
        };

        public static byte[] Write(Field fieldData)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(Util.WriteString(fieldData.Name, 0x20, "shift-jis"), 0, 0x20);
            ms.Write(Util.WriteString(fieldData.stageCCS, 0x20, "UTF-8"), 0, 0x20);
            ms.Write(Util.WriteString(fieldData.bgdataName, 0x20, "UTF-8"), 0, 0x20);
            ms.Write(Util.WriteString(fieldData.DMYName, 0x20, "UTF-8"), 0, 0x20);
            ms.Write(Util.WriteString(fieldData.mapName, 0x20, "UTF-8"), 0, 0x20);
            ms.Write(BitConverter.GetBytes(Convert.ToSingle(fieldData.iconsPosX)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToSingle(fieldData.iconsPosY)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToSingle(fieldData.iconsScaleX)), 0, 4);
            ms.Write(BitConverter.GetBytes(Convert.ToSingle(fieldData.iconsScaleY)), 0, 4);
            return ms.ToArray();
        }
    }
}
