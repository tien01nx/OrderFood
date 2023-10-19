﻿using API.DTO;
using Client.Entities;
using Client.Model;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace Client.UserControls
{
    public partial class ucListOrder : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ApiClient _apiClient;

        private string selectedRestaurantId;
        private List<UserInfoDTO> userInfoDTOs;
        private List<Order> orders;
        public ucListOrder()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private void ucListOrder_Load(object sender, EventArgs e)
        {

            dtOrderDate.DateTime = DateTime.Now;
            GetData();
            GetRestaurant();
            getRestaurantAddList();
        }


        // GetData
        public void GetData()
        {
            DateTime date = dtOrderDate.DateTime;
            string startDate = date.ToString("yyyy/MM/dd");
            string endDate = null;
            string userName = string.IsNullOrEmpty(txtUserName.Text) ? "" : txtUserName.Text;
            string userId = null;
            selectedRestaurantId = string.IsNullOrEmpty(selectedRestaurantId) ? "" : selectedRestaurantId;
            string productName = string.IsNullOrEmpty(txtTile.Text) ? "" : txtTile.Text;


            try
            {
                var userOrder = _apiClient.GetData<UserInfoDTO>($"Order/UserAllOrders?startDate={startDate}&endDate={endDate}&UserName={userName}&userId={userId}&restaurants={selectedRestaurantId}&productName={productName}").Data;
                var restaurants = _apiClient.GetData<Order>($"Restaurant/GetAllRestaurant?date={startDate}").Data;
                userInfoDTOs = userOrder;
                orders = restaurants;
                gridData.DataSource = orders;
                gridData.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private void GetRestaurant()
        {
            try
            {
                var restaurants = _apiClient.GetData<Restaurant>("Restaurant/Getall").Data;

                // Gán dữ liệu cho LookUpEdit
                ludRestaurant.Properties.DataSource = restaurants;
                ludRestaurant.Properties.DisplayMember = "RestaurantName";
                ludRestaurant.Properties.ValueMember = "Id";

                // Thiết lập chế độ hiển thị
                ludRestaurant.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                //lookUpEdit.Properties.SearchMode = SearchMode.AutoComplete;
                ludRestaurant.Properties.SearchMode = SearchMode.AutoFilter;
                ludRestaurant.Properties.ImmediatePopup = true;
                ludRestaurant.Properties.ShowHeader = false;
                ludRestaurant.Properties.TextEditStyle = TextEditStyles.Standard;
                ludRestaurant.Properties.AutoSearchColumnIndex = 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void SubBtnOrder_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {
                frmMain.Instance.AddUserControl(new ucOrder(), "ucOrder");
            }

        }

        private void closeUcListOrder_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {
                frmMain.Instance.AddUserControl(new ucListOrder(), "ucListOrder");
            }
        }


        private void SubBtnSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void dtOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            GetData();

        }

        private void txtUserName_EditValueChanged(object sender, EventArgs e)
        {
            GetData();


        }

        private void txtTile_EditValueChanged(object sender, EventArgs e)
        {
            GetData();

        }

        private void lookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            selectedRestaurantId = ludRestaurant.EditValue.ToString();
            GetData();

        }

        private void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                Order order = view.GetRow(e.RowHandle) as Order;
                if (order != null)
                {
                    e.IsEmpty = !userInfoDTOs.Any(x => x.RestaurantId == order.Restaurant.Id);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }   
            
        }

        private void gridView1_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {

            GridView view = sender as GridView;
            Order order = view.GetRow(e.RowHandle) as Order;
            if (order != null)
            {
                e.ChildList = userInfoDTOs.Where(x => x.RestaurantId == order.Restaurant.Id).ToList();
            }
        }

        private void gridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Danh sách người dùng";
        }

        private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView1.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { CalRowIndicatorWidth(_Width, gridView1); }));

                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { CalRowIndicatorWidth(_Width, gridView1); }));
            }
        }

        bool CalRowIndicatorWidth(Int32 _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void gridView4_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (!gridView4.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { CalRowIndicatorWidth(_Width, gridView4); }));

                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { CalRowIndicatorWidth(_Width, gridView4); }));
            }
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            MessageBox.Show("Edit");
        }

        // lấy thông tin nhà hàng cho vào list trong SessionData
        private void getRestaurantAddList()
        {
            var restaurant = _apiClient.GetData<RestaurantVM>(
                               $"Restaurant/Getall").Data;
            // add dữ liệu vào list
            foreach (var item in restaurant)
            {
                SessionData.addAllRestaurant(item);
            }
        }

        private void SubbtnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
