
using System.Windows.Forms;

namespace RestaurantApp.View
{
    partial class AccountProfile
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
            this.lb_titleInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_dob = new System.Windows.Forms.DateTimePicker();
            this.lb_dob = new System.Windows.Forms.Label();
            this.pn_gender = new System.Windows.Forms.Panel();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.lb_gender = new System.Windows.Forms.Label();
            this.text_fullname = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.errorEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pn_gender.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titleInfo
            // 
            this.lb_titleInfo.AutoSize = true;
            this.lb_titleInfo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleInfo.Location = new System.Drawing.Point(171, 9);
            this.lb_titleInfo.Name = "lb_titleInfo";
            this.lb_titleInfo.Size = new System.Drawing.Size(152, 33);
            this.lb_titleInfo.TabIndex = 0;
            this.lb_titleInfo.Text = "Thông tin ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_dob);
            this.panel1.Controls.Add(this.lb_dob);
            this.panel1.Controls.Add(this.pn_gender);
            this.panel1.Controls.Add(this.text_address);
            this.panel1.Controls.Add(this.text_email);
            this.panel1.Controls.Add(this.text_phone);
            this.panel1.Controls.Add(this.lb_gender);
            this.panel1.Controls.Add(this.text_fullname);
            this.panel1.Controls.Add(this.lb_email);
            this.panel1.Controls.Add(this.lb_address);
            this.panel1.Controls.Add(this.text_username);
            this.panel1.Controls.Add(this.lb_phone);
            this.panel1.Controls.Add(this.lb_fullname);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 264);
            this.panel1.TabIndex = 1;
            // 
            // date_dob
            // 
            this.date_dob.CustomFormat = "dd/MM/yyyy";
            this.date_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_dob.Location = new System.Drawing.Point(172, 220);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(125, 26);
            this.date_dob.TabIndex = 24;
            // 
            // lb_dob
            // 
            this.lb_dob.AutoSize = true;
            this.lb_dob.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dob.Location = new System.Drawing.Point(18, 220);
            this.lb_dob.Name = "lb_dob";
            this.lb_dob.Size = new System.Drawing.Size(85, 19);
            this.lb_dob.TabIndex = 23;
            this.lb_dob.Text = "Ngày sinh:";
            // 
            // pn_gender
            // 
            this.pn_gender.Controls.Add(this.radio_female);
            this.pn_gender.Controls.Add(this.radio_male);
            this.pn_gender.Location = new System.Drawing.Point(172, 182);
            this.pn_gender.Name = "pn_gender";
            this.pn_gender.Size = new System.Drawing.Size(273, 18);
            this.pn_gender.TabIndex = 22;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_female.Location = new System.Drawing.Point(69, 0);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(48, 23);
            this.radio_female.TabIndex = 1;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Nữ";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_male.Location = new System.Drawing.Point(3, 0);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(60, 23);
            this.radio_male.TabIndex = 0;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Nam";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // text_address
            // 
            this.text_address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_address.Location = new System.Drawing.Point(173, 147);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(275, 27);
            this.text_address.TabIndex = 13;
            this.text_address.Validating += new System.ComponentModel.CancelEventHandler(this.text_address_Validating);
            // 
            // text_email
            // 
            this.text_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.Location = new System.Drawing.Point(173, 113);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(275, 27);
            this.text_email.TabIndex = 14;
            this.text_email.Validating += new System.ComponentModel.CancelEventHandler(this.text_email_Validating);
            // 
            // text_phone
            // 
            this.text_phone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_phone.Location = new System.Drawing.Point(173, 80);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(275, 27);
            this.text_phone.TabIndex = 15;
            this.text_phone.Validating += new System.ComponentModel.CancelEventHandler(this.text_phone_Validating);
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(18, 182);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(75, 19);
            this.lb_gender.TabIndex = 8;
            this.lb_gender.Text = "Giới tính:";
            // 
            // text_fullname
            // 
            this.text_fullname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_fullname.Location = new System.Drawing.Point(173, 45);
            this.text_fullname.Name = "text_fullname";
            this.text_fullname.Size = new System.Drawing.Size(275, 27);
            this.text_fullname.TabIndex = 16;
            this.text_fullname.Validating += new System.ComponentModel.CancelEventHandler(this.text_fullname_Validating);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(20, 113);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 19);
            this.lb_email.TabIndex = 9;
            this.lb_email.Text = "Email:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(18, 147);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(63, 19);
            this.lb_address.TabIndex = 4;
            this.lb_address.Text = "Địa chỉ:";
            // 
            // text_username
            // 
            this.text_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_username.Location = new System.Drawing.Point(173, 12);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(275, 27);
            this.text_username.TabIndex = 17;
            this.text_username.Validating += new System.ComponentModel.CancelEventHandler(this.text_username_Validating);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(18, 80);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(108, 19);
            this.lb_phone.TabIndex = 5;
            this.lb_phone.Text = "Số điện thoại:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(20, 45);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(83, 19);
            this.lb_fullname.TabIndex = 10;
            this.lb_fullname.Text = "Họ và tên:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(18, 12);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(85, 19);
            this.lb_username.TabIndex = 6;
            this.lb_username.Text = "Tài khoản:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Location = new System.Drawing.Point(233, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 54);
            this.panel2.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(127, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(77, 43);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_turnBack_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(21, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 43);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // errorEmpty
            // 
            this.errorEmpty.ContainerControl = this;
            // 
            // AccountProfile
            // 
            this.AcceptButton = this.btn_update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(502, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_titleInfo);
            this.MaximizeBox = false;
            this.Name = "AccountProfile";
            this.Text = "AccountProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_gender.ResumeLayout(false);
            this.pn_gender.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titleInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.TextBox text_fullname;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel pn_gender;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.DateTimePicker date_dob;
        private System.Windows.Forms.Label lb_dob;
        private ErrorProvider errorEmpty;

        public TextBox Text_address { get => text_address; set => text_address = value; }
        public TextBox Text_email { get => text_email; set => text_email = value; }
        public TextBox Text_phone { get => text_phone; set => text_phone = value; }
        public TextBox Text_fullname { get => text_fullname; set => text_fullname = value; }
        public TextBox Text_username { get => text_username; set => text_username = value; }
        public Button Btn_update { get => btn_update; set => btn_update = value; }
        public RadioButton Radio_female { get => radio_female; set => radio_female = value; }
        public RadioButton Radio_male { get => radio_male; set => radio_male = value; }
        public DateTimePicker Date_dob { get => date_dob; set => date_dob = value; }
    }
}