
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Play = new System.Windows.Forms.Label();
            this.CharSelectPanel = new System.Windows.Forms.Panel();
            this.charData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelCharButton = new System.Windows.Forms.Button();
            this.ShowCharsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.Label();
            this.Dexterity = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this.Intelligence = new System.Windows.Forms.Label();
            this.Wisdom = new System.Windows.Forms.Label();
            this.Charisma = new System.Windows.Forms.Label();
            this.LevelBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.RaceBox = new System.Windows.Forms.TextBox();
            this.StrengthBox = new System.Windows.Forms.TextBox();
            this.DexterityBox = new System.Windows.Forms.TextBox();
            this.ConstitutionBox = new System.Windows.Forms.TextBox();
            this.IntelligenceBox = new System.Windows.Forms.TextBox();
            this.WisdomBox = new System.Windows.Forms.TextBox();
            this.CharismaBox = new System.Windows.Forms.TextBox();
            this.DicePanel = new System.Windows.Forms.Panel();
            this.SaveProgress = new System.Windows.Forms.Button();
            this.SpendablePts = new System.Windows.Forms.Label();
            this.SpendBox = new System.Windows.Forms.TextBox();
            this.SpendButton = new System.Windows.Forms.Button();
            this.ExpAdd = new System.Windows.Forms.Label();
            this.ExpAddBox = new System.Windows.Forms.TextBox();
            this.AddEXPBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Divider = new System.Windows.Forms.Label();
            this.TotalNeeded = new System.Windows.Forms.Label();
            this.TotalXp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.CharSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charData)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 15;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.70746F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.48566F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Controls.Add(this.TitlePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CharSelectPanel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SelCharButton, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.ShowCharsBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.624278F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.009634F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.660886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.358381F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TitlePanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TitlePanel, 15);
            this.TitlePanel.Controls.Add(this.Play);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitlePanel.Location = new System.Drawing.Point(3, 3);
            this.TitlePanel.Name = "TitlePanel";
            this.tableLayoutPanel1.SetRowSpan(this.TitlePanel, 2);
            this.TitlePanel.Size = new System.Drawing.Size(1040, 46);
            this.TitlePanel.TabIndex = 0;
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(359, 9);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(325, 27);
            this.Play.TabIndex = 0;
            this.Play.Text = "Select a Character and Play";
            // 
            // CharSelectPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CharSelectPanel, 3);
            this.CharSelectPanel.Controls.Add(this.charData);
            this.CharSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharSelectPanel.Location = new System.Drawing.Point(3, 131);
            this.CharSelectPanel.Name = "CharSelectPanel";
            this.tableLayoutPanel1.SetRowSpan(this.CharSelectPanel, 10);
            this.CharSelectPanel.Size = new System.Drawing.Size(244, 254);
            this.CharSelectPanel.TabIndex = 1;
            // 
            // charData
            // 
            this.charData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.charData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.RACE,
            this.Level});
            this.charData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charData.Location = new System.Drawing.Point(0, 0);
            this.charData.Name = "charData";
            this.charData.Size = new System.Drawing.Size(244, 254);
            this.charData.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // RACE
            // 
            this.RACE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RACE.HeaderText = "RACE";
            this.RACE.Name = "RACE";
            this.RACE.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Level.HeaderText = "LvL";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // SelCharButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SelCharButton, 3);
            this.SelCharButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelCharButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelCharButton.Location = new System.Drawing.Point(3, 391);
            this.SelCharButton.Name = "SelCharButton";
            this.tableLayoutPanel1.SetRowSpan(this.SelCharButton, 2);
            this.SelCharButton.Size = new System.Drawing.Size(244, 46);
            this.SelCharButton.TabIndex = 2;
            this.SelCharButton.Text = "Select Character";
            this.SelCharButton.UseVisualStyleBackColor = true;
            this.SelCharButton.Click += new System.EventHandler(this.SelCharButton_Click);
            // 
            // ShowCharsBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ShowCharsBtn, 3);
            this.ShowCharsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowCharsBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCharsBtn.Location = new System.Drawing.Point(3, 81);
            this.ShowCharsBtn.Name = "ShowCharsBtn";
            this.tableLayoutPanel1.SetRowSpan(this.ShowCharsBtn, 2);
            this.ShowCharsBtn.Size = new System.Drawing.Size(244, 44);
            this.ShowCharsBtn.TabIndex = 3;
            this.ShowCharsBtn.Text = "Show Characters";
            this.ShowCharsBtn.UseVisualStyleBackColor = true;
            this.ShowCharsBtn.Click += new System.EventHandler(this.ShowCharsBtn_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 10);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(279, 81);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 14);
            this.panel1.Size = new System.Drawing.Size(684, 356);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.35777F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.677419F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.315789F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.90643F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.169591F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.35777F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.502924F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.187135F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.309941F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.35777F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.35777F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.35777F));
            this.tableLayoutPanel2.Controls.Add(this.LevelLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExpLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.NameLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Strength, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.SpendBox, 7, 12);
            this.tableLayoutPanel2.Controls.Add(this.Dexterity, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.Constitution, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.Intelligence, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.Wisdom, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.Charisma, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.LevelBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.NameBox, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.RaceBox, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.StrengthBox, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.DexterityBox, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.ConstitutionBox, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.IntelligenceBox, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.WisdomBox, 3, 9);
            this.tableLayoutPanel2.Controls.Add(this.CharismaBox, 3, 10);
            this.tableLayoutPanel2.Controls.Add(this.DicePanel, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.SaveProgress, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.SpendablePts, 5, 12);
            this.tableLayoutPanel2.Controls.Add(this.SpendButton, 8, 12);
            this.tableLayoutPanel2.Controls.Add(this.ExpAdd, 5, 13);
            this.tableLayoutPanel2.Controls.Add(this.ExpAddBox, 7, 13);
            this.tableLayoutPanel2.Controls.Add(this.AddEXPBtn, 8, 13);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 14;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.976744F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.976744F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.686047F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.72093F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.72093F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(684, 356);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LevelLabel
            // 
            this.LevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LevelLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.LevelLabel, 2);
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LevelLabel.Location = new System.Drawing.Point(3, 27);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(111, 18);
            this.LevelLabel.TabIndex = 0;
            this.LevelLabel.Text = "Character Level";
            // 
            // ExpLabel
            // 
            this.ExpLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExpLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.ExpLabel, 2);
            this.ExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpLabel.Location = new System.Drawing.Point(3, 51);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(102, 18);
            this.ExpLabel.TabIndex = 1;
            this.ExpLabel.Text = "Character Exp";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.NameLabel, 2);
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameLabel.Location = new System.Drawing.Point(3, 75);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(117, 18);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Character Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Character Race";
            // 
            // Strength
            // 
            this.Strength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Strength.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Strength, 2);
            this.Strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Strength.Location = new System.Drawing.Point(3, 123);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(63, 18);
            this.Strength.TabIndex = 4;
            this.Strength.Text = "Strength";
            // 
            // Dexterity
            // 
            this.Dexterity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Dexterity.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Dexterity, 2);
            this.Dexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dexterity.Location = new System.Drawing.Point(3, 147);
            this.Dexterity.Name = "Dexterity";
            this.Dexterity.Size = new System.Drawing.Size(65, 18);
            this.Dexterity.TabIndex = 5;
            this.Dexterity.Text = "Dexterity";
            // 
            // Constitution
            // 
            this.Constitution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Constitution.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Constitution, 2);
            this.Constitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Constitution.Location = new System.Drawing.Point(3, 171);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(87, 18);
            this.Constitution.TabIndex = 6;
            this.Constitution.Text = "Constitution";
            // 
            // Intelligence
            // 
            this.Intelligence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Intelligence.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Intelligence, 2);
            this.Intelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Intelligence.Location = new System.Drawing.Point(3, 195);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(80, 18);
            this.Intelligence.TabIndex = 7;
            this.Intelligence.Text = "Intelligence";
            // 
            // Wisdom
            // 
            this.Wisdom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Wisdom.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Wisdom, 2);
            this.Wisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Wisdom.Location = new System.Drawing.Point(3, 219);
            this.Wisdom.Name = "Wisdom";
            this.Wisdom.Size = new System.Drawing.Size(64, 18);
            this.Wisdom.TabIndex = 8;
            this.Wisdom.Text = "Wisdom";
            // 
            // Charisma
            // 
            this.Charisma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Charisma.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Charisma, 2);
            this.Charisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Charisma.Location = new System.Drawing.Point(3, 243);
            this.Charisma.Name = "Charisma";
            this.Charisma.Size = new System.Drawing.Size(72, 18);
            this.Charisma.TabIndex = 9;
            this.Charisma.Text = "Charisma";
            // 
            // LevelBox
            // 
            this.LevelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LevelBox.Location = new System.Drawing.Point(135, 27);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.ReadOnly = true;
            this.LevelBox.Size = new System.Drawing.Size(137, 22);
            this.LevelBox.TabIndex = 10;
            this.LevelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameBox
            // 
            this.NameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameBox.Location = new System.Drawing.Point(135, 75);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(137, 22);
            this.NameBox.TabIndex = 11;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RaceBox
            // 
            this.RaceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RaceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RaceBox.Location = new System.Drawing.Point(135, 99);
            this.RaceBox.Name = "RaceBox";
            this.RaceBox.ReadOnly = true;
            this.RaceBox.Size = new System.Drawing.Size(137, 22);
            this.RaceBox.TabIndex = 12;
            this.RaceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StrengthBox
            // 
            this.StrengthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StrengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StrengthBox.Location = new System.Drawing.Point(135, 123);
            this.StrengthBox.Name = "StrengthBox";
            this.StrengthBox.ReadOnly = true;
            this.StrengthBox.Size = new System.Drawing.Size(137, 22);
            this.StrengthBox.TabIndex = 13;
            this.StrengthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DexterityBox
            // 
            this.DexterityBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DexterityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DexterityBox.Location = new System.Drawing.Point(135, 147);
            this.DexterityBox.Name = "DexterityBox";
            this.DexterityBox.ReadOnly = true;
            this.DexterityBox.Size = new System.Drawing.Size(137, 22);
            this.DexterityBox.TabIndex = 14;
            this.DexterityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConstitutionBox
            // 
            this.ConstitutionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConstitutionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConstitutionBox.Location = new System.Drawing.Point(135, 171);
            this.ConstitutionBox.Name = "ConstitutionBox";
            this.ConstitutionBox.ReadOnly = true;
            this.ConstitutionBox.Size = new System.Drawing.Size(137, 22);
            this.ConstitutionBox.TabIndex = 15;
            this.ConstitutionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntelligenceBox
            // 
            this.IntelligenceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntelligenceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IntelligenceBox.Location = new System.Drawing.Point(135, 195);
            this.IntelligenceBox.Name = "IntelligenceBox";
            this.IntelligenceBox.ReadOnly = true;
            this.IntelligenceBox.Size = new System.Drawing.Size(137, 22);
            this.IntelligenceBox.TabIndex = 16;
            this.IntelligenceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WisdomBox
            // 
            this.WisdomBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WisdomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WisdomBox.Location = new System.Drawing.Point(135, 219);
            this.WisdomBox.Name = "WisdomBox";
            this.WisdomBox.ReadOnly = true;
            this.WisdomBox.Size = new System.Drawing.Size(137, 22);
            this.WisdomBox.TabIndex = 17;
            this.WisdomBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CharismaBox
            // 
            this.CharismaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharismaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CharismaBox.Location = new System.Drawing.Point(135, 243);
            this.CharismaBox.Name = "CharismaBox";
            this.CharismaBox.ReadOnly = true;
            this.CharismaBox.Size = new System.Drawing.Size(137, 22);
            this.CharismaBox.TabIndex = 18;
            this.CharismaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DicePanel
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.DicePanel, 7);
            this.DicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DicePanel.Location = new System.Drawing.Point(286, 51);
            this.DicePanel.Name = "DicePanel";
            this.tableLayoutPanel2.SetRowSpan(this.DicePanel, 10);
            this.DicePanel.Size = new System.Drawing.Size(395, 233);
            this.DicePanel.TabIndex = 20;
            // 
            // SaveProgress
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.SaveProgress, 2);
            this.SaveProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SaveProgress.Location = new System.Drawing.Point(3, 290);
            this.SaveProgress.Name = "SaveProgress";
            this.SaveProgress.Size = new System.Drawing.Size(117, 24);
            this.SaveProgress.TabIndex = 21;
            this.SaveProgress.Text = "Save Progress";
            this.SaveProgress.UseVisualStyleBackColor = true;
            this.SaveProgress.Click += new System.EventHandler(this.SaveProgress_Click);
            // 
            // SpendablePts
            // 
            this.SpendablePts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpendablePts.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.SpendablePts, 2);
            this.SpendablePts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SpendablePts.Location = new System.Drawing.Point(286, 294);
            this.SpendablePts.Name = "SpendablePts";
            this.SpendablePts.Size = new System.Drawing.Size(114, 16);
            this.SpendablePts.TabIndex = 22;
            this.SpendablePts.Text = "Spendable Points";
            // 
            // SpendBox
            // 
            this.SpendBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpendBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SpendBox.Location = new System.Drawing.Point(408, 291);
            this.SpendBox.Name = "SpendBox";
            this.SpendBox.ReadOnly = true;
            this.SpendBox.Size = new System.Drawing.Size(50, 22);
            this.SpendBox.TabIndex = 23;
            this.SpendBox.Text = "0";
            this.SpendBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpendButton
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.SpendButton, 2);
            this.SpendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SpendButton.Location = new System.Drawing.Point(464, 290);
            this.SpendButton.Name = "SpendButton";
            this.SpendButton.Size = new System.Drawing.Size(101, 24);
            this.SpendButton.TabIndex = 24;
            this.SpendButton.Text = "Spend Points!";
            this.SpendButton.UseVisualStyleBackColor = true;
            // 
            // ExpAdd
            // 
            this.ExpAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExpAdd.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.ExpAdd, 2);
            this.ExpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpAdd.Location = new System.Drawing.Point(286, 328);
            this.ExpAdd.Name = "ExpAdd";
            this.ExpAdd.Size = new System.Drawing.Size(101, 16);
            this.ExpAdd.TabIndex = 25;
            this.ExpAdd.Text = "Add EXP Points";
            // 
            // ExpAddBox
            // 
            this.ExpAddBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExpAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpAddBox.Location = new System.Drawing.Point(408, 325);
            this.ExpAddBox.Name = "ExpAddBox";
            this.ExpAddBox.Size = new System.Drawing.Size(50, 22);
            this.ExpAddBox.TabIndex = 26;
            this.ExpAddBox.Text = "0";
            this.ExpAddBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddEXPBtn
            // 
            this.AddEXPBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.SetColumnSpan(this.AddEXPBtn, 2);
            this.AddEXPBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddEXPBtn.Location = new System.Drawing.Point(464, 322);
            this.AddEXPBtn.Name = "AddEXPBtn";
            this.AddEXPBtn.Size = new System.Drawing.Size(101, 28);
            this.AddEXPBtn.TabIndex = 28;
            this.AddEXPBtn.Text = "Add ( + )";
            this.AddEXPBtn.UseVisualStyleBackColor = true;
            this.AddEXPBtn.Click += new System.EventHandler(this.AddEXPBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.60584F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.9489F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17518F));
            this.tableLayoutPanel3.Controls.Add(this.Divider, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TotalNeeded, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TotalXp, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(135, 51);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(137, 18);
            this.tableLayoutPanel3.TabIndex = 29;
            // 
            // Divider
            // 
            this.Divider.AutoSize = true;
            this.Divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divider.Location = new System.Drawing.Point(59, 0);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(8, 15);
            this.Divider.TabIndex = 1;
            this.Divider.Text = "/";
            // 
            // TotalNeeded
            // 
            this.TotalNeeded.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalNeeded.AutoSize = true;
            this.TotalNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalNeeded.Location = new System.Drawing.Point(73, 1);
            this.TotalNeeded.Name = "TotalNeeded";
            this.TotalNeeded.Size = new System.Drawing.Size(28, 15);
            this.TotalNeeded.TabIndex = 2;
            this.TotalNeeded.Text = "100";
            // 
            // TotalXp
            // 
            this.TotalXp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalXp.AutoSize = true;
            this.TotalXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalXp.Location = new System.Drawing.Point(39, 1);
            this.TotalXp.Name = "TotalXp";
            this.TotalXp.Size = new System.Drawing.Size(14, 15);
            this.TotalXp.TabIndex = 0;
            this.TotalXp.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Select and Play";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.CharSelectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label Play;
        private System.Windows.Forms.Panel CharSelectPanel;
        private System.Windows.Forms.DataGridView charData;
        private System.Windows.Forms.Button SelCharButton;
        private System.Windows.Forms.Button ShowCharsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label Dexterity;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label Intelligence;
        private System.Windows.Forms.Label Wisdom;
        private System.Windows.Forms.Label Charisma;
        private System.Windows.Forms.TextBox LevelBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox RaceBox;
        private System.Windows.Forms.TextBox StrengthBox;
        private System.Windows.Forms.TextBox DexterityBox;
        private System.Windows.Forms.TextBox ConstitutionBox;
        private System.Windows.Forms.TextBox IntelligenceBox;
        private System.Windows.Forms.TextBox WisdomBox;
        private System.Windows.Forms.TextBox CharismaBox;
        private System.Windows.Forms.Panel DicePanel;
        private System.Windows.Forms.Button SaveProgress;
        private System.Windows.Forms.Label SpendablePts;
        private System.Windows.Forms.TextBox SpendBox;
        private System.Windows.Forms.Button SpendButton;
        private System.Windows.Forms.Label ExpAdd;
        private System.Windows.Forms.TextBox ExpAddBox;
        private System.Windows.Forms.Button AddEXPBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn RACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label TotalXp;
        private System.Windows.Forms.Label Divider;
        private System.Windows.Forms.Label TotalNeeded;
    }
}

