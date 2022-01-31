
namespace TASK_1_POE_Proper
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goldAmount_Label = new System.Windows.Forms.Label();
            this.weaponDuribility_Label = new System.Windows.Forms.Label();
            this.damage_Label = new System.Windows.Forms.Label();
            this.range_Label = new System.Windows.Forms.Label();
            this.playerWeapon_Label = new System.Windows.Forms.Label();
            this.playerHP_Label = new System.Windows.Forms.Label();
            this.Gold_Label = new System.Windows.Forms.Label();
            this.Durability_Label = new System.Windows.Forms.Label();
            this.WeaponDamage_Label = new System.Windows.Forms.Label();
            this.WeaponRange_Label = new System.Windows.Forms.Label();
            this.Weapon_Label = new System.Windows.Forms.Label();
            this.Health_Label = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.attackUp_Btn = new System.Windows.Forms.Button();
            this.attackLeft_Btn = new System.Windows.Forms.Button();
            this.attackRight_Btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.attackDown_Btn = new System.Windows.Forms.Button();
            this.attackLog_RTB = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goldAmount_Label);
            this.groupBox1.Controls.Add(this.weaponDuribility_Label);
            this.groupBox1.Controls.Add(this.damage_Label);
            this.groupBox1.Controls.Add(this.range_Label);
            this.groupBox1.Controls.Add(this.playerWeapon_Label);
            this.groupBox1.Controls.Add(this.playerHP_Label);
            this.groupBox1.Controls.Add(this.Gold_Label);
            this.groupBox1.Controls.Add(this.Durability_Label);
            this.groupBox1.Controls.Add(this.WeaponDamage_Label);
            this.groupBox1.Controls.Add(this.WeaponRange_Label);
            this.groupBox1.Controls.Add(this.Weapon_Label);
            this.groupBox1.Controls.Add(this.Health_Label);
            this.groupBox1.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(774, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 328);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Stats";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // goldAmount_Label
            // 
            this.goldAmount_Label.AutoSize = true;
            this.goldAmount_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goldAmount_Label.Location = new System.Drawing.Point(299, 285);
            this.goldAmount_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.goldAmount_Label.Name = "goldAmount_Label";
            this.goldAmount_Label.Size = new System.Drawing.Size(19, 19);
            this.goldAmount_Label.TabIndex = 11;
            this.goldAmount_Label.Text = "0";
            // 
            // weaponDuribility_Label
            // 
            this.weaponDuribility_Label.AutoSize = true;
            this.weaponDuribility_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weaponDuribility_Label.Location = new System.Drawing.Point(299, 229);
            this.weaponDuribility_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.weaponDuribility_Label.Name = "weaponDuribility_Label";
            this.weaponDuribility_Label.Size = new System.Drawing.Size(40, 19);
            this.weaponDuribility_Label.TabIndex = 10;
            this.weaponDuribility_Label.Text = "N/A";
            // 
            // damage_Label
            // 
            this.damage_Label.AutoSize = true;
            this.damage_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.damage_Label.Location = new System.Drawing.Point(299, 184);
            this.damage_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.damage_Label.Name = "damage_Label";
            this.damage_Label.Size = new System.Drawing.Size(19, 19);
            this.damage_Label.TabIndex = 9;
            this.damage_Label.Text = "2";
            // 
            // range_Label
            // 
            this.range_Label.AutoSize = true;
            this.range_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.range_Label.Location = new System.Drawing.Point(299, 131);
            this.range_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.range_Label.Name = "range_Label";
            this.range_Label.Size = new System.Drawing.Size(19, 19);
            this.range_Label.TabIndex = 8;
            this.range_Label.Text = "1";
            // 
            // playerWeapon_Label
            // 
            this.playerWeapon_Label.AutoSize = true;
            this.playerWeapon_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerWeapon_Label.Location = new System.Drawing.Point(299, 79);
            this.playerWeapon_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerWeapon_Label.Name = "playerWeapon_Label";
            this.playerWeapon_Label.Size = new System.Drawing.Size(51, 19);
            this.playerWeapon_Label.TabIndex = 7;
            this.playerWeapon_Label.Text = "None";
            // 
            // playerHP_Label
            // 
            this.playerHP_Label.AutoSize = true;
            this.playerHP_Label.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerHP_Label.Location = new System.Drawing.Point(299, 37);
            this.playerHP_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerHP_Label.Name = "playerHP_Label";
            this.playerHP_Label.Size = new System.Drawing.Size(77, 19);
            this.playerHP_Label.TabIndex = 6;
            this.playerHP_Label.Text = "100/100";
            // 
            // Gold_Label
            // 
            this.Gold_Label.AutoSize = true;
            this.Gold_Label.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Gold_Label.Location = new System.Drawing.Point(15, 285);
            this.Gold_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Gold_Label.Name = "Gold_Label";
            this.Gold_Label.Size = new System.Drawing.Size(65, 21);
            this.Gold_Label.TabIndex = 5;
            this.Gold_Label.Text = "Gold";
            // 
            // Durability_Label
            // 
            this.Durability_Label.AutoSize = true;
            this.Durability_Label.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Durability_Label.Location = new System.Drawing.Point(13, 229);
            this.Durability_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Durability_Label.Name = "Durability_Label";
            this.Durability_Label.Size = new System.Drawing.Size(129, 21);
            this.Durability_Label.TabIndex = 4;
            this.Durability_Label.Text = "Durability";
            // 
            // WeaponDamage_Label
            // 
            this.WeaponDamage_Label.AutoSize = true;
            this.WeaponDamage_Label.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WeaponDamage_Label.Location = new System.Drawing.Point(13, 184);
            this.WeaponDamage_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WeaponDamage_Label.Name = "WeaponDamage_Label";
            this.WeaponDamage_Label.Size = new System.Drawing.Size(95, 21);
            this.WeaponDamage_Label.TabIndex = 3;
            this.WeaponDamage_Label.Text = "Damage";
            // 
            // WeaponRange_Label
            // 
            this.WeaponRange_Label.AutoSize = true;
            this.WeaponRange_Label.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WeaponRange_Label.Location = new System.Drawing.Point(15, 131);
            this.WeaponRange_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WeaponRange_Label.Name = "WeaponRange_Label";
            this.WeaponRange_Label.Size = new System.Drawing.Size(76, 21);
            this.WeaponRange_Label.TabIndex = 2;
            this.WeaponRange_Label.Text = "Range";
            // 
            // Weapon_Label
            // 
            this.Weapon_Label.AutoSize = true;
            this.Weapon_Label.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Weapon_Label.Location = new System.Drawing.Point(13, 79);
            this.Weapon_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Weapon_Label.Name = "Weapon_Label";
            this.Weapon_Label.Size = new System.Drawing.Size(191, 21);
            this.Weapon_Label.TabIndex = 1;
            this.Weapon_Label.Text = "Current Weapon";
            // 
            // Health_Label
            // 
            this.Health_Label.AutoSize = true;
            this.Health_Label.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Health_Label.Location = new System.Drawing.Point(15, 37);
            this.Health_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Health_Label.Name = "Health_Label";
            this.Health_Label.Size = new System.Drawing.Size(87, 21);
            this.Health_Label.TabIndex = 0;
            this.Health_Label.Text = "Health";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMap.Location = new System.Drawing.Point(112, 19);
            this.lblMap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(54, 25);
            this.lblMap.TabIndex = 10;
            this.lblMap.Text = "MAP";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(190, 123);
            this.btnDown.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(162, 45);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click_1);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(362, 123);
            this.btnRight.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(162, 45);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click_1);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(20, 123);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(162, 45);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click_1);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUp.Location = new System.Drawing.Point(190, 71);
            this.btnUp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(162, 45);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click_1);
            // 
            // attackUp_Btn
            // 
            this.attackUp_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attackUp_Btn.Location = new System.Drawing.Point(182, 71);
            this.attackUp_Btn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.attackUp_Btn.Name = "attackUp_Btn";
            this.attackUp_Btn.Size = new System.Drawing.Size(162, 45);
            this.attackUp_Btn.TabIndex = 12;
            this.attackUp_Btn.Text = "^";
            this.attackUp_Btn.UseVisualStyleBackColor = true;
            this.attackUp_Btn.Click += new System.EventHandler(this.attackUp_Btn_Click);
            // 
            // attackLeft_Btn
            // 
            this.attackLeft_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attackLeft_Btn.Location = new System.Drawing.Point(11, 120);
            this.attackLeft_Btn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.attackLeft_Btn.Name = "attackLeft_Btn";
            this.attackLeft_Btn.Size = new System.Drawing.Size(162, 45);
            this.attackLeft_Btn.TabIndex = 14;
            this.attackLeft_Btn.Text = "<";
            this.attackLeft_Btn.UseVisualStyleBackColor = true;
            this.attackLeft_Btn.Click += new System.EventHandler(this.attackLeft_Btn_Click);
            // 
            // attackRight_Btn
            // 
            this.attackRight_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attackRight_Btn.Location = new System.Drawing.Point(353, 120);
            this.attackRight_Btn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.attackRight_Btn.Name = "attackRight_Btn";
            this.attackRight_Btn.Size = new System.Drawing.Size(162, 45);
            this.attackRight_Btn.TabIndex = 15;
            this.attackRight_Btn.Text = ">";
            this.attackRight_Btn.UseVisualStyleBackColor = true;
            this.attackRight_Btn.Click += new System.EventHandler(this.attackRight_Btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(774, 380);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(544, 192);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movement";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.attackDown_Btn);
            this.groupBox3.Controls.Add(this.attackUp_Btn);
            this.groupBox3.Controls.Add(this.attackLeft_Btn);
            this.groupBox3.Controls.Add(this.attackRight_Btn);
            this.groupBox3.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(1358, 380);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(533, 192);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attack";
            // 
            // attackDown_Btn
            // 
            this.attackDown_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attackDown_Btn.Location = new System.Drawing.Point(182, 120);
            this.attackDown_Btn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.attackDown_Btn.Name = "attackDown_Btn";
            this.attackDown_Btn.Size = new System.Drawing.Size(162, 45);
            this.attackDown_Btn.TabIndex = 17;
            this.attackDown_Btn.Text = "v";
            this.attackDown_Btn.UseVisualStyleBackColor = true;
            this.attackDown_Btn.Click += new System.EventHandler(this.attackDown_Btn_Click);
            // 
            // attackLog_RTB
            // 
            this.attackLog_RTB.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.attackLog_RTB.Location = new System.Drawing.Point(1358, 39);
            this.attackLog_RTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.attackLog_RTB.Name = "attackLog_RTB";
            this.attackLog_RTB.Size = new System.Drawing.Size(529, 306);
            this.attackLog_RTB.TabIndex = 19;
            this.attackLog_RTB.Text = "ATTACK LOG\n///////\\\\\\\\\\\\\\\\\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 793);
            this.Controls.Add(this.attackLog_RTB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMap);
            this.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Gold_Label;
        private System.Windows.Forms.Label Durability_Label;
        private System.Windows.Forms.Label WeaponDamage_Label;
        private System.Windows.Forms.Label WeaponRange_Label;
        private System.Windows.Forms.Label Weapon_Label;
        private System.Windows.Forms.Label Health_Label;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label goldAmount_Label;
        private System.Windows.Forms.Label weaponDuribility_Label;
        private System.Windows.Forms.Label damage_Label;
        private System.Windows.Forms.Label range_Label;
        private System.Windows.Forms.Label playerWeapon_Label;
        private System.Windows.Forms.Label playerHP_Label;
        private System.Windows.Forms.Button attackUp_Btn;
        private System.Windows.Forms.Button attackLeft_Btn;
        private System.Windows.Forms.Button attackRight_Btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button attackDown_Btn;
        public System.Windows.Forms.RichTextBox attackLog_RTB;
    }
}

