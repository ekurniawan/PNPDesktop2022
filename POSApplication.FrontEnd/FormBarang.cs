﻿using POSApplication.FrontEnd.DAL;
using POSApplication.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApplication.FrontEnd
{
    public partial class FormBarang : Form
    {
        private BarangDAL barangDAL;

        private BindingSource bs;
        private bool isNew = false;

        public FormBarang()
        {
            InitializeComponent();
            barangDAL = new BarangDAL();
            bs = new BindingSource();
        }

        #region Data Binding

        private void TambahBinding()
        {
            txtKodeBarang.DataBindings.Add("Text", bs, "KodeBarang");
            txtNamaBarang.DataBindings.Add("Text", bs, "NamaBarang");
            txtHargaBeli.DataBindings.Add("Text", bs, "HargaBeli");
            txtHargaBeli.DataBindings[0].FormattingEnabled = true;
            txtHargaBeli.DataBindings[0].FormatString = "N0";

            txtHargaJual.DataBindings.Add("Text", bs, "HargaJual");
            txtHargaJual.DataBindings[0].FormattingEnabled = true;
            txtHargaJual.DataBindings[0].FormatString = "N0";

            txtStok.DataBindings.Add("Text", bs, "Stok");
            dtpTanggalBeli.DataBindings.Add("Value", bs, "TanggalBeli");
            txtKeterangan.DataBindings.Add("Text", bs, "Keterangan");
        }

        private void HapusBinding()
        {
            txtKodeBarang.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtHargaBeli.DataBindings.Clear();
            txtHargaJual.DataBindings.Clear();
            txtStok.DataBindings.Clear();
            dtpTanggalBeli.DataBindings.Clear();
            txtKeterangan.DataBindings.Clear();
        }

        #endregion

        #region Inisialisasi Kontrol

        private void InisialisasiAwal()
        {
            txtKodeBarang.Enabled = false;
            txtNamaBarang.Enabled = false;
            txtHargaBeli.Enabled = false;
            txtHargaJual.Enabled = false;
            txtStok.Enabled = false;
            dtpTanggalBeli.Enabled = false;
            txtKeterangan.Enabled = false;

            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;

            IsiDataBarang();
            TambahBinding();
            isNew = false;
        }

        private void InisialisasiNew()
        {
            HapusBinding();
            foreach(var ctr in this.Controls)
            {
                if(ctr is TextBox)
                {
                    var myTextBox = ctr as TextBox;
                    myTextBox.Enabled = true;
                    myTextBox.Text = String.Empty;
                }
                else if(ctr is Button)
                {
                    var myButton = ctr as Button;
                    myButton.Enabled = false;
                }
            }
            dtpTanggalBeli.Enabled = true;
            txtKodeBarang.Focus();
            btnSave.Enabled = true;
            isNew = true;
        }

        #endregion

        #region CRUD

        private void InsertBarang()
        {
            try
            {
                var newBarang = new Barang
                {
                    KodeBarang = txtKodeBarang.Text,
                    NamaBarang = txtNamaBarang.Text,
                    HargaBeli = Convert.ToDecimal(txtHargaBeli.Text),
                    HargaJual = Convert.ToDecimal(txtHargaJual.Text),
                    Stok = Convert.ToInt32(txtStok.Text),
                    TanggalBeli =dtpTanggalBeli.Value,
                    Keterangan = txtKeterangan.Text
                };
                int result = barangDAL.Insert(newBarang);
                if(result == 1)
                {
                    MessageBox.Show($"Data barang {newBarang.NamaBarang} berhasil ditambahkan");
                    InisialisasiAwal();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data", "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Kesalahan",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void IsiDataBarang()
        {
            bs.DataSource = barangDAL.GetAll();
            dgvBarang.DataSource = bs;
        }


        private void FormBarang_Load(object sender, EventArgs e)
        {
            InisialisasiAwal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNew) 
            {
                InsertBarang();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InisialisasiNew();
        }
    }
}
