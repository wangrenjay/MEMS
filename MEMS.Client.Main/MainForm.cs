using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using MEMS.Client.Common;
//using MEMS.Client.Main.CRMService;
using DevExpress.XtraEditors;
using MEMS.Client.CRM;

namespace MEMS.Client.Main
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("是否退出系统","提示",MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void BtnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(CustomerListForm));
        }

        private void BtnSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(SupplierListForm));
        }

        private void BtnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormFactory.LoadForm(this, typeof(ProductListForm));
            //this.ActivateMdiChild(new ProductListForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            selectPageCategory.Visible = false;
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                {
                    if (ActiveMdiChild is BaseListForm)
                    {
                        //Console.WriteLine(this.ActiveMdiChild.Name);
                        selectPageCategory.MergedPages.Clear();
                        var ribbonfrm = ActiveMdiChild as BaseListForm;
                        ribbonfrm.ribbonMenu.Text = ribbonfrm.Text;
                        this.selectPageCategory.MergedPages.Add(ribbonfrm.ribbonMenu);
                        this.selectPageCategory.Visible = true;
                        //this.selectPageCategory.Expanded = true;
                        ribbonControl.SelectedPage = ribbonfrm.ribbonMenu;
                    }
                }
                else
                {
                    selectPageCategory.MergedPages.Clear();
                }
                Console.WriteLine(ribbonControl.MergedPages.Count);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}