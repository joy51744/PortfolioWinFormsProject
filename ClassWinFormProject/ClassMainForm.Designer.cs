﻿namespace ClassWinFormProject
{
    partial class ClassMainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonCompounding = new System.Windows.Forms.Button();
            this.buttonFor1 = new System.Windows.Forms.Button();
            this.buttonFor = new System.Windows.Forms.Button();
            this.buttonWhile = new System.Windows.Forms.Button();
            this.buttonIf = new System.Windows.Forms.Button();
            this.buttonLogic = new System.Windows.Forms.Button();
            this.buttonMarquee = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.buttonTextBox = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonTextCalculate = new System.Windows.Forms.Button();
            this.buttonHello = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 21.75F);
            this.label1.Location = new System.Drawing.Point(290, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 34);
            this.label1.TabIndex = 42;
            this.label1.Text = "C# Class Project";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "專案";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "10201";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "10202";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel2.Text = "離開";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonContinue.Location = new System.Drawing.Point(645, 383);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(130, 45);
            this.buttonContinue.TabIndex = 146;
            this.buttonContinue.Text = "繼續迴圈";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMoney.Location = new System.Drawing.Point(645, 288);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(130, 45);
            this.buttonMoney.TabIndex = 145;
            this.buttonMoney.Text = "錢幣兌換";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonCompounding
            // 
            this.buttonCompounding.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCompounding.Location = new System.Drawing.Point(645, 193);
            this.buttonCompounding.Name = "buttonCompounding";
            this.buttonCompounding.Size = new System.Drawing.Size(130, 45);
            this.buttonCompounding.TabIndex = 144;
            this.buttonCompounding.Text = "複利計算";
            this.buttonCompounding.UseVisualStyleBackColor = true;
            this.buttonCompounding.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonFor1
            // 
            this.buttonFor1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFor1.Location = new System.Drawing.Point(643, 97);
            this.buttonFor1.Name = "buttonFor1";
            this.buttonFor1.Size = new System.Drawing.Size(130, 45);
            this.buttonFor1.TabIndex = 143;
            this.buttonFor1.Text = "巴斯卡三角形";
            this.buttonFor1.UseVisualStyleBackColor = true;
            this.buttonFor1.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonFor
            // 
            this.buttonFor.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFor.Location = new System.Drawing.Point(437, 383);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(130, 45);
            this.buttonFor.TabIndex = 142;
            this.buttonFor.Text = "九九乘法表";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonWhile
            // 
            this.buttonWhile.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonWhile.Location = new System.Drawing.Point(437, 288);
            this.buttonWhile.Name = "buttonWhile";
            this.buttonWhile.Size = new System.Drawing.Size(130, 45);
            this.buttonWhile.TabIndex = 141;
            this.buttonWhile.Text = "溫度轉換";
            this.buttonWhile.UseVisualStyleBackColor = true;
            this.buttonWhile.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonIf
            // 
            this.buttonIf.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonIf.Location = new System.Drawing.Point(437, 193);
            this.buttonIf.Name = "buttonIf";
            this.buttonIf.Size = new System.Drawing.Size(130, 45);
            this.buttonIf.TabIndex = 140;
            this.buttonIf.Text = "偶數判斷";
            this.buttonIf.UseVisualStyleBackColor = true;
            this.buttonIf.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonLogic
            // 
            this.buttonLogic.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonLogic.Location = new System.Drawing.Point(437, 98);
            this.buttonLogic.Name = "buttonLogic";
            this.buttonLogic.Size = new System.Drawing.Size(130, 45);
            this.buttonLogic.TabIndex = 139;
            this.buttonLogic.Text = "邏輯判斷";
            this.buttonLogic.UseVisualStyleBackColor = true;
            this.buttonLogic.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonMarquee
            // 
            this.buttonMarquee.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMarquee.Location = new System.Drawing.Point(231, 383);
            this.buttonMarquee.Name = "buttonMarquee";
            this.buttonMarquee.Size = new System.Drawing.Size(130, 45);
            this.buttonMarquee.TabIndex = 138;
            this.buttonMarquee.Text = "跑馬燈";
            this.buttonMarquee.UseVisualStyleBackColor = true;
            this.buttonMarquee.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTimer.Location = new System.Drawing.Point(231, 288);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(130, 45);
            this.buttonTimer.TabIndex = 137;
            this.buttonTimer.Text = "計時器";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTicket.Location = new System.Drawing.Point(231, 193);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(130, 45);
            this.buttonTicket.TabIndex = 136;
            this.buttonTicket.Text = "高鐵訂票";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button.Location = new System.Drawing.Point(231, 97);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(130, 45);
            this.button.TabIndex = 135;
            this.button.Text = "會員資訊";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonTextBox
            // 
            this.buttonTextBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTextBox.Location = new System.Drawing.Point(25, 383);
            this.buttonTextBox.Name = "buttonTextBox";
            this.buttonTextBox.Size = new System.Drawing.Size(130, 45);
            this.buttonTextBox.TabIndex = 134;
            this.buttonTextBox.Text = "文字方塊";
            this.buttonTextBox.UseVisualStyleBackColor = true;
            this.buttonTextBox.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStatistic.Location = new System.Drawing.Point(25, 288);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(130, 45);
            this.buttonStatistic.TabIndex = 133;
            this.buttonStatistic.Text = "便當統計";
            this.buttonStatistic.UseVisualStyleBackColor = true;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonTextCalculate
            // 
            this.buttonTextCalculate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTextCalculate.Location = new System.Drawing.Point(25, 193);
            this.buttonTextCalculate.Name = "buttonTextCalculate";
            this.buttonTextCalculate.Size = new System.Drawing.Size(130, 45);
            this.buttonTextCalculate.TabIndex = 132;
            this.buttonTextCalculate.Text = "基本運算";
            this.buttonTextCalculate.UseVisualStyleBackColor = true;
            this.buttonTextCalculate.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonHello
            // 
            this.buttonHello.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonHello.Location = new System.Drawing.Point(25, 98);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(130, 45);
            this.buttonHello.TabIndex = 131;
            this.buttonHello.Text = "打招呼";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // ClassMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonMoney);
            this.Controls.Add(this.buttonCompounding);
            this.Controls.Add(this.buttonFor1);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.buttonWhile);
            this.Controls.Add(this.buttonIf);
            this.Controls.Add(this.buttonLogic);
            this.Controls.Add(this.buttonMarquee);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonTextBox);
            this.Controls.Add(this.buttonStatistic);
            this.Controls.Add(this.buttonTextCalculate);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "ClassMainForm";
            this.Text = "馬顥心 | C#課程專案";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonCompounding;
        private System.Windows.Forms.Button buttonFor1;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.Button buttonWhile;
        private System.Windows.Forms.Button buttonIf;
        private System.Windows.Forms.Button buttonLogic;
        private System.Windows.Forms.Button buttonMarquee;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonTextBox;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonTextCalculate;
        private System.Windows.Forms.Button buttonHello;
    }
}

