using QLQuanCafe.DAO;
using QLQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLQuanCafe
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();

        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();
            Load();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadDateTimePickerBill();
        }

        //List<Food> SearchFoodByName(string name)
        //{
        //    List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

        //    return listFood;
        //}
        void Load()
        {
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;

            //LoadDateTimePickerBill();
            //LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            //LoadListFood();
            LoadAccount();
            //LoadCategoryIntoCombobox(cbFoodCategory);
            //AddFoodBinding();
            AddAccountBinding();
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void LoadDateTimePickerBill()
        {
           DateTime today = DateTime.Now;
           dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
           dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        //void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        //{
        //    dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        //}

        //void AddFoodBinding()
        //{
        //    txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
        //    txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
        //    nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        //}

        //void LoadCategoryIntoCombobox(ComboBox cb)
        //{
        //    cb.DataSource = CategoryDAO.Instance.GetListCategory();
        //    cb.DisplayMember = "Name";
        //}

        //void LoadListFood()
        //{
        //    foodList.DataSource = FoodDAO.Instance.GetListFood();
        //}

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisPlayname.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
            Load();
        }

        #region methods

        void Load()
        {
            LoadDateTimePickerBill();
            //LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        /*void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }*/


        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name"));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price"));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListFood()
        {
            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }
        #endregion

        #region events
        /*private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }*/
        #endregion

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
