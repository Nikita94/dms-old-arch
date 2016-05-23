﻿namespace NeuroWnd
{
    partial class NeuroNetsMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuroNetsMainWindow));
            this.dgwNeuroNets = new System.Windows.Forms.DataGridView();
            this.gbNeuroNets = new System.Windows.Forms.GroupBox();
            this.lbRedactingInfo = new System.Windows.Forms.Label();
            this.gbParamsAF = new System.Windows.Forms.GroupBox();
            this.dgwParamsAF = new System.Windows.Forms.DataGridView();
            this.btnDeleteNeuroNet = new System.Windows.Forms.Button();
            this.btnChangeNeuroNet = new System.Windows.Forms.Button();
            this.gbNeuronsInLayers = new System.Windows.Forms.GroupBox();
            this.dgwNeuronsInLayers = new System.Windows.Forms.DataGridView();
            this.btnAddNeuroNet = new System.Windows.Forms.Button();
            this.tcInfoAboutNN = new System.Windows.Forms.TabControl();
            this.tpEditingNeuroNets = new System.Windows.Forms.TabPage();
            this.tpUsingNeuroNets = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEnum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbInt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUsingNeuroNets = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbLASelected = new System.Windows.Forms.Label();
            this.lbLAInfo = new System.Windows.Forms.Label();
            this.lbNetSelected = new System.Windows.Forms.Label();
            this.lbNetInfo = new System.Windows.Forms.Label();
            this.lbSelSelected = new System.Windows.Forms.Label();
            this.lbSelectionInfo = new System.Windows.Forms.Label();
            this.lbTaskSelected = new System.Windows.Forms.Label();
            this.lbTaskInfo = new System.Windows.Forms.Label();
            this.dgwLA = new System.Windows.Forms.DataGridView();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.dgwNets = new System.Windows.Forms.DataGridView();
            this.gbTasksTree = new System.Windows.Forms.GroupBox();
            this.tvTaskSelections = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNeuroNets)).BeginInit();
            this.gbNeuroNets.SuspendLayout();
            this.gbParamsAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwParamsAF)).BeginInit();
            this.gbNeuronsInLayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNeuronsInLayers)).BeginInit();
            this.tcInfoAboutNN.SuspendLayout();
            this.tpEditingNeuroNets.SuspendLayout();
            this.tpUsingNeuroNets.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbUsingNeuroNets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNets)).BeginInit();
            this.gbTasksTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwNeuroNets
            // 
            this.dgwNeuroNets.AllowUserToAddRows = false;
            this.dgwNeuroNets.AllowUserToDeleteRows = false;
            this.dgwNeuroNets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwNeuroNets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNeuroNets.Location = new System.Drawing.Point(6, 126);
            this.dgwNeuroNets.Name = "dgwNeuroNets";
            this.dgwNeuroNets.ReadOnly = true;
            this.dgwNeuroNets.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.dgwNeuroNets.Size = new System.Drawing.Size(916, 232);
            this.dgwNeuroNets.TabIndex = 0;
            this.dgwNeuroNets.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwNeuroNets_MouseUp);
            // 
            // gbNeuroNets
            // 
            this.gbNeuroNets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNeuroNets.Controls.Add(this.lbRedactingInfo);
            this.gbNeuroNets.Controls.Add(this.gbParamsAF);
            this.gbNeuroNets.Controls.Add(this.btnDeleteNeuroNet);
            this.gbNeuroNets.Controls.Add(this.btnChangeNeuroNet);
            this.gbNeuroNets.Controls.Add(this.gbNeuronsInLayers);
            this.gbNeuroNets.Controls.Add(this.btnAddNeuroNet);
            this.gbNeuroNets.Controls.Add(this.dgwNeuroNets);
            this.gbNeuroNets.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbNeuroNets.Location = new System.Drawing.Point(6, 6);
            this.gbNeuroNets.Name = "gbNeuroNets";
            this.gbNeuroNets.Size = new System.Drawing.Size(931, 581);
            this.gbNeuroNets.TabIndex = 1;
            this.gbNeuroNets.TabStop = false;
            this.gbNeuroNets.Text = "База нейронных сетей";
            // 
            // lbRedactingInfo
            // 
            this.lbRedactingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRedactingInfo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRedactingInfo.Location = new System.Drawing.Point(6, 33);
            this.lbRedactingInfo.Name = "lbRedactingInfo";
            this.lbRedactingInfo.Size = new System.Drawing.Size(916, 54);
            this.lbRedactingInfo.TabIndex = 4;
            this.lbRedactingInfo.Text = resources.GetString("lbRedactingInfo.Text");
            // 
            // gbParamsAF
            // 
            this.gbParamsAF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbParamsAF.Controls.Add(this.dgwParamsAF);
            this.gbParamsAF.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbParamsAF.Location = new System.Drawing.Point(276, 364);
            this.gbParamsAF.Name = "gbParamsAF";
            this.gbParamsAF.Size = new System.Drawing.Size(261, 211);
            this.gbParamsAF.TabIndex = 1;
            this.gbParamsAF.TabStop = false;
            this.gbParamsAF.Text = "Параметры активационной функции";
            // 
            // dgwParamsAF
            // 
            this.dgwParamsAF.AllowUserToAddRows = false;
            this.dgwParamsAF.AllowUserToDeleteRows = false;
            this.dgwParamsAF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwParamsAF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwParamsAF.Location = new System.Drawing.Point(3, 20);
            this.dgwParamsAF.Name = "dgwParamsAF";
            this.dgwParamsAF.ReadOnly = true;
            this.dgwParamsAF.Size = new System.Drawing.Size(255, 188);
            this.dgwParamsAF.TabIndex = 0;
            // 
            // btnDeleteNeuroNet
            // 
            this.btnDeleteNeuroNet.Enabled = false;
            this.btnDeleteNeuroNet.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteNeuroNet.Location = new System.Drawing.Point(274, 90);
            this.btnDeleteNeuroNet.Name = "btnDeleteNeuroNet";
            this.btnDeleteNeuroNet.Size = new System.Drawing.Size(128, 30);
            this.btnDeleteNeuroNet.TabIndex = 3;
            this.btnDeleteNeuroNet.Text = "Удалить";
            this.btnDeleteNeuroNet.UseVisualStyleBackColor = true;
            this.btnDeleteNeuroNet.Click += new System.EventHandler(this.btnDeleteNeuroNet_Click);
            // 
            // btnChangeNeuroNet
            // 
            this.btnChangeNeuroNet.Enabled = false;
            this.btnChangeNeuroNet.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeNeuroNet.Location = new System.Drawing.Point(140, 90);
            this.btnChangeNeuroNet.Name = "btnChangeNeuroNet";
            this.btnChangeNeuroNet.Size = new System.Drawing.Size(128, 30);
            this.btnChangeNeuroNet.TabIndex = 2;
            this.btnChangeNeuroNet.Text = "Изменить";
            this.btnChangeNeuroNet.UseVisualStyleBackColor = true;
            this.btnChangeNeuroNet.Click += new System.EventHandler(this.btnChangeNeuroNet_Click);
            // 
            // gbNeuronsInLayers
            // 
            this.gbNeuronsInLayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbNeuronsInLayers.Controls.Add(this.dgwNeuronsInLayers);
            this.gbNeuronsInLayers.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbNeuronsInLayers.Location = new System.Drawing.Point(6, 364);
            this.gbNeuronsInLayers.Name = "gbNeuronsInLayers";
            this.gbNeuronsInLayers.Size = new System.Drawing.Size(264, 211);
            this.gbNeuronsInLayers.TabIndex = 0;
            this.gbNeuronsInLayers.TabStop = false;
            this.gbNeuronsInLayers.Text = "Распределение нейронов по слоям";
            // 
            // dgwNeuronsInLayers
            // 
            this.dgwNeuronsInLayers.AllowUserToAddRows = false;
            this.dgwNeuronsInLayers.AllowUserToDeleteRows = false;
            this.dgwNeuronsInLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNeuronsInLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwNeuronsInLayers.Location = new System.Drawing.Point(3, 20);
            this.dgwNeuronsInLayers.Name = "dgwNeuronsInLayers";
            this.dgwNeuronsInLayers.ReadOnly = true;
            this.dgwNeuronsInLayers.Size = new System.Drawing.Size(258, 188);
            this.dgwNeuronsInLayers.TabIndex = 0;
            // 
            // btnAddNeuroNet
            // 
            this.btnAddNeuroNet.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNeuroNet.Location = new System.Drawing.Point(6, 90);
            this.btnAddNeuroNet.Name = "btnAddNeuroNet";
            this.btnAddNeuroNet.Size = new System.Drawing.Size(128, 30);
            this.btnAddNeuroNet.TabIndex = 1;
            this.btnAddNeuroNet.Text = "Добавить";
            this.btnAddNeuroNet.UseVisualStyleBackColor = true;
            this.btnAddNeuroNet.Click += new System.EventHandler(this.btnAddNeuroNet_Click);
            // 
            // tcInfoAboutNN
            // 
            this.tcInfoAboutNN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcInfoAboutNN.Controls.Add(this.tpEditingNeuroNets);
            this.tcInfoAboutNN.Controls.Add(this.tpUsingNeuroNets);
            this.tcInfoAboutNN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcInfoAboutNN.Location = new System.Drawing.Point(7, 12);
            this.tcInfoAboutNN.Name = "tcInfoAboutNN";
            this.tcInfoAboutNN.SelectedIndex = 0;
            this.tcInfoAboutNN.Size = new System.Drawing.Size(951, 626);
            this.tcInfoAboutNN.TabIndex = 4;
            // 
            // tpEditingNeuroNets
            // 
            this.tpEditingNeuroNets.Controls.Add(this.gbNeuroNets);
            this.tpEditingNeuroNets.Location = new System.Drawing.Point(4, 29);
            this.tpEditingNeuroNets.Name = "tpEditingNeuroNets";
            this.tpEditingNeuroNets.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditingNeuroNets.Size = new System.Drawing.Size(943, 593);
            this.tpEditingNeuroNets.TabIndex = 0;
            this.tpEditingNeuroNets.Text = "Редактирование нейронных сетей";
            this.tpEditingNeuroNets.UseVisualStyleBackColor = true;
            // 
            // tpUsingNeuroNets
            // 
            this.tpUsingNeuroNets.Controls.Add(this.groupBox1);
            this.tpUsingNeuroNets.Controls.Add(this.gbUsingNeuroNets);
            this.tpUsingNeuroNets.Controls.Add(this.gbTasksTree);
            this.tpUsingNeuroNets.Location = new System.Drawing.Point(4, 29);
            this.tpUsingNeuroNets.Name = "tpUsingNeuroNets";
            this.tpUsingNeuroNets.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsingNeuroNets.Size = new System.Drawing.Size(943, 593);
            this.tpUsingNeuroNets.TabIndex = 1;
            this.tpUsingNeuroNets.Text = "Использование нейронных сетей";
            this.tpUsingNeuroNets.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbEnum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbReal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbInt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(9, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 201);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нормализация";
            // 
            // cbEnum
            // 
            this.cbEnum.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEnum.FormattingEnabled = true;
            this.cbEnum.Items.AddRange(new object[] {
            "Целое",
            "Целое нормализованное",
            "Действительное нормализованное"});
            this.cbEnum.Location = new System.Drawing.Point(10, 164);
            this.cbEnum.Name = "cbEnum";
            this.cbEnum.Size = new System.Drawing.Size(267, 28);
            this.cbEnum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Перечислимые";
            // 
            // cbReal
            // 
            this.cbReal.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbReal.FormattingEnabled = true;
            this.cbReal.Items.AddRange(new object[] {
            "Действительное",
            "Целое нормализованное",
            "Действительное нормализованное"});
            this.cbReal.Location = new System.Drawing.Point(10, 110);
            this.cbReal.Name = "cbReal";
            this.cbReal.Size = new System.Drawing.Size(267, 28);
            this.cbReal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Действительные";
            // 
            // cbInt
            // 
            this.cbInt.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInt.FormattingEnabled = true;
            this.cbInt.Items.AddRange(new object[] {
            "Целое",
            "Целое нормализованное",
            "Действительное нормализованное"});
            this.cbInt.Location = new System.Drawing.Point(10, 56);
            this.cbInt.Name = "cbInt";
            this.cbInt.Size = new System.Drawing.Size(267, 28);
            this.cbInt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Целые";
            // 
            // gbUsingNeuroNets
            // 
            this.gbUsingNeuroNets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsingNeuroNets.Controls.Add(this.btnDelete);
            this.gbUsingNeuroNets.Controls.Add(this.lbLASelected);
            this.gbUsingNeuroNets.Controls.Add(this.lbLAInfo);
            this.gbUsingNeuroNets.Controls.Add(this.lbNetSelected);
            this.gbUsingNeuroNets.Controls.Add(this.lbNetInfo);
            this.gbUsingNeuroNets.Controls.Add(this.lbSelSelected);
            this.gbUsingNeuroNets.Controls.Add(this.lbSelectionInfo);
            this.gbUsingNeuroNets.Controls.Add(this.lbTaskSelected);
            this.gbUsingNeuroNets.Controls.Add(this.lbTaskInfo);
            this.gbUsingNeuroNets.Controls.Add(this.dgwLA);
            this.gbUsingNeuroNets.Controls.Add(this.lbInfo);
            this.gbUsingNeuroNets.Controls.Add(this.btnLearn);
            this.gbUsingNeuroNets.Controls.Add(this.btnUse);
            this.gbUsingNeuroNets.Controls.Add(this.dgwNets);
            this.gbUsingNeuroNets.Font = new System.Drawing.Font("Book Antiqua", 18F);
            this.gbUsingNeuroNets.Location = new System.Drawing.Point(305, 6);
            this.gbUsingNeuroNets.Name = "gbUsingNeuroNets";
            this.gbUsingNeuroNets.Size = new System.Drawing.Size(634, 577);
            this.gbUsingNeuroNets.TabIndex = 8;
            this.gbUsingNeuroNets.TabStop = false;
            this.gbUsingNeuroNets.Text = "Обученные/необученные нейронные сети";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(542, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbLASelected
            // 
            this.lbLASelected.AutoSize = true;
            this.lbLASelected.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLASelected.Location = new System.Drawing.Point(176, 146);
            this.lbLASelected.Name = "lbLASelected";
            this.lbLASelected.Size = new System.Drawing.Size(79, 20);
            this.lbLASelected.TabIndex = 15;
            this.lbLASelected.Text = "Не выбран";
            // 
            // lbLAInfo
            // 
            this.lbLAInfo.AutoSize = true;
            this.lbLAInfo.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lbLAInfo.Location = new System.Drawing.Point(5, 146);
            this.lbLAInfo.Name = "lbLAInfo";
            this.lbLAInfo.Size = new System.Drawing.Size(165, 20);
            this.lbLAInfo.TabIndex = 14;
            this.lbLAInfo.Text = "Алгоритм обучения:";
            // 
            // lbNetSelected
            // 
            this.lbNetSelected.AutoSize = true;
            this.lbNetSelected.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNetSelected.Location = new System.Drawing.Point(145, 126);
            this.lbNetSelected.Name = "lbNetSelected";
            this.lbNetSelected.Size = new System.Drawing.Size(86, 20);
            this.lbNetSelected.TabIndex = 13;
            this.lbNetSelected.Text = "Не выбрана";
            // 
            // lbNetInfo
            // 
            this.lbNetInfo.AutoSize = true;
            this.lbNetInfo.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lbNetInfo.Location = new System.Drawing.Point(5, 126);
            this.lbNetInfo.Name = "lbNetInfo";
            this.lbNetInfo.Size = new System.Drawing.Size(134, 20);
            this.lbNetInfo.TabIndex = 12;
            this.lbNetInfo.Text = "Нейронная сеть:";
            // 
            // lbSelSelected
            // 
            this.lbSelSelected.AutoSize = true;
            this.lbSelSelected.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSelSelected.Location = new System.Drawing.Point(91, 106);
            this.lbSelSelected.Name = "lbSelSelected";
            this.lbSelSelected.Size = new System.Drawing.Size(86, 20);
            this.lbSelSelected.TabIndex = 11;
            this.lbSelSelected.Text = "Не выбрана";
            // 
            // lbSelectionInfo
            // 
            this.lbSelectionInfo.AutoSize = true;
            this.lbSelectionInfo.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lbSelectionInfo.Location = new System.Drawing.Point(5, 106);
            this.lbSelectionInfo.Name = "lbSelectionInfo";
            this.lbSelectionInfo.Size = new System.Drawing.Size(80, 20);
            this.lbSelectionInfo.TabIndex = 10;
            this.lbSelectionInfo.Text = "Выборка:";
            // 
            // lbTaskSelected
            // 
            this.lbTaskSelected.AutoSize = true;
            this.lbTaskSelected.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTaskSelected.Location = new System.Drawing.Point(75, 86);
            this.lbTaskSelected.Name = "lbTaskSelected";
            this.lbTaskSelected.Size = new System.Drawing.Size(86, 20);
            this.lbTaskSelected.TabIndex = 9;
            this.lbTaskSelected.Text = "Не выбрана";
            // 
            // lbTaskInfo
            // 
            this.lbTaskInfo.AutoSize = true;
            this.lbTaskInfo.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lbTaskInfo.Location = new System.Drawing.Point(5, 86);
            this.lbTaskInfo.Name = "lbTaskInfo";
            this.lbTaskInfo.Size = new System.Drawing.Size(64, 20);
            this.lbTaskInfo.TabIndex = 8;
            this.lbTaskInfo.Text = "Задача:";
            // 
            // dgwLA
            // 
            this.dgwLA.AllowUserToAddRows = false;
            this.dgwLA.AllowUserToDeleteRows = false;
            this.dgwLA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgwLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLA.Location = new System.Drawing.Point(9, 375);
            this.dgwLA.Name = "dgwLA";
            this.dgwLA.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.dgwLA.Size = new System.Drawing.Size(618, 196);
            this.dgwLA.TabIndex = 7;
            this.dgwLA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwLA_MouseUp);
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.Location = new System.Drawing.Point(6, 33);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(622, 73);
            this.lbInfo.TabIndex = 5;
            this.lbInfo.Text = resources.GetString("lbInfo.Text");
            // 
            // btnLearn
            // 
            this.btnLearn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLearn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLearn.Location = new System.Drawing.Point(354, 126);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(85, 35);
            this.btnLearn.TabIndex = 3;
            this.btnLearn.Text = "Обучить";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnUse
            // 
            this.btnUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUse.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUse.Location = new System.Drawing.Point(445, 126);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(91, 35);
            this.btnUse.TabIndex = 4;
            this.btnUse.Text = "Решить";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // dgwNets
            // 
            this.dgwNets.AllowUserToAddRows = false;
            this.dgwNets.AllowUserToDeleteRows = false;
            this.dgwNets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwNets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNets.Location = new System.Drawing.Point(9, 169);
            this.dgwNets.Name = "dgwNets";
            this.dgwNets.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Book Antiqua", 9.75F);
            this.dgwNets.Size = new System.Drawing.Size(618, 200);
            this.dgwNets.TabIndex = 2;
            this.dgwNets.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgwNets_MouseUp);
            // 
            // gbTasksTree
            // 
            this.gbTasksTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbTasksTree.Controls.Add(this.tvTaskSelections);
            this.gbTasksTree.Font = new System.Drawing.Font("Book Antiqua", 18F);
            this.gbTasksTree.Location = new System.Drawing.Point(6, 6);
            this.gbTasksTree.Name = "gbTasksTree";
            this.gbTasksTree.Size = new System.Drawing.Size(293, 370);
            this.gbTasksTree.TabIndex = 7;
            this.gbTasksTree.TabStop = false;
            this.gbTasksTree.Text = "Дерево задач";
            // 
            // tvTaskSelections
            // 
            this.tvTaskSelections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTaskSelections.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvTaskSelections.Location = new System.Drawing.Point(3, 33);
            this.tvTaskSelections.Name = "tvTaskSelections";
            this.tvTaskSelections.Size = new System.Drawing.Size(287, 334);
            this.tvTaskSelections.TabIndex = 5;
            this.tvTaskSelections.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTaskSelections_AfterSelect);
            // 
            // NeuroNetsMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 650);
            this.Controls.Add(this.tcInfoAboutNN);
            this.MinimumSize = new System.Drawing.Size(986, 689);
            this.Name = "NeuroNetsMainWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Нейронные сети";
            ((System.ComponentModel.ISupportInitialize)(this.dgwNeuroNets)).EndInit();
            this.gbNeuroNets.ResumeLayout(false);
            this.gbParamsAF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwParamsAF)).EndInit();
            this.gbNeuronsInLayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNeuronsInLayers)).EndInit();
            this.tcInfoAboutNN.ResumeLayout(false);
            this.tpEditingNeuroNets.ResumeLayout(false);
            this.tpUsingNeuroNets.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUsingNeuroNets.ResumeLayout(false);
            this.gbUsingNeuroNets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNets)).EndInit();
            this.gbTasksTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwNeuroNets;
        private System.Windows.Forms.GroupBox gbNeuroNets;
        private System.Windows.Forms.Button btnChangeNeuroNet;
        private System.Windows.Forms.Button btnAddNeuroNet;
        private System.Windows.Forms.Button btnDeleteNeuroNet;
        private System.Windows.Forms.TabControl tcInfoAboutNN;
        private System.Windows.Forms.TabPage tpEditingNeuroNets;
        private System.Windows.Forms.GroupBox gbParamsAF;
        private System.Windows.Forms.DataGridView dgwParamsAF;
        private System.Windows.Forms.GroupBox gbNeuronsInLayers;
        private System.Windows.Forms.DataGridView dgwNeuronsInLayers;
        private System.Windows.Forms.TabPage tpUsingNeuroNets;
        private System.Windows.Forms.DataGridView dgwNets;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.TreeView tvTaskSelections;
        private System.Windows.Forms.GroupBox gbTasksTree;
        private System.Windows.Forms.GroupBox gbUsingNeuroNets;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.DataGridView dgwLA;
        private System.Windows.Forms.Label lbLASelected;
        private System.Windows.Forms.Label lbLAInfo;
        private System.Windows.Forms.Label lbNetSelected;
        private System.Windows.Forms.Label lbNetInfo;
        private System.Windows.Forms.Label lbSelSelected;
        private System.Windows.Forms.Label lbSelectionInfo;
        private System.Windows.Forms.Label lbTaskSelected;
        private System.Windows.Forms.Label lbTaskInfo;
        private System.Windows.Forms.Label lbRedactingInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbReal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbInt;
        private System.Windows.Forms.Label label1;
    }
}

