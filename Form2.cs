using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void RaceSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RaceSelectBox.SelectedItem.Equals("Human"))
            {
                StrengthValue.Text = "11";
                DexterityValue.Text = "11";
                ConstitutionValue.Text = "11";
                IntelligenceValue.Text = "11";
                WisdomValue.Text = "11";
                CharismaValue.Text = "11";
                SpendValue.Text = "10";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Halfling"))
            {
                StrengthValue.Text = "10";
                DexterityValue.Text = "12";
                ConstitutionValue.Text = "10";
                IntelligenceValue.Text = "10";
                WisdomValue.Text = "10";
                CharismaValue.Text = "11";
                SpendValue.Text = "10";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Tiefling"))
            {
                StrengthValue.Text = "10";
                DexterityValue.Text = "10";
                ConstitutionValue.Text = "10";
                IntelligenceValue.Text = "11";
                WisdomValue.Text = "10";
                CharismaValue.Text = "12";
                SpendValue.Text = "10";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Dwarf"))
            {
                StrengthValue.Text = "10";
                DexterityValue.Text = "10";
                ConstitutionValue.Text = "12";
                IntelligenceValue.Text = "10";
                WisdomValue.Text = "10";
                CharismaValue.Text = "10";
                SpendValue.Text = "10";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Elf"))
            {
                StrengthValue.Text = "10";
                DexterityValue.Text = "12";
                ConstitutionValue.Text = "10";
                IntelligenceValue.Text = "10";
                WisdomValue.Text = "10";
                CharismaValue.Text = "10";
                SpendValue.Text = "10";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Half-Orc"))
            {
                StrengthValue.Text = "12";
                DexterityValue.Text = "10";
                ConstitutionValue.Text = "11";
                IntelligenceValue.Text = "10";
                WisdomValue.Text = "10";
                CharismaValue.Text = "12";
                SpendValue.Text = "10";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Half-Elf"))
            {
                StrengthValue.Text = "10";
                DexterityValue.Text = "10";
                ConstitutionValue.Text = "10";
                IntelligenceValue.Text = "10";
                WisdomValue.Text = "10";
                CharismaValue.Text = "12";
                SpendValue.Text = "12";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Dragonborn"))
            {
                StrengthValue.Text = "12";
                DexterityValue.Text = "10";
                ConstitutionValue.Text = "10";
                IntelligenceValue.Text = "10";
                WisdomValue.Text = "10";
                CharismaValue.Text = "11";
                SpendValue.Text = "10";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Gnome"))
            {
                StrengthValue.Text = "10";
                DexterityValue.Text = "10";
                ConstitutionValue.Text = "10";
                IntelligenceValue.Text = "12";
                WisdomValue.Text = "10";
                CharismaValue.Text = "10";
                SpendValue.Text = "10";
            }
            else if (RaceSelectBox.SelectedItem.Equals("Custom"))
            {
                StrengthValue.Text = "10";
                DexterityValue.Text = "10";
                ConstitutionValue.Text = "10";
                IntelligenceValue.Text = "10";
                WisdomValue.Text = "10";
                CharismaValue.Text = "10";
                SpendValue.Text = "15";
            }
        }

        //Strength button Minus and plus controls

        private void StrMinus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(StrengthValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {   
                if (str > 14 && str <= 17)
                {
                    str = str - 1;
                    StrengthValue.Text = Convert.ToString(str);
                    spend = spend + 3;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str > 12 && str <= 14)
                {
                    str = str - 1;
                    StrengthValue.Text = Convert.ToString(str);
                    spend = spend + 2;
                    SpendValue.Text = Convert.ToString(spend);
                }    
                else if(str <= 12)
                {
                    if (str == 0)
                    {
                        MessageBox.Show("Strength values must not go below 0!");
                    }
                    else
                    {
                        str = str - 1;
                        StrengthValue.Text = Convert.ToString(str);
                        spend++;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(Convert.ToString(ee));
            }
        }

        private void StrPlus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(StrengthValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str >= 14 && str < 17)
                {
                    if (spend <= 2)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        StrengthValue.Text = Convert.ToString(str);
                        spend = spend - 3;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
                else if (str >= 12 && str < 14)
                {
                    if (spend <= 1)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        StrengthValue.Text = Convert.ToString(str);
                        spend = spend - 2;
                        SpendValue.Text = Convert.ToString(spend);
                    }

                }
                else if (str < 12)
                {
                        if (spend == 0)
                        {
                            MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                        }
                        else
                        {
                            str = str + 1;
                            StrengthValue.Text = Convert.ToString(str);
                            spend--;
                            SpendValue.Text = Convert.ToString(spend);
                        }
                }
            }
            catch(Exception yee)
            {
                MessageBox.Show(Convert.ToString(yee));
            }
        }

        //Dexterity controls.
        private void DexMinus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(DexterityValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str > 14 && str <= 17)
                {
                    str = str - 1;
                    DexterityValue.Text = Convert.ToString(str);
                    spend = spend + 3;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str > 12 && str <= 14)
                {
                    str = str - 1;
                    DexterityValue.Text = Convert.ToString(str);
                    spend = spend + 2;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str <= 12)
                {
                    if (str == 0)
                    {
                        MessageBox.Show("Strength values must not go below 0!");
                    }
                    else
                    {
                        str = str - 1;
                        DexterityValue.Text = Convert.ToString(str);
                        spend++;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(Convert.ToString(ee));
            }
        }

        private void DexPlus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(DexterityValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str >= 14 && str < 17)
                {
                    if (spend <= 2)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        DexterityValue.Text = Convert.ToString(str);
                        spend = spend - 3;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
                else if (str >= 12 && str < 14)
                {
                    if (spend <= 1)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        DexterityValue.Text = Convert.ToString(str);
                        spend = spend - 2;
                        SpendValue.Text = Convert.ToString(spend);
                    }

                }
                else if (str < 12)
                {
                    if (spend == 0)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        DexterityValue.Text = Convert.ToString(str);
                        spend--;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception yee)
            {
                MessageBox.Show(Convert.ToString(yee));
            }
        }

        private void ConstMinus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(ConstitutionValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str > 14 && str <= 17)
                {
                    str = str - 1;
                    ConstitutionValue.Text = Convert.ToString(str);
                    spend = spend + 3;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str > 12 && str <= 14)
                {
                    str = str - 1;
                    ConstitutionValue.Text = Convert.ToString(str);
                    spend = spend + 2;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str <= 12)
                {
                    if (str == 0)
                    {
                        MessageBox.Show("Strength values must not go below 0!");
                    }
                    else
                    {
                        str = str - 1;
                        ConstitutionValue.Text = Convert.ToString(str);
                        spend++;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(Convert.ToString(ee));
            }
        }

        private void ConstPlus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(ConstitutionValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str >= 14 && str < 17)
                {
                    if (spend <= 2)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        ConstitutionValue.Text = Convert.ToString(str);
                        spend = spend - 3;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
                else if (str >= 12 && str < 14)
                {
                    if (spend <= 1)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        ConstitutionValue.Text = Convert.ToString(str);
                        spend = spend - 2;
                        SpendValue.Text = Convert.ToString(spend);
                    }

                }
                else if (str < 12)
                {
                    if (spend == 0)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        ConstitutionValue.Text = Convert.ToString(str);
                        spend--;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception yee)
            {
                MessageBox.Show(Convert.ToString(yee));
            }
        }

        private void InteMinus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(IntelligenceValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str > 14 && str <= 17)
                {
                    str = str - 1;
                    IntelligenceValue.Text = Convert.ToString(str);
                    spend = spend + 3;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str > 12 && str <= 14)
                {
                    str = str - 1;
                    IntelligenceValue.Text = Convert.ToString(str);
                    spend = spend + 2;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str <= 12)
                {
                    if (str == 0)
                    {
                        MessageBox.Show("Strength values must not go below 0!");
                    }
                    else
                    {
                        str = str - 1;
                        IntelligenceValue.Text = Convert.ToString(str);
                        spend++;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(Convert.ToString(ee));
            }
        }

        private void IntePlus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(IntelligenceValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str >= 14 && str < 17)
                {
                    if (spend <= 2)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        IntelligenceValue.Text = Convert.ToString(str);
                        spend = spend - 3;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
                else if (str >= 12 && str < 14)
                {
                    if (spend <= 1)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        IntelligenceValue.Text = Convert.ToString(str);
                        spend = spend - 2;
                        SpendValue.Text = Convert.ToString(spend);
                    }

                }
                else if (str < 12)
                {
                    if (spend == 0)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        IntelligenceValue.Text = Convert.ToString(str);
                        spend--;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception yee)
            {
                MessageBox.Show(Convert.ToString(yee));
            }
        }

        private void WisMinus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(WisdomValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str > 14 && str <= 17)
                {
                    str = str - 1;
                    WisdomValue.Text = Convert.ToString(str);
                    spend = spend + 3;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str > 12 && str <= 14)
                {
                    str = str - 1;
                    WisdomValue.Text = Convert.ToString(str);
                    spend = spend + 2;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str <= 12)
                {
                    if (str == 0)
                    {
                        MessageBox.Show("Strength values must not go below 0!");
                    }
                    else
                    {
                        str = str - 1;
                        WisdomValue.Text = Convert.ToString(str);
                        spend++;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(Convert.ToString(ee));
            }
        }

        private void WisPlus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(WisdomValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str >= 14 && str < 17)
                {
                    if (spend <= 2)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        WisdomValue.Text = Convert.ToString(str);
                        spend = spend - 3;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
                else if (str >= 12 && str < 14)
                {
                    if (spend <= 1)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        WisdomValue.Text = Convert.ToString(str);
                        spend = spend - 2;
                        SpendValue.Text = Convert.ToString(spend);
                    }

                }
                else if (str < 12)
                {
                    if (spend == 0)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        WisdomValue.Text = Convert.ToString(str);
                        spend--;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception yee)
            {
                MessageBox.Show(Convert.ToString(yee));
            }
        }

        private void CharMinus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(CharismaValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str > 14 && str <= 17)
                {
                    str = str - 1;
                    CharismaValue.Text = Convert.ToString(str);
                    spend = spend + 3;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str > 12 && str <= 14)
                {
                    str = str - 1;
                    CharismaValue.Text = Convert.ToString(str);
                    spend = spend + 2;
                    SpendValue.Text = Convert.ToString(spend);
                }
                else if (str <= 12)
                {
                    if (str == 0)
                    {
                        MessageBox.Show("Strength values must not go below 0!");
                    }
                    else
                    {
                        str = str - 1;
                        CharismaValue.Text = Convert.ToString(str);
                        spend++;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(Convert.ToString(ee));
            }
        }

        private void CharPlus_Click(object sender, EventArgs e)
        {
            int str = Convert.ToInt32(CharismaValue.Text);
            int spend = Convert.ToInt32(SpendValue.Text);
            try
            {
                if (str >= 14 && str < 17)
                {
                    if (spend <= 2)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        CharismaValue.Text = Convert.ToString(str);
                        spend = spend - 3;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
                else if (str >= 12 && str < 14)
                {
                    if (spend <= 1)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        CharismaValue.Text = Convert.ToString(str);
                        spend = spend - 2;
                        SpendValue.Text = Convert.ToString(spend);
                    }

                }
                else if (str < 12)
                {
                    if (spend == 0)
                    {
                        MessageBox.Show("You do not have enough points to spend! Reallocate points and try again.");
                    }
                    else
                    {
                        str = str + 1;
                        CharismaValue.Text = Convert.ToString(str);
                        spend--;
                        SpendValue.Text = Convert.ToString(spend);
                    }
                }
            }
            catch (Exception yee)
            {
                MessageBox.Show(Convert.ToString(yee));
            }
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetSkills_Click(object sender, EventArgs e)
        {

            RaceSelectBox.Text = " ";
            StrengthValue.Text = "0";
            DexterityValue.Text = "0";
            ConstitutionValue.Text = "0";
            IntelligenceValue.Text = "0";
            WisdomValue.Text = "0";
            CharismaValue.Text = "0";
            SpendValue.Text = "10";
        }

        private void SaveChar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=characters.db;Version=3;Compress=True");
                conn.Open();
                SQLiteCommand saveChar = conn.CreateCommand();
                saveChar.CommandText = "INSERT INTO saved_characters4(NAME, RACE, STRENGTH, DEXTERITY, CONSTITUTION, INTELLIGENCE, WISDOM, CHARISMA, LEVEL, EXPERIENCE, EXPERIENCENEXT, SPEND)" +
                    " VALUES(@NAME, @RACE, @STRENGTH, @DEXTERITY, @CONSTITUTION, @INTELLIGENCE, @WISDOM, @CHARISMA, @LEVEL, @EXPERIENCE, @EXPERIENCENEXT, @SPEND);";
                saveChar.Parameters.AddWithValue("@NAME", CharName.Text);
                saveChar.Parameters.AddWithValue("@RACE", RaceSelectBox.Text);
                saveChar.Parameters.AddWithValue("@STRENGTH", Convert.ToInt32(StrengthValue.Text));
                saveChar.Parameters.AddWithValue("@DEXTERITY", Convert.ToInt32(DexterityValue.Text));
                saveChar.Parameters.AddWithValue("@CONSTITUTION", Convert.ToInt32(ConstitutionValue.Text));
                saveChar.Parameters.AddWithValue("@INTELLIGENCE", Convert.ToInt32(IntelligenceValue.Text));
                saveChar.Parameters.AddWithValue("@WISDOM", Convert.ToInt32(WisdomValue.Text));
                saveChar.Parameters.AddWithValue("@CHARISMA", Convert.ToInt32(CharismaValue.Text));
                saveChar.Parameters.AddWithValue("@LEVEL", Convert.ToInt32(1));
                saveChar.Parameters.AddWithValue("@EXPERIENCE", Convert.ToInt32(0));
                saveChar.Parameters.AddWithValue("@EXPERIENCENEXT", Convert.ToInt32(100));
                saveChar.Parameters.AddWithValue("@SPEND", Convert.ToInt32(0));
                saveChar.Prepare();
                saveChar.ExecuteNonQuery();

                MessageBox.Show("Your Character has been saved successfully!");

                conn.Close();
            }
            catch(SQLiteException SQLex)
            {
                MessageBox.Show(Convert.ToString(SQLex));
            }
        }
    }
}
