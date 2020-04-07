namespace OAnQuan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanelPlayer0 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanelPlayer1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanelBoard = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelGameControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGoOrNew = new System.Windows.Forms.Button();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.labelGameState = new System.Windows.Forms.Label();
            this.tableLayoutPanelGameStatus = new System.Windows.Forms.TableLayoutPanel();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelStonesInHand = new System.Windows.Forms.Label();
            this.timerScatter = new System.Windows.Forms.Timer(this.components);
            this.timerRefill = new System.Windows.Forms.Timer(this.components);
            this.timerFinalCollect = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelLeftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBoardContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.timerDelayComputerMove = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelPlayer0.SuspendLayout();
            this.tableLayoutPanelPlayer1.SuspendLayout();
            this.tableLayoutPanelBoard.SuspendLayout();
            this.tableLayoutPanelRightPanel.SuspendLayout();
            this.tableLayoutPanelGameControlButtons.SuspendLayout();
            this.tableLayoutPanelGameStatus.SuspendLayout();
            this.tableLayoutPanelLeftPanel.SuspendLayout();
            this.tableLayoutPanelBoardContainer.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.tableLayoutPanelBoard.SetRowSpan(this.button1, 2);
            this.button1.Size = new System.Drawing.Size(76, 174);
            this.button1.TabIndex = 0;
            this.button1.Text = "•";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(82, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "⁙";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(161, 91);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 86);
            this.button3.TabIndex = 2;
            this.button3.Text = "⁙";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(240, 91);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 86);
            this.button4.TabIndex = 3;
            this.button4.Text = "⁙";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(319, 91);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 86);
            this.button5.TabIndex = 4;
            this.button5.Text = "⁙";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(398, 91);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 86);
            this.button6.TabIndex = 5;
            this.button6.Text = "⁙";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(477, 3);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.tableLayoutPanelBoard.SetRowSpan(this.button7, 2);
            this.button7.Size = new System.Drawing.Size(80, 174);
            this.button7.TabIndex = 6;
            this.button7.Text = "•";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(398, 3);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 85);
            this.button8.TabIndex = 7;
            this.button8.Text = "⁙";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(319, 3);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 85);
            this.button9.TabIndex = 8;
            this.button9.Text = "⁙";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(240, 3);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 85);
            this.button10.TabIndex = 9;
            this.button10.Text = "⁙";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(161, 3);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(76, 85);
            this.button11.TabIndex = 10;
            this.button11.Text = "⁙";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(82, 3);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(76, 85);
            this.button12.TabIndex = 11;
            this.button12.Text = "⁙";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.boardCell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanelPlayer0.SetColumnSpan(this.label1, 3);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bên Xanh đã gom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dân:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(4, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quan:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng lực:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // tableLayoutPanelPlayer0
            // 
            this.tableLayoutPanelPlayer0.AutoSize = true;
            this.tableLayoutPanelPlayer0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelPlayer0.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanelPlayer0.ColumnCount = 3;
            this.tableLayoutPanelPlayer0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPlayer0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPlayer0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPlayer0.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelPlayer0.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelPlayer0.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanelPlayer0.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanelPlayer0.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanelPlayer0.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanelPlayer0.Controls.Add(this.label22, 1, 1);
            this.tableLayoutPanelPlayer0.Controls.Add(this.label23, 1, 2);
            this.tableLayoutPanelPlayer0.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanelPlayer0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPlayer0.Location = new System.Drawing.Point(164, 331);
            this.tableLayoutPanelPlayer0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelPlayer0.Name = "tableLayoutPanelPlayer0";
            this.tableLayoutPanelPlayer0.RowCount = 4;
            this.tableLayoutPanelPlayer0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayer0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayer0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayer0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayer0.Size = new System.Drawing.Size(247, 114);
            this.tableLayoutPanelPlayer0.TabIndex = 19;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Left;
            this.label22.Location = new System.Drawing.Point(81, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 37);
            this.label22.TabIndex = 19;
            this.label22.Text = "label22";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Left;
            this.label23.Location = new System.Drawing.Point(81, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 37);
            this.label23.TabIndex = 20;
            this.label23.Text = "label23";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanelPlayer1
            // 
            this.tableLayoutPanelPlayer1.AutoSize = true;
            this.tableLayoutPanelPlayer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelPlayer1.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanelPlayer1.ColumnCount = 3;
            this.tableLayoutPanelPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPlayer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.68674F));
            this.tableLayoutPanelPlayer1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanelPlayer1.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanelPlayer1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanelPlayer1.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanelPlayer1.Controls.Add(this.label13, 2, 2);
            this.tableLayoutPanelPlayer1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanelPlayer1.Controls.Add(this.label20, 1, 1);
            this.tableLayoutPanelPlayer1.Controls.Add(this.label21, 1, 2);
            this.tableLayoutPanelPlayer1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanelPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPlayer1.Location = new System.Drawing.Point(164, 5);
            this.tableLayoutPanelPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelPlayer1.Name = "tableLayoutPanelPlayer1";
            this.tableLayoutPanelPlayer1.RowCount = 4;
            this.tableLayoutPanelPlayer1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayer1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayer1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayer1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPlayer1.Size = new System.Drawing.Size(247, 114);
            this.tableLayoutPanelPlayer1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableLayoutPanelPlayer1.SetColumnSpan(this.label8, 3);
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bên Đỏ đã gom:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(4, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 37);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dân:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tổng lực:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(142, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 37);
            this.label12.TabIndex = 14;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(142, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 37);
            this.label13.TabIndex = 16;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(4, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 37);
            this.label14.TabIndex = 15;
            this.label14.Text = "Quan:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Left;
            this.label20.Location = new System.Drawing.Point(81, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 37);
            this.label20.TabIndex = 19;
            this.label20.Text = "label20";
            this.label20.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.label21.Location = new System.Drawing.Point(81, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 37);
            this.label21.TabIndex = 20;
            this.label21.Text = "label21";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // tableLayoutPanelBoard
            // 
            this.tableLayoutPanelBoard.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelBoard.ColumnCount = 7;
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBoard.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.button12, 1, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.button7, 6, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.button8, 5, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.button9, 4, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.button10, 3, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.button6, 5, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.button11, 2, 0);
            this.tableLayoutPanelBoard.Controls.Add(this.button5, 4, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanelBoard.Controls.Add(this.button4, 3, 1);
            this.tableLayoutPanelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBoard.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelBoard.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanelBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelBoard.Name = "tableLayoutPanelBoard";
            this.tableLayoutPanelBoard.RowCount = 2;
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoard.Size = new System.Drawing.Size(560, 180);
            this.tableLayoutPanelBoard.TabIndex = 21;
            // 
            // tableLayoutPanelRightPanel
            // 
            this.tableLayoutPanelRightPanel.AutoSize = true;
            this.tableLayoutPanelRightPanel.ColumnCount = 1;
            this.tableLayoutPanelRightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRightPanel.Controls.Add(this.tableLayoutPanelGameControlButtons, 0, 3);
            this.tableLayoutPanelRightPanel.Controls.Add(this.labelGameState, 0, 1);
            this.tableLayoutPanelRightPanel.Controls.Add(this.tableLayoutPanelGameStatus, 0, 2);
            this.tableLayoutPanelRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRightPanel.Location = new System.Drawing.Point(591, 7);
            this.tableLayoutPanelRightPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelRightPanel.Name = "tableLayoutPanelRightPanel";
            this.tableLayoutPanelRightPanel.RowCount = 5;
            this.tableLayoutPanelRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRightPanel.Size = new System.Drawing.Size(363, 450);
            this.tableLayoutPanelRightPanel.TabIndex = 24;
            // 
            // tableLayoutPanelGameControlButtons
            // 
            this.tableLayoutPanelGameControlButtons.AutoSize = true;
            this.tableLayoutPanelGameControlButtons.ColumnCount = 2;
            this.tableLayoutPanelGameControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGameControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGameControlButtons.Controls.Add(this.buttonGoOrNew, 0, 0);
            this.tableLayoutPanelGameControlButtons.Controls.Add(this.buttonRefill, 1, 0);
            this.tableLayoutPanelGameControlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelGameControlButtons.Location = new System.Drawing.Point(3, 273);
            this.tableLayoutPanelGameControlButtons.Name = "tableLayoutPanelGameControlButtons";
            this.tableLayoutPanelGameControlButtons.RowCount = 1;
            this.tableLayoutPanelGameControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGameControlButtons.Size = new System.Drawing.Size(357, 40);
            this.tableLayoutPanelGameControlButtons.TabIndex = 31;
            // 
            // buttonGoOrNew
            // 
            this.buttonGoOrNew.AutoSize = true;
            this.buttonGoOrNew.Location = new System.Drawing.Point(4, 5);
            this.buttonGoOrNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGoOrNew.Name = "buttonGoOrNew";
            this.buttonGoOrNew.Size = new System.Drawing.Size(89, 30);
            this.buttonGoOrNew.TabIndex = 25;
            this.buttonGoOrNew.Text = "Điều Quân";
            this.buttonGoOrNew.UseVisualStyleBackColor = true;
            this.buttonGoOrNew.Click += new System.EventHandler(this.buttonGoOrNew_Click);
            // 
            // buttonRefill
            // 
            this.buttonRefill.AutoSize = true;
            this.buttonRefill.Location = new System.Drawing.Point(101, 5);
            this.buttonRefill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(105, 30);
            this.buttonRefill.TabIndex = 28;
            this.buttonRefill.Text = "Đặt Lại Quân";
            this.buttonRefill.UseVisualStyleBackColor = true;
            this.buttonRefill.Visible = false;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click_1);
            // 
            // labelGameState
            // 
            this.labelGameState.AutoSize = true;
            this.labelGameState.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameState.Location = new System.Drawing.Point(4, 134);
            this.labelGameState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGameState.Name = "labelGameState";
            this.labelGameState.Size = new System.Drawing.Size(79, 30);
            this.labelGameState.TabIndex = 25;
            this.labelGameState.Text = "label18";
            // 
            // tableLayoutPanelGameStatus
            // 
            this.tableLayoutPanelGameStatus.AutoSize = true;
            this.tableLayoutPanelGameStatus.ColumnCount = 2;
            this.tableLayoutPanelGameStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGameStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGameStatus.Controls.Add(this.labelInstruction, 0, 0);
            this.tableLayoutPanelGameStatus.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanelGameStatus.Controls.Add(this.labelStonesInHand, 1, 1);
            this.tableLayoutPanelGameStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGameStatus.Location = new System.Drawing.Point(3, 167);
            this.tableLayoutPanelGameStatus.Name = "tableLayoutPanelGameStatus";
            this.tableLayoutPanelGameStatus.RowCount = 2;
            this.tableLayoutPanelGameStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGameStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelGameStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelGameStatus.Size = new System.Drawing.Size(357, 100);
            this.tableLayoutPanelGameStatus.TabIndex = 30;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.tableLayoutPanelGameStatus.SetColumnSpan(this.labelInstruction, 2);
            this.labelInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInstruction.Location = new System.Drawing.Point(4, 0);
            this.labelInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstruction.MinimumSize = new System.Drawing.Size(200, 42);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(349, 80);
            this.labelInstruction.TabIndex = 27;
            this.labelInstruction.Text = "Lorem ipsum dolor sit amet, \r\nconsectetur adipiscing elit, \r\nsed do eiusmod tempo" +
    "r incididunt \r\nut labore et dolore magna aliqua.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 80);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Số quân đang điều: ";
            // 
            // labelStonesInHand
            // 
            this.labelStonesInHand.AutoSize = true;
            this.labelStonesInHand.Location = new System.Drawing.Point(153, 80);
            this.labelStonesInHand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStonesInHand.MinimumSize = new System.Drawing.Size(200, 20);
            this.labelStonesInHand.Name = "labelStonesInHand";
            this.labelStonesInHand.Size = new System.Drawing.Size(200, 20);
            this.labelStonesInHand.TabIndex = 23;
            this.labelStonesInHand.Text = "label16";
            // 
            // timerScatter
            // 
            this.timerScatter.Interval = 400;
            this.timerScatter.Tick += new System.EventHandler(this.timerScatter_Tick);
            // 
            // timerRefill
            // 
            this.timerRefill.Interval = 1000;
            this.timerRefill.Tick += new System.EventHandler(this.timerRefill_Tick);
            // 
            // timerFinalCollect
            // 
            this.timerFinalCollect.Interval = 1000;
            this.timerFinalCollect.Tick += new System.EventHandler(this.timerFinalCollect_Tick);
            // 
            // tableLayoutPanelLeftPanel
            // 
            this.tableLayoutPanelLeftPanel.AutoSize = true;
            this.tableLayoutPanelLeftPanel.ColumnCount = 3;
            this.tableLayoutPanelLeftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLeftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLeftPanel.Controls.Add(this.tableLayoutPanelBoardContainer, 0, 2);
            this.tableLayoutPanelLeftPanel.Controls.Add(this.tableLayoutPanelPlayer0, 1, 4);
            this.tableLayoutPanelLeftPanel.Controls.Add(this.tableLayoutPanelPlayer1, 1, 0);
            this.tableLayoutPanelLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftPanel.Location = new System.Drawing.Point(8, 7);
            this.tableLayoutPanelLeftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelLeftPanel.Name = "tableLayoutPanelLeftPanel";
            this.tableLayoutPanelLeftPanel.RowCount = 5;
            this.tableLayoutPanelLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLeftPanel.Size = new System.Drawing.Size(575, 450);
            this.tableLayoutPanelLeftPanel.TabIndex = 29;
            // 
            // tableLayoutPanelBoardContainer
            // 
            this.tableLayoutPanelBoardContainer.AutoSize = true;
            this.tableLayoutPanelBoardContainer.ColumnCount = 3;
            this.tableLayoutPanelLeftPanel.SetColumnSpan(this.tableLayoutPanelBoardContainer, 3);
            this.tableLayoutPanelBoardContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoardContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBoardContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBoardContainer.Controls.Add(this.tableLayoutPanelBoard, 1, 0);
            this.tableLayoutPanelBoardContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBoardContainer.Location = new System.Drawing.Point(3, 130);
            this.tableLayoutPanelBoardContainer.Name = "tableLayoutPanelBoardContainer";
            this.tableLayoutPanelBoardContainer.RowCount = 1;
            this.tableLayoutPanelBoardContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBoardContainer.Size = new System.Drawing.Size(569, 190);
            this.tableLayoutPanelBoardContainer.TabIndex = 30;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelLeftPanel, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelRightPanel, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.label17, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(962, 464);
            this.tableLayoutPanelMain.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 2);
            this.label17.TabIndex = 30;
            this.label17.Text = "label17";
            // 
            // timerDelayComputerMove
            // 
            this.timerDelayComputerMove.Enabled = true;
            this.timerDelayComputerMove.Tick += new System.EventHandler(this.timerDelayComputerMove_Tick);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanelMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(962, 464);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(962, 489);
            this.toolStripContainer1.TabIndex = 31;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(345, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 22);
            this.toolStripButton1.Text = "Đánh Trận Mới";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(115, 22);
            this.toolStripButton2.Text = "Được Ăn Quan Non";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton3.Text = "Một Người Chơi";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(962, 489);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Ô Quan | Trò Chơi Dân Gian Việt Nam";
            this.tableLayoutPanelPlayer0.ResumeLayout(false);
            this.tableLayoutPanelPlayer0.PerformLayout();
            this.tableLayoutPanelPlayer1.ResumeLayout(false);
            this.tableLayoutPanelPlayer1.PerformLayout();
            this.tableLayoutPanelBoard.ResumeLayout(false);
            this.tableLayoutPanelRightPanel.ResumeLayout(false);
            this.tableLayoutPanelRightPanel.PerformLayout();
            this.tableLayoutPanelGameControlButtons.ResumeLayout(false);
            this.tableLayoutPanelGameControlButtons.PerformLayout();
            this.tableLayoutPanelGameStatus.ResumeLayout(false);
            this.tableLayoutPanelGameStatus.PerformLayout();
            this.tableLayoutPanelLeftPanel.ResumeLayout(false);
            this.tableLayoutPanelLeftPanel.PerformLayout();
            this.tableLayoutPanelBoardContainer.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayer0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlayer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightPanel;
        private System.Windows.Forms.Label labelGameState;
        private System.Windows.Forms.Button buttonGoOrNew;
        private System.Windows.Forms.Timer timerScatter;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Timer timerRefill;
        private System.Windows.Forms.Timer timerFinalCollect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoardContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGameControlButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGameStatus;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelStonesInHand;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timerDelayComputerMove;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

