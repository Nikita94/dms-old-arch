﻿namespace LearningAlgorithms
{
    partial class BackPropagationAlgorithmForm
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
            this.btnLearn = new System.Windows.Forms.Button();
            this.tbIterationNumber = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.lbIterationCount = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbTestError = new System.Windows.Forms.Label();
            this.lbTrainError = new System.Windows.Forms.Label();
            this.lbTrainPercent = new System.Windows.Forms.Label();
            this.tbTrainPercent = new System.Windows.Forms.TextBox();
            this.lbCurrentIter = new System.Windows.Forms.Label();
            this.btnWriteResult = new System.Windows.Forms.Button();
            this.chbErrorPercent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(273, 12);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(117, 39);
            this.btnLearn.TabIndex = 0;
            this.btnLearn.Text = "Начать обучение";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // tbIterationNumber
            // 
            this.tbIterationNumber.Location = new System.Drawing.Point(125, 12);
            this.tbIterationNumber.Name = "tbIterationNumber";
            this.tbIterationNumber.Size = new System.Drawing.Size(142, 20);
            this.tbIterationNumber.TabIndex = 1;
            this.tbIterationNumber.Text = "2";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(125, 38);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(142, 20);
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.Text = "0,5";
            // 
            // lbIterationCount
            // 
            this.lbIterationCount.AutoSize = true;
            this.lbIterationCount.Location = new System.Drawing.Point(12, 15);
            this.lbIterationCount.Name = "lbIterationCount";
            this.lbIterationCount.Size = new System.Drawing.Size(92, 13);
            this.lbIterationCount.TabIndex = 3;
            this.lbIterationCount.Text = "Число итераций:";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(12, 41);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(107, 13);
            this.lbSpeed.TabIndex = 4;
            this.lbSpeed.Text = "Скорость обучения:";
            // 
            // lbTestError
            // 
            this.lbTestError.AutoSize = true;
            this.lbTestError.Location = new System.Drawing.Point(12, 103);
            this.lbTestError.Name = "lbTestError";
            this.lbTestError.Size = new System.Drawing.Size(35, 13);
            this.lbTestError.TabIndex = 5;
            this.lbTestError.Text = "label1";
            // 
            // lbTrainError
            // 
            this.lbTrainError.AutoSize = true;
            this.lbTrainError.Location = new System.Drawing.Point(12, 128);
            this.lbTrainError.Name = "lbTrainError";
            this.lbTrainError.Size = new System.Drawing.Size(35, 13);
            this.lbTrainError.TabIndex = 6;
            this.lbTrainError.Text = "label2";
            // 
            // lbTrainPercent
            // 
            this.lbTrainPercent.AutoSize = true;
            this.lbTrainPercent.Location = new System.Drawing.Point(12, 67);
            this.lbTrainPercent.Name = "lbTrainPercent";
            this.lbTrainPercent.Size = new System.Drawing.Size(105, 13);
            this.lbTrainPercent.TabIndex = 8;
            this.lbTrainPercent.Text = "Отношение train/all:";
            // 
            // tbTrainPercent
            // 
            this.tbTrainPercent.Location = new System.Drawing.Point(125, 64);
            this.tbTrainPercent.Name = "tbTrainPercent";
            this.tbTrainPercent.Size = new System.Drawing.Size(142, 20);
            this.tbTrainPercent.TabIndex = 7;
            this.tbTrainPercent.Text = "0,8";
            // 
            // lbCurrentIter
            // 
            this.lbCurrentIter.AutoSize = true;
            this.lbCurrentIter.Location = new System.Drawing.Point(12, 153);
            this.lbCurrentIter.Name = "lbCurrentIter";
            this.lbCurrentIter.Size = new System.Drawing.Size(35, 13);
            this.lbCurrentIter.TabIndex = 9;
            this.lbCurrentIter.Text = "label1";
            // 
            // btnWriteResult
            // 
            this.btnWriteResult.Location = new System.Drawing.Point(273, 57);
            this.btnWriteResult.Name = "btnWriteResult";
            this.btnWriteResult.Size = new System.Drawing.Size(117, 39);
            this.btnWriteResult.TabIndex = 10;
            this.btnWriteResult.Text = "Записать результат в БД";
            this.btnWriteResult.UseVisualStyleBackColor = true;
            this.btnWriteResult.Click += new System.EventHandler(this.btnWriteResult_Click);
            // 
            // chbErrorPercent
            // 
            this.chbErrorPercent.AutoSize = true;
            this.chbErrorPercent.Location = new System.Drawing.Point(182, 189);
            this.chbErrorPercent.Name = "chbErrorPercent";
            this.chbErrorPercent.Size = new System.Drawing.Size(208, 17);
            this.chbErrorPercent.TabIndex = 11;
            this.chbErrorPercent.Text = "Ошибка: процент неверных ответов";
            this.chbErrorPercent.UseVisualStyleBackColor = true;
            // 
            // BackPropagationAlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 218);
            this.Controls.Add(this.chbErrorPercent);
            this.Controls.Add(this.btnWriteResult);
            this.Controls.Add(this.lbCurrentIter);
            this.Controls.Add(this.lbTrainPercent);
            this.Controls.Add(this.tbTrainPercent);
            this.Controls.Add(this.lbTrainError);
            this.Controls.Add(this.lbTestError);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.lbIterationCount);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbIterationNumber);
            this.Controls.Add(this.btnLearn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackPropagationAlgorithmForm";
            this.ShowIcon = false;
            this.Text = "Алгоритм обратного распространения ошибки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.TextBox tbIterationNumber;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lbIterationCount;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label lbTestError;
        private System.Windows.Forms.Label lbTrainError;
        private System.Windows.Forms.Label lbTrainPercent;
        private System.Windows.Forms.TextBox tbTrainPercent;
        private System.Windows.Forms.Label lbCurrentIter;
        private System.Windows.Forms.Button btnWriteResult;
        private System.Windows.Forms.CheckBox chbErrorPercent;
    }
}