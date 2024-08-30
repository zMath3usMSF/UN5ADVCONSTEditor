using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UN5ADVCONSTEditor
{
    public partial class Form1 : Form
    {
        public static List<CCSF> ccsList = new List<CCSF>();
        public static List<BattleField> bfieldList = new List<BattleField>();
        public static List<Field> fieldList = new List<Field>();

        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            txtFName.Text = fieldList[index].Name;
            txtFCCS.Text = fieldList[index].stageCCS;
            txtFBgdata.Text = fieldList[index].bgdataName;
            txtFPlposDMY.Text = fieldList[index].DMYName;
            txtFMapTEX.Text = fieldList[index].mapName;
            txtFIconPosX.Text = Convert.ToString(fieldList[index].iconsPosX);
            txtFIconPosY.Text = Convert.ToString(fieldList[index].iconsPosY);
            txtFIconScaleX.Text = Convert.ToString(fieldList[index].iconsScaleX);
            txtFIconScaleY.Text = Convert.ToString(fieldList[index].iconsScaleY);
            txtBFCCS.Text = bfieldList[index].stageCCS;
            txtBFBgdata.Text = bfieldList[index].bgdataName;

        }

        private void saveADVCONSTCCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open the ADVCONST.CCS File";
            ofd.Filter = "ADVCONST.CCS File|ADVCONST.CCS";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(ofd.FileName);
                string fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                ccsList.Clear();
                CCSF ccs = new CCSF();
                ccs.OpenCCS(ofd.FileName);
                pictureBox1.Visible = false;
                saveADVCONSTCCSToolStripMenuItem1.Enabled = true;
                addNewStageToolStripMenuItem.Enabled = true;
                utilToolStripMenuItem.Enabled = true;
                ccsList.Add(ccs);
                listBox1.Items.Clear();
                fieldList.Clear();
                bfieldList.Clear();
                MemoryStream ms = new MemoryStream(ccsList[0].blocks[1].Data);
                for(int i = 0; i < ms.Length / 0x48; i++)
                {
                    byte[] bfieldBlock = new byte[0x48];
                    ms.Read(bfieldBlock, 0, bfieldBlock.Length);
                    bfieldList.Add(BattleField.Read(bfieldBlock));
                }
                ms = new MemoryStream(ccsList[0].blocks[2].Data);
                for (int i = 0; i < ms.Length / 0xB0; i++)
                {
                    byte[] fieldBlock = new byte[0xB0];
                    ms.Read(fieldBlock, 0, fieldBlock.Length);
                    fieldList.Add(Field.Read(fieldBlock));
                    listBox1.Items.Add($"{i}: {fieldList[i].Name}");
                }
                listBox1.SelectedIndex = 0;
            }
        }

        private void exportAllStageNamesToTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> stageNames = new List<string>();
            for(int i = 0; i < fieldList.Count; i++)
            {
                stageNames.Add(fieldList[i].Name);
            }
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllLines(Path.Combine(desktop, "StageNames.txt"), stageNames.ToArray());
        }

        private void importAllStageNamesFromTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open the TXT File";
            ofd.Filter = "TXT File (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                listBox1.Items.Clear();
                for(int i = 0; i < fieldList.Count; i++)
                {
                    listBox1.Items.Add($"{i}: {lines[i]}");
                    fieldList[i].Name = lines[i];
                }
                MemoryStream ms = new MemoryStream();
                for (int i = 0; i <  fieldList.Count; i++)
                {
                    byte[] fieldBlock = Field.Write(fieldList[i]);
                    ms.Write(fieldBlock, 0, fieldBlock.Length);
                }
                ccsList[0].blocks[2].Data = ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            int index = listBox1.SelectedIndex;
            fieldList[index].Name = txtFName.Text;
            listBox1.Items[index] = $"{index}: {txtFName.Text}";
            fieldList[index].stageCCS = txtFCCS.Text;
            fieldList[index].bgdataName = txtFBgdata.Text;
            fieldList[index].DMYName = txtFPlposDMY.Text;
            fieldList[index].mapName = txtFMapTEX.Text;
            fieldList[index].iconsPosX = Convert.ToSingle(txtFIconPosX.Text);
            fieldList[index].iconsPosY = Convert.ToSingle(txtFIconPosY.Text);
            fieldList[index].iconsScaleX = Convert.ToSingle(txtFIconScaleX.Text);
            fieldList[index].iconsScaleY = Convert.ToSingle(txtFIconScaleY.Text);
            bfieldList[index].stageCCS = txtBFCCS.Text;
            bfieldList[index].bgdataName = txtBFBgdata.Text;

            MemoryStream ms = new MemoryStream();
            for (int i = 0; i <  bfieldList.Count; i++)
            {
                byte[] bfieldBlock = BattleField.Write(bfieldList[i]);
                ms.Write(bfieldBlock, 0, bfieldBlock.Length);
            }
            ccsList[0].blocks[1].Data = ms.ToArray();
            ms = new MemoryStream();
            for (int i = 0; i <  fieldList.Count; i++)
            {
                byte[] fieldBlock = Field.Write(fieldList[i]);
                ms.Write(fieldBlock, 0, fieldBlock.Length);
            }
            ccsList[0].blocks[2].Data = ms.ToArray();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void saveADVCONSTCCSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "ADVCONST.CCS File|ADVCONST.CCS";
            sfd.FileName = "ADVCONST.CCS";
            if (sfd.ShowDialog()  == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);
                CCSF.WriteCCS(ccsList[0], path);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            listBox1.Items.Add($"{listBox1.Items.Count}: ");
            fieldList.Add(new Field());
            bfieldList.Add(new BattleField { ID1 = (uint)bfieldList.Count, ID2 = (uint)bfieldList.Count });
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.Clear();
                bfieldList.RemoveAt(index);
                fieldList.RemoveAt(index);
                for (int i = 0; i < fieldList.Count; i++)
                {
                    bfieldList[i].ID1 = (uint)i;
                    bfieldList[i].ID2 = (uint)i;
                    listBox1.Items.Add($"{i}: {fieldList[i].Name}");
                }
            }
            else
            {
                MessageBox.Show("Select a Stage first!");
            }
            if (listBox1.Items.Count >= 1)
            {
                listBox1.SelectedIndex = index == 0 ? 0 : index - 1;
            }
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }
    }
}
