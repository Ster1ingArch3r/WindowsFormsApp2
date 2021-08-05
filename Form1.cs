using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExpAddBox.Focus();
            ExpAddBox.Select(ExpAddBox.Text.Length, 0);
        }

        private void ShowCharsBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=characters.db;Version=3;Compress=True;");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM saved_characters2;", conn);
            using (SQLiteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    charData.Rows.Add(new object[]{
                    read.GetValue(0),
                    read.GetValue(1),
                    read.GetValue(2),
                    read.GetValue(9)
                    });
                }
            }

        }

        private void SelCharButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(charData.Rows[charData.CurrentRow.Index].Cells[0].Value);
                SQLiteConnection conn = new SQLiteConnection("Data Source=characters.db;Version=3;Compress=True;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM saved_characters2 WHERE ID = {ID};", conn);
                using (SQLiteDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        LevelBox.Text = (read["LEVEL"].ToString());
                        TotalXp.Text = (read["EXPERIENCE"].ToString());
                        NameBox.Text = (read["NAME"].ToString());
                        RaceBox.Text = (read["RACE"].ToString());
                        StrengthBox.Text = (read["STRENGTH"].ToString());
                        DexterityBox.Text = (read["DEXTERITY"].ToString());
                        ConstitutionBox.Text = (read["CONSTITUTION"].ToString());
                        IntelligenceBox.Text = (read["INTELLIGENCE"].ToString());
                        WisdomBox.Text = (read["WISDOM"].ToString());
                        CharismaBox.Text = (read["CHARISMA"].ToString());

                    }
                    conn.Close();
                }
            }
            catch(SQLiteException SQLEx)
            {
                MessageBox.Show(Convert.ToString(SQLEx));
            }


        }

        private void AddEXPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ttlxp;
                int neededxp;
                int level;
                int spend;

                ttlxp = Convert.ToInt32(TotalXp.Text) + Convert.ToInt32(ExpAddBox.Text);
                TotalXp.Text = ttlxp.ToString();

                if (ttlxp >= Convert.ToInt32(TotalNeeded.Text))
                {
                    ttlxp = ttlxp - Convert.ToInt32(TotalNeeded.Text);
                    TotalXp.Text = ttlxp.ToString();
                    neededxp = Convert.ToInt32(Math.Round(Convert.ToDouble(TotalNeeded.Text) + Convert.ToDouble(TotalNeeded.Text) * .20));
                    TotalNeeded.Text = neededxp.ToString();
                    level = Convert.ToInt32(LevelBox.Text);
                    level++;
                    LevelBox.Text = level.ToString();
                    spend = Convert.ToInt32(SpendBox.Text);
                    spend = spend + 3;
                    SpendBox.Text = spend.ToString();
                    

                }
                ExpAddBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("EXP Can only be whole numbers. You aren't allowed to math letters. This isn't high school algebra...");
            }


              
            
        }

        private void SaveProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
