using QLQuanCafe.DAO;
using QLQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public fAdmin()
        {
            InitializeComponent();
            Load();
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

        //void LoadDateTimePickerBill()
        //{
        //    DateTime today = DateTime.Now;
        //    dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
        //    dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        //}
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

        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisPlayname.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txbAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Bạn có thể để trống hoặc thêm code tùy ý.
        }


        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}
