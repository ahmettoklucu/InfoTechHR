﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layer.Business.System;
using Layer.Business.User;

namespace InfoTechHR
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {


            string DepartmanAdi = TxtDepartmanAdi.Text;
            SysDepartment department = new SysDepartment();
            department.AddDepartment(DepartmanAdi);





        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            UserProcess Kullanici = new UserProcess();
            string HataMesaji;
            bool Basarili = Kullanici.Login(TxtKullaniciAdi.Text, TxtSifre.Text,out HataMesaji);
            if (!Basarili)
            {
                MessageBox.Show(HataMesaji);
            }
            else
            {
                MessageBox.Show("Aferim");
            }
        }
    }
}
