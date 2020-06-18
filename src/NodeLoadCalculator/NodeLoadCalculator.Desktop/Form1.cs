using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeLoadCalculator.Desktop
{
    public partial class Form1 : Form
    {
        #region Constants
        const string valueFileName = "data.txt";
        const string relationFileName = "data2.txt";
        const string sparatorCharacter = " ";
        const int padTextLength = 3;
        #endregion

        #region Variables
        static int[] values;//Deger
        static int[,] relation;//baglant
        #endregion

        #region Preparing Methods
        private static int[] splitterValue(string rawString)
        {
            var splittedString = rawString.Split(new string[] { sparatorCharacter }, StringSplitOptions.RemoveEmptyEntries);
            var node = new int[splittedString.Length];
            var index = 0;
            foreach (var s in splittedString)
            {
                if (int.TryParse(s, out var value))
                {
                    node[index] = value;
                    index++;
                }
            }

            return node;
        }
        private static int[,] splitterRelation(string rawString)
        {

            if (string.IsNullOrEmpty(rawString))
                return null;

            if (rawString.IndexOf("\n") > -1)
            {
                var lines = rawString.Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
                var relations = new int[lines.Length, lines.Length];
                var x = 0;
                foreach (var line in lines)
                {

                    var splittedString = line.Split(new string[] { sparatorCharacter }, StringSplitOptions.RemoveEmptyEntries);
                    var y = 0;
                    foreach (var s in splittedString)
                    {
                        if (int.TryParse(s, out var value))
                        {
                            relations[x, y] = value;
                            y++;
                        }
                    }
                    x++;
                }

                return relations;
            }
            return null;
        }
        public static void ReadFileValue()
        {

            var valueFilePath = Path.Combine(Environment.CurrentDirectory, valueFileName);
            using (StreamReader reader = new StreamReader(valueFilePath))
            {
                var line = reader.ReadLine();
                values = splitterValue(line);
                reader.Close();

            }
        }
        public static void ReadFileRelation()
        {

            var relationFilePath = Path.Combine(Environment.CurrentDirectory, relationFileName);
            using (StreamReader reader = new StreamReader(relationFilePath))
            {
                string rawContent = reader.ReadToEnd();
                relation = splitterRelation(rawContent);
                reader.Close();
            }
        }
        private Panel CreateNode(string label, string val, string name)
        {
            var tb = new TextBox();
            tb.Dock = System.Windows.Forms.DockStyle.Fill;
            tb.Location = new System.Drawing.Point(0, 25);
            tb.Name = $"tb_{name}";
            tb.Size = new System.Drawing.Size(30, 26);
            tb.TabIndex = 0;
            tb.Enabled = false;

            tb.Text = val;

            var lb = new Label();
            lb.AutoSize = true;
            lb.Dock = System.Windows.Forms.DockStyle.Top;
            lb.Location = new System.Drawing.Point(0, 5);
            lb.Name = $"lb_{name}";
            lb.Size = new System.Drawing.Size(30, 20);
            lb.TabIndex = 0;
            lb.Text = label;

            var pnl = new Panel();
            pnl.Controls.Add(tb);
            pnl.Controls.Add(lb);
            pnl.Name = $"pnl_{name}";
            pnl.Size = new System.Drawing.Size(30, 57);
            pnl.TabIndex = 3;

            return pnl;
        }
        private Label CreateLabel(string label, string name)
        {
            var lb = new Label();
            lb.AutoSize = true;
            lb.Dock = System.Windows.Forms.DockStyle.Top;
            lb.Location = new System.Drawing.Point(0, 5);
            lb.Name = $"lb_{name}";
            lb.Size = new System.Drawing.Size(30, 20);
            lb.TabIndex = 0;
            lb.Text = label;

            return lb;
        }
        private void DrawValues()
        {
            var counter = 1;
            this.flp_values.Controls.Clear();
            foreach (var i in values)
            {
                var p = CreateNode(counter.ToString(), i.ToString(), $"vls{counter}");

                this.flp_values.Controls.Add(p);
                counter++;
            }
        }
        private void DrawRelations()
        {
            this.flp_relations.Controls.Clear();
            for (int i = 0; i <= relation.GetLength(0); i++)
            {
                for (int j = 0; j <= relation.GetLength(1); j++)
                {
                    Label l;

                    if (i == 0 && j == 0)
                        l = CreateLabel($"X".PadRight(3, ' '), $"rlt{i}{j}");
                    else if (i == 0)
                        l = CreateLabel($"{j}".PadRight(3, ' '), $"rlt{i}{j}");
                    else if (j == 0)
                        l = CreateLabel($"{i}".PadRight(3, ' '), $"rlt{i}{j}");
                    else
                        l = CreateLabel($"{relation[i - 1, j - 1]}".PadRight(3, ' '), $"rlt{i}{j}");



                    this.flp_relations.Controls.Add(l);
                }
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private int Calculate(int node, List<int> searchedNode)
        {
            if (searchedNode == null)
                searchedNode = new List<int>();
            else if (searchedNode.Any(x => x == node))
                return 0;

            searchedNode.Add(node);
            int total = values[node];
            for (int i = 0; i < relation.GetLength(1); i++)
            {
                if (relation[node, i] == 1)
                    total += Calculate(i, searchedNode);
            }
            return total;
        }
        private void DrawNodePoint()
        {
            for(int i=0; i<values.Length; i++) {
                var val = Calculate(i, null);
                var p = CreateNode($"{i + 1}", $"{val}", $"np{i}");
                flp_result.Controls.Add(p);
            }
        }
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            ReadFileValue();
            DrawValues();
            ReadFileRelation();
            DrawRelations();

            DrawNodePoint();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
